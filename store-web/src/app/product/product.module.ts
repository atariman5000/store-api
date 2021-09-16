import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductComponent } from './product.component';
import { ProductService } from './product.service';

@NgModule({
  declarations: [ProductComponent],
  providers: [ProductService],
  imports: [CommonModule],
  exports: [ProductComponent],
})
export class ProductModule {}