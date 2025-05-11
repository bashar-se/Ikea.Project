import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService } from '../services/product.service';

interface ColourResponseDto {
  id: number;
  name: string;
}

@Component({
  selector: 'app-colours',
  templateUrl: './colours.component.html',
  styleUrls: ['./colours.component.css'],
  imports: [CommonModule]
})
export class ColoursComponent implements OnInit {
  colours: ColourResponseDto[] = [];
  loading = true;
  error: string | null = null;

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.productService.getColours()
      .subscribe({
        next: (data) => {
          this.colours = data;
          this.loading = false;
        },
        error: (err) => {
          this.error = 'Failed to load colours';
          this.loading = false;
        }
      });
  }
}
