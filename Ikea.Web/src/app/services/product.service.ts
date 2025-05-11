import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private productsUrl = 'https://localhost:49503/api/products';
  private productTypesUrl = 'https://localhost:49503/api/producttypes';
  private coloursUrl = 'https://localhost:49503/api/colours';

  constructor(private http: HttpClient) {}

  getProducts(): Observable<any[]> {
    return this.http.get<any[]>(this.productsUrl);
  }

  getProductById(id: number): Observable<any> {
    return this.http.get<any>(`${this.productsUrl}/${id}`);
  }

  getProductTypes(): Observable<any[]> {
    return this.http.get<any[]>(this.productTypesUrl);
  }

  getColours(): Observable<any[]> {
    return this.http.get<any[]>(this.coloursUrl);
  }

  createProduct(product: { name: string; productType: number; colours: number[] }): Observable<any> {
    return this.http.post<any>(this.productsUrl, product);
  }
}