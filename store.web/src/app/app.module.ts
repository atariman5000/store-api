import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {
  DefaultDataServiceConfig,
  DefaultDataServiceFactory,
  EntityDataModule,
  HttpUrlGenerator,
} from '@ngrx/data';
import { entityConfig } from './entity-metadata';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CustomDataServiceFactory } from './paginated-data.service';
import { DynamicHttpUrlGenerator } from './dynamic-httpurl-generator';

const defaultDataServiceConfig: DefaultDataServiceConfig = {
  root: 'https://localhost:5000/api',
  timeout: 3000, // request timeout
};

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    /* NgRx Specific Modules */
    StoreModule.forRoot({}),
    EffectsModule.forRoot(),
    EntityDataModule.forRoot(entityConfig),
  ],
  providers: [
    { provide: DefaultDataServiceConfig, useValue: defaultDataServiceConfig },
    { provide: DefaultDataServiceFactory, useClass: CustomDataServiceFactory },
    { provide: HttpUrlGenerator, useClass: DynamicHttpUrlGenerator },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
