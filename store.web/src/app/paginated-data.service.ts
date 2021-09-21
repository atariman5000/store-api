import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, Optional } from '@angular/core';
import {
  DefaultDataService,
  DefaultDataServiceConfig,
  DefaultDataServiceFactory,
  EntityCollectionDataService,
  HttpMethods,
  HttpUrlGenerator,
  QueryParams,
} from '@ngrx/data';
import { Observable, of } from 'rxjs';
import { map, tap } from 'rxjs/operators';

/**
 * DataService class that handles Django REST Framework's paginated
 * responses.
 */
export class PaginatedDataService<T> extends DefaultDataService<T> {
  private nextPageUrl: string = '';
  private count = 0;
  private page = 1;
  private pageSize = 2;

  readonly httpVerbs = {
    GET: 'GET' as HttpMethods,
    PUT: 'PUT' as HttpMethods,
    POST: 'POST' as HttpMethods,
    DELETE: 'DELETE' as HttpMethods,
  };

  constructor(
    entityName: string,
    http: HttpClient,
    httpUrlGenerator: HttpUrlGenerator,
    config?: DefaultDataServiceConfig
  ) {
    super(entityName, http, httpUrlGenerator, config);
    this.nextPageUrl = this.entitiesUrl;
    this.page = 1;
    this.count = 0;
  }

  private get apiUrl(): string {
    //entities$
    return `${this.entitiesUrl}?page=${this.page}&pageSize=${this.pageSize}`;
  }

  private get nextApiUrl(): string {
    this.page++;
    return this.apiUrl;
  }

  // Override to store nextUrl as well as map response.results.
  getWithQuery(queryParams: QueryParams | string): Observable<T[]> {
    const qParams =
      typeof queryParams === 'string'
        ? { fromString: queryParams }
        : { fromObject: queryParams };
    const params = new HttpParams(qParams);
    return this.execute(
      this.httpVerbs.GET,
      `${this.entitiesUrl}filter`,
      undefined,
      {
        params,
      }
    ).pipe(
      tap((response) => {
        // response.next would include the queryparams.
        this.nextPageUrl = this.nextApiUrl;
        this.count = response.rowCount;
      }),
      map((response) => (!!response.results ? response.results : response))
    );
  }

  /**
   * Returns total number of objects
   */
  totalCount() {
    return this.count;
  }

  /**
   * Returns boolean indicating if there's more data at server.
   */
  hasMore(): boolean {
    return !!this.nextPageUrl;
  }
}

/**
 * Custom DataServiceFactory that creates PaginatedDataService<T>,
 * instead of the DefaultDataService<T>
 */
@Injectable()
export class CustomDataServiceFactory extends DefaultDataServiceFactory {
  constructor(
    http: HttpClient,
    httpUrlGenerator: HttpUrlGenerator,
    @Optional() config?: DefaultDataServiceConfig
  ) {
    super(http, httpUrlGenerator, config);
  }

  create<T>(entityName: string): EntityCollectionDataService<T> {
    return new PaginatedDataService<T>(
      entityName,
      this.http,
      this.httpUrlGenerator,
      this.config
    );
  }
}
