import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService } from '../services/product.service';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product-create',
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.css'],
  standalone: true,
  imports: [CommonModule, FormsModule]
})
export class ProductCreateComponent implements OnInit {
  name = '';
  productType: number | null = null;
  selectedColours: number[] = [];
  productTypes: any[] = [];
  colours: any[] = [];
  loading = false;
  error = '';
  success = '';

  constructor(private productService: ProductService, private router: Router) {}

  ngOnInit(): void {
    this.productService.getProductTypes().subscribe({
      next: (types) => this.productTypes = types,
      error: () => this.error = 'Failed to load product types'
    });
    this.productService.getColours().subscribe({
      next: (colours) => this.colours = colours,
      error: () => this.error = 'Failed to load colours'
    });
  }

  onSubmit() {
    if (!this.name || !this.productType) {
      this.error = 'Name and Product Type are required.';
      return;
    }
    this.loading = true;
    this.error = '';
    this.success = '';
    this.productService.createProduct({
      name: this.name,
      productType: this.productType,
      colours: this.selectedColours
    }).subscribe({
      next: (res) => {
        this.success = 'Product created successfully!';
        setTimeout(() => this.router.navigate(['/products']), 1000);
      },
      error: (err) => {
        this.error = 'Failed to create product';
        this.loading = false;
      }
    });
  }
}
