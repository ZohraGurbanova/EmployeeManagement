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


### 2. Database qurulması
appsettings.json faylında SQL Server üçün uyğun bağlantı cədvəlini təyin edin:
Verilənlər bazasını yaradıb, ilkin miqrasiya tətbiq edin:

### 3.API Testi
API-nin test edilməsi üçün Swagger UI istifadə edilə bilər. Brauzerə http://localhost:7000/swagger ünvanını daxil edərək API-nin endpoint-larını test edə bilərsiniz.



