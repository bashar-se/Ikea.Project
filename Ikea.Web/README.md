# IKEA.Web Application Documentation

## Overview

IKEA.Web is a modern Angular application that serves as the frontend for an IKEA product catalog system. The application allows users to view, create, and manage IKEA-style furniture products with their associated types and colors.

## Project Structure

### Frontend (IKEA.Web)
- **Angular 19.x** application with the following components:
  - **ProductListComponent**: Displays products in a table view
  - **ProductCreateComponent**: Form for creating new products
  - **ProductTypeListComponent**: Lists available product categories
  - **ColoursComponent**: Lists available colors
- **Services**:
  - **ProductService**: Handles API calls related to products

### Backend (IKEA API)
- **.NET 9.0** API built with Clean Architecture:
  - **Domain**: Core entities (Product, ProductType, Colour)
  - **Application**: Business logic and services
  - **Infrastructure**: Data access and persistence
  - **API**: Controllers and endpoints

## Technologies Used

### Frontend
- **Angular 19.2.0** - Modern web framework
- **Bootstrap 5.3.6** - UI component library
- **Font Awesome 6.7.2** - Icon library
- **RxJS 7.8.0** - Reactive programming library
- **TypeScript 5.7.2** - Typed JavaScript

### Backend
- **.NET 9.0** - Modern, cross-platform development framework
- **Entity Framework Core 9.0.4** - ORM for data access
- **SQL Server** - Database
- **AutoMapper** - Object-to-object mapping
- **FluentValidation** - Input validation

## Features

1. **Products List** - View all products with details in a table:
   - Product ID
   - Product Name
   - Product Type
   - Colors (comma-separated)

2. **Create Product** - Add new products to the catalog:
   - Set product name
   - Select product type
   - Select multiple colors

## API Endpoints

The application consumes the following endpoints:

- `GET /products` - Get all products (basic info)
- `GET /products/{id}` - Get detailed product information
- `POST /products` - Create a new product
- `GET /product-types` - Get all product types
- `GET /colours` - Get all available colors

## How to Build and Run

### Prerequisites
1. [Node.js](https://nodejs.org/) (LTS version)
2. [Angular CLI](https://angular.io/cli) (`npm install -g @angular/cli`)
3. [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
4. SQL Server

### Frontend Setup (IKEA.Web)
```bash
# Navigate to the frontend directory
cd Ikea.Web

# Install dependencies
npm install

# Run the development server
npm start