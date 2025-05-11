# Ikea Application

A .NET Core web application for managing Ikea-like product catalog with entities for products, product types, and colors.

## Project Structure

This project follows the Clean Architecture pattern with the following components:

- **Ikea.Domain**: Core business entities and rules
- **Ikea.Application**: Application business logic and use cases
- **Ikea.Infrastructure**: External dependencies like databases
- **Ikea.API**: API controllers and entry point

## Tech Stack

- **.NET 9.0** - Modern, cross-platform development framework
- **Entity Framework Core 9.0.4** - ORM for data access
- **SQL Server** - Database
- **Swagger/OpenAPI** - API documentation

## Prerequisites

Before running this application, ensure you have:

1. [.NET 9.0 SDK](https://dotnet.microsoft.com/download) installed
2. SQL Server installed and running
3. Visual Studio 2022, VS Code, or Rider (optional)

## Setup Instructions

### Database Configuration

The application is configured to use SQL Server with the following default connection string:
Server=localhost;Database=IkeaDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true


If you need to modify the connection string, edit it in:
- `src/Ikea.API/appsettings.json`

### Running the Application

1. **Clone the repository and change directory**
git clone <repository-url> 
cd Ikea

2. **Build the solution**
dotnet build

3. **Run the migrations**
cd src/Ikea.API dotnet ef database update

Alternatively, migrations will automatically be applied when running in Development mode.

4. **Run the application**
dotnet run --project src/Ikea.API


5. **Access the application**
- API: https://localhost:49503
- Swagger UI: https://localhost:49503/swagger (in Development mode)

## Database Schema

The database contains the following tables:

1. **Products**
- Id (Primary Key)
- Name
- ProductTypeId (Foreign Key)
- CreatedAt

2. **ProductTypes**
- Id (Primary Key)
- Name

3. **Colours**
- Id (Primary Key)
- Name

4. **ProductColours** (Junction table)
- ProductId (Primary Key, Foreign Key)
- ColourId (Primary Key, Foreign Key)

### Seed Data

The application comes pre-configured with seed data:
- 35 product types (Chair, Table, Bed, Sofa, etc.)
- 30 colors (Black, White, Brown, Blue, etc.)

## Development

### Environment Configuration

The application uses standard ASP.NET Core environment variables:
- `ASPNETCORE_ENVIRONMENT`: Set to "Development" for development features

### Adding Migrations
cd src/Ikea.Infrastructure dotnet ef migrations add <MigrationName> --startup-project ../Ikea.API


### Updating Database
cd src/Ikea.API dotnet ef database update


## Entity Relationships

- Each **Product** belongs to one **ProductType**
- Each **Product** can have multiple **Colours** (through the **ProductColours** junction table)
- Each **Colour** can be associated with multiple **Products** (through the **ProductColours** junction table)

## API Endpoints

The API provides standard operations for products, product types, and colors. Access the Swagger UI documentation when running in Development mode for a complete list of endpoints and their parameters.
