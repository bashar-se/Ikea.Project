import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { CommonModule } from '@angular/common';
import { forkJoin, Observable } from 'rxjs';
import { map, switchMap } from 'rxjs/operators';

interface Product {
  id: number;
  name: string;
  productType?: { id: number; name: string };
  colours?: { id: number; name: string }[];
}

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
  imports: [CommonModule]
})
export class ProductListComponent implements OnInit {
  products: Product[] = [];
  loading = true;
  error = '';

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.loadProductsWithDetails();
  }

  loadProductsWithDetails(): void {
    this.productService.getProducts().pipe(
      // Transform the array of basic products into an array of observables for detailed products
      switchMap(basicProducts => {
        if (basicProducts.length === 0) {
          return [];
        }
        
        // Create an observable for each product's details
        const detailObservables = basicProducts.map(product => 
          this.productService.getProductById(product.id)
        );
        
        // Wait for all detail requests to complete
        return forkJoin(detailObservables);
      })
    ).subscribe({
      next: (detailedProducts) => {
        this.products = detailedProducts;
        this.loading = false;
      },
      error: (err) => {
        this.error = 'Failed to load products';
        this.loading = false;
      }
    });
  }
  
  // Helper method to get comma-separated colour names
  getColourNames(product: Product): string {
    if (!product.colours || product.colours.length === 0) {
      return 'None';
    }
    return product.colours.map(color => color.name).join(', ');
  }
}