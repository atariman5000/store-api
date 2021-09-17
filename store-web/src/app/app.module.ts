import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DefaultDataServiceConfig, EntityDataModule } from '@ngrx/data';
import { entityConfig } from './entity-metadata';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { HttpClientModule } from '@angular/common/http';
import { ProductModule } from './product/product.module';
import { FormsModule } from '@angular/forms';

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
    ProductModule,
  ],
  providers: [
    { provide: DefaultDataServiceConfig, useValue: defaultDataServiceConfig },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
