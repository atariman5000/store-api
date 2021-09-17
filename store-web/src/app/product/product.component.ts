import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { Product } from '../model/product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent implements OnInit {
  public products$: Observable<Product[]>;

  constructor(
    private readonly productService: ProductService,
    private readonly fb: FormBuilder
  ) {
    this.products$ = productService.entities$;
  }

  ngOnInit(): void {
    this.getAllProducts();
  }

  save(frm: NgForm): void {
    let p = { name: frm.controls['name'].value } as Product;
    this.productService.add(p);
  }

  getAllProducts(): void {
    this.productService.getAll();
  }
}
