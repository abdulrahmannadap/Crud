# Crud API

A clean, modular Web API built using **.NET Core 8**, following best practices such as:

- ✅ Clean Architecture Principles  
- ✅ Entity Framework Core  
- ✅ Repository & Unit of Work Pattern  
- ✅ AutoMapper for DTO Mapping  
- ✅ Strong Separation of Concerns

---

## 🚀 Tech Stack

- [.NET Core 8](https://dotnet.microsoft.com/en-us/download)
- Web API
- Entity Framework Core
- AutoMapper
- SQL Server

---

## 📁 Project Structure

Solution 'Crud' (1 of 1 project)
│
├── Queries
│   └── SqlQuery.txt                   ✅ Raw SQL queries for diagnostics, Dapper, or scripting
│
└── Crud
    ├── Connected Services             ✅ Service references (e.g., gRPC, WCF, REST clients)
    ├── Dependencies                   ✅ NuGet package references
    ├── Properties                     ✅ Assembly info and project settings
    │
    ├── Controllers
    │   └── EmployeesController.cs     ✅ Handles HTTP endpoints and calls services/repositories
    │
    ├── Core
    │   ├── ApplicationDbContext.cs    ✅ EF Core DbContext — configures models and DB sets
    │   ├── IRepository.cs             ✅ Generic repository interface for reusable data access
    │   └── IEmployeeRepo.cs           ✅ Specific repository interface for Employee logic (optional but recommended)
    │
    ├── Dtos
    │   └── EmployeeCreateDto.cs       ✅ DTO for incoming data (used for Create endpoint and mapping)
    │
    ├── Entities
    │   ├── BaseEntity.cs              ✅ Common base class with audit fields (CreatedBy, DeletedBy, etc.)
    │   └── Employee.cs                ✅ Main domain/entity model mapped to the database
    │
    ├── Mappings
    │   └── MappingProfile.cs          ✅ AutoMapper profile for mapping between DTOs and Entities
    │
    ├── Repositories
    │   ├── Repository.cs              ✅ Generic repository implementation (IRepository)
    │   └── EmployeeRepo.cs            ✅ Concrete implementation for Employee repository
    │
    ├── Services
    │   ├── IUnitOfWork.cs             ✅ Unit of Work interface to group multiple repositories
    │   └── UnitOfWork.cs              ✅ Unit of Work implementation (commit/rollback logic)
    │
    ├── appsettings.json               ✅ Application settings (DB connection string, JWT, etc.)
    ├── Crud.http                      ✅ HTTP client test file (for API testing inside IDE)
    └── Program.cs                     ✅ Main entry point — middleware setup and dependency injection



## 🔧 Getting Started

### Prerequisites

- [.NET SDK 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server (LocalDB or Full)

### Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/Crud.git
   cd Crud
