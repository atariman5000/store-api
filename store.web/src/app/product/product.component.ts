import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Product } from '../model/product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent implements OnInit {
  public products$: Observable<Product[]>;

  public activeProduct: Product = {} as Product;

  constructor(
    private readonly productService: ProductService,
    private readonly fb: FormBuilder
  ) {
    this.products$ = productService.entities$;
  }

  ngOnInit(): void {
    this.getPageData();
  }

  getAll(): void {
    this.productService.getAll();
  }

  get(id: number, frm: NgForm): void {
    this.productService.getByKey(id).subscribe((r) => {
      frm.setValue(r);
      this.activeProduct = frm.value;
    });
  }

  save(p: Product): void {
    if (p.id == null) p.id = 0;
    this.productService.add(p);
  }

  onEnter(frm: NgForm) {
    if (frm.valid) {
      this.save(frm.value);
      frm.reset();
    }
  }

  private _page = 1;
  private _size = 2;

  public getPageData(): void {
    this.productService.getWithQuery({
      page: `${this._page}`,
      size: `${this._size}`,
      // sortOrder: 'name_desc',
    });
    this._page++;
    console.log(`NEW PAGE: ${this._page}`);
  }

  delete(entity: any) {
    this.productService.delete(entity);
  }
}
