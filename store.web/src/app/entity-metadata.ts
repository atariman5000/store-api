import {
  EntityMetadataMap,
  EntityDataModuleConfig,
  EntityPluralNames,
} from '@ngrx/data';

const entityMetadata: EntityMetadataMap = {
  Product: {},
};

export const pluralNames: EntityPluralNames = {
  Product: 'Products',
};

export const entityConfig: EntityDataModuleConfig = {
  entityMetadata,
  pluralNames,
};

const rootUrl = 'https://localhost:5000/api/';

export const rootUrls: any = {
  // Hero:        - not needed here, data comes from default root
  //AtbPerson: { url: `${rootUrl}lookup/` } as SimpleThing,
  Product: { url: `${rootUrl}`, name: 'product' },
  LtbGender: { url: `${rootUrl}lookup/`, name: 'gender' },
  UicDetail: { url: `${rootUrl}lookup/`, name: 'UicDetail' },
};
