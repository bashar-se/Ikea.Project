import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product-type-list',
  templateUrl: './product-type-list.component.html',
  styleUrls: ['./product-type-list.component.css'],
  imports: [CommonModule]
})
export class ProductTypeListComponent implements OnInit {
  productTypes: any[] = [];
  loading = true;
  error = '';

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.productService.getProductTypes().subscribe({
      next: (data) => {
        this.productTypes = data;
        this.loading = false;
      },
      error: () => {
        this.error = 'Failed to load product types';
        this.loading = false;
      }
    });
  }
}
