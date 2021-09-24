import { Injectable } from '@angular/core';
import {
  DefaultHttpUrlGenerator,
  HttpResourceUrls,
  normalizeRoot,
  Pluralizer,
  DefaultPluralizer,
  EntityPluralNames,
} from '@ngrx/data';

import { rootUrls, pluralNames } from './entity-metadata';

@Injectable()
export class DynamicHttpUrlGenerator extends DefaultHttpUrlGenerator {
  constructor(private aPluralizer: Pluralizer = new DefaultPluralizer([])) {
    super(aPluralizer);
  }

  protected getResourceUrls(
    entityName: string,
    root: string
  ): HttpResourceUrls {
    let resourceUrls = this.knownHttpResourceUrls[entityName];
    if (!resourceUrls) {
      // rootUrls contains
      // mapping of individual ngrx data entities
      // to the root URLs of their respective data sources.
      // It contains only entities which do not have
      // the default root URL.
      if (rootUrls.hasOwnProperty(entityName)) {
        root = rootUrls[entityName].url;

        console.log(`ROOT URL:`, root);

        const nRoot = normalizeRoot(root);
        const url = `${nRoot}/${this.aPluralizer.pluralize(
          rootUrls[entityName].name
        )}/`.toLowerCase();

        resourceUrls = {
          entityResourceUrl: url,
          collectionResourceUrl: url,
        };
      } else {
        const nRoot = normalizeRoot(root);
        const url = `${nRoot}/${this.aPluralizer.pluralize(
          entityName
        )}/`.toLowerCase();

        resourceUrls = {
          entityResourceUrl: url,
          collectionResourceUrl: url,
        };
      }
      this.registerHttpResourceUrls({ [entityName]: resourceUrls });
    }
    return resourceUrls;
  }
}
