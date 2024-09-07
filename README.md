# Employee Management API

## Layihənin Təsviri

Employee Management API işçilərin idarə edilməsi üçün nəzərdə tutulmuş bir backend API-dir. Bu API aşağıdakı funksionallıqlara malikdir:
- İşçilərin siyahısının əldə edilməsi
- İşçilərin filter edilməsi və səhifələnməsi
- İşçi məlumatlarına detallı baxış
- Yeni işçinin əlavə edilməsi
- İşçinin silinməsi
- İşçi məlumatlarının redaktə edilməsi

## Tələblər

- .NET 6.0 SDK
- SQL Server

## Quraşdırma və İcra

Aşağıdakı addımları izləyərək layihəni quraşdıra və işə sala bilərsiniz:

### 1. Layihəni Klonlama

```bash
git clone https://github.com/ZohraGurbanova/EmployeeManagement.git
cd repository

### Database qurulması
ConnectionStrings-də defaulConnection- yaradacağınız baza uyğun olaraq dəyişdirin.
EmployeeManagementDb adında baza yaradılmalıdı.
bu bazada aşağdakı query-lər işlədilərək table-lar qurulur.

---
CREATE TABLE [dbo].[Departments] (
    [Id]         INT           NOT NULL IDENTITY,
    [Name]       VARCHAR (50) NULL,
    [CreateDate] DATETIME      NULL, 
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);

----
CREATE TABLE [dbo].[Employees] (
    [Id]           INT           NOT NULL IDENTITY,
    [Name]         VARCHAR (50) NULL,
    [Surname]      VARCHAR (50) NULL,
    [BirthDate]    DATETIME      NULL,
    [CreateDate]   DATETIME      NULL,
    [DepartmentId] INT           NULL, 
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id])
);
