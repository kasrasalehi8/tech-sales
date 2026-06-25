# TechSales

TechSales is a desktop sales and inventory management application built with WinForms and .NET 8.

The application allows businesses to manage products, customers, invoices, payments, and inventory transactions through a modern desktop interface backed by SQL Server.

The application follows a layered architecture:

- **TechSales.WinForms** – User interface and presentation layer
- **TechSales.Application** – Business logic and application services
- **TechSales.Infrastructure** – Entity Framework Core, persistence, and database access
- **TechSales.Domain** – Shared domain models and enums

---

# Setup Instructions

## 1. Clone the repository

```bash
git clone <repository-url>
cd TechSales
```

---

## 2. Restore the database

Open SQL Server Management Studio and restore the provided database backup file:

```text
TechSalesDb.bak
```

Restore it as:

```text
TechSalesDb
```

---

## 3. Configure the database connection

Create an `appsettings.json` file inside the WinForms project directory:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=TechSalesDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

If your SQL Server instance differs, modify the connection string accordingly.

### Examples

#### Local SQL Server instance

```text
Server=.;Database=TechSalesDb;Trusted_Connection=True;TrustServerCertificate=True;
```

#### Named instance

```text
Server=.\\SQLEXPRESS;Database=TechSalesDb;Trusted_Connection=True;TrustServerCertificate=True;
```

#### SQL Authentication

```text
Server=localhost;Database=TechSalesDb;User Id=sa;Password=YourPassword;TrustServerCertificate=True;
```

---

## 4. Restore NuGet packages

Open the solution in Visual Studio.

Visual Studio should automatically restore packages.

If necessary, run:

```bash
dotnet restore
```

---

## 5. Build and run

Press:

```text
F5
```

or run:

```bash
dotnet build
dotnet run
```

Developed as a portfolio project demonstrating desktop application development with WinForms, Entity Framework Core, and SQL Server.