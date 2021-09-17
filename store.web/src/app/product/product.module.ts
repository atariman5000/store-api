import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductComponent } from './product.component';
import { ProductService } from './product.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [ProductComponent],
  providers: [ProductService],
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  exports: [ProductComponent],
})
export class ProductModule {}
