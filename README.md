# TCC Barcode

This is a simple .NET project using a **Code First** approach with Entity Framework Core. The application allows you to **add** and **delete** products.

## Features

- Create database automatically using EF Core Code First.
- Add new products.
- Delete existing products.
- Display product code in **Barcode**.

## Prerequisites

- Visual Studio
- SQL Server

## Get Started

**1. Clone the repository:**

```
git clone https://github.com/ChawankornT/tcc-problem-no6.git
cd tcc-problem-no6
```

**2. Set connection string** in `appsettings.json`:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=<YOUR_SERVER_NAME>;Database=db_TCC;User Id=<YOUR_ID>;Password=<YOUR_PASSWORD>;TrustServerCertificate=True;"
  }
}
```

**3. Create database:**

```
dotnet ef database update
```

**4. Start application**:

```
dotnet run
```

  Or **`F5`** when using visual studio.
