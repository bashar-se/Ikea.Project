# Ikea.Project

This repository contains a full-stack application for managing an IKEA-style product catalog.

## Project Components

The project consists of two main components:

### 1. Backend API (.NET)

The backend is built using .NET 9.0 with Clean Architecture principles. It provides RESTful API endpoints for managing products, product types, and colors.

**Key Features:**
- SQL Server database with Entity Framework Core
- Clean Architecture (Domain, Application, Infrastructure, API layers)
- Swagger/OpenAPI documentation
- Complete CRUD operations for catalog management

For detailed documentation, setup instructions, and API reference, see:
[Ikea Backend Documentation](Ikea/README.md)

### 2. Frontend Application (Angular)

The frontend is built with Angular 19 and provides a user-friendly interface for interacting with the product catalog.

**Key Features:**
- Product listing and creation
- Modern UI with Bootstrap and Font Awesome
- Responsive design
- Complete integration with backend API

For detailed documentation, features, and setup instructions, see:
[Ikea.Web Frontend Documentation](Ikea.Web/README.md)

## Getting Started

Each component has its own README with specific setup instructions:

1. Set up and run the backend API first by following the [Backend Setup Instructions](Ikea/README.md#setup-instructions)
2. Then set up and run the frontend application by following the [Frontend Setup Instructions](Ikea.Web/README.md#how-to-build-and-run)

## Project Structure

```
Ikea.Project/
├── Ikea/              # Backend (.NET API)
└── Ikea.Web/          # Frontend (Angular)
```