# TheBurgerBackendProject2

## Indledende opsætning
* Anvender en skabelon fra Visual Studio Community 2026 Insiders, Angular and ASP.NET Core (er dette hvad der kaldes Boilerplate?)
* Database skal være gennem Supabase (nyt kriterie, så vidt jeg kan læse mig til: er ikke kompatibel med ASP.NET Core Identity (derfor "Project2"))
* Anvender NuGet-package "Supabase" v1.1.1 på backend delen, som er klienten.

## Logbog/ToDo
* 26-03-2026
  * Finde ud af hvordan man forbinder til Supabase.
  * Undersøg hvordan man holder det sikkert i et Public repository.
  * Finde ud af hvad jeg gør i stedet for Identity (Supabase har noget indbyget hvis jeg har forstået dem korrekt).
  * Lave det arbejde som jeg har lavet en gang før allerede.

## Database struktur foreløbig (husk: anvend andre navne)
~~~mermaid
erDiagram
  BurgerSpots {
    Id INT PK "IDENTITY(1, 1)"
    SpotName NVARCHAR(200) "NOTNULL"
    SpotAddress NVARCHAR(200) "NOTNULL"
    CoordinateLat DECIMAL(18_14) "NOTNULL"
    CoordinateLon DECIMAL(18_14) "NOTNULL"
    OpenTimes NVARCHAR(500) "NULL"
	SpotScore FLOAT "NULL"
    LastEditAt DATETIME2 "NOTNULL"
    LastEditBy NVARCHAR(450) FK "FOREIGNKEY(IdentityUser, Id) NULL"
  }
  UserReview {
    Id INT PK "IDENTITY(1, 1)"
    SpotId INT FK "FOREIGNKEY(BurgerSpots, Id) NOTNULL"
    UserId NVARCHAR(450) FK "FOREIGNKEY(IdentityUser, Id) NULL"
    CreatedAt DATETIME2 "NOTNULL"
    LastEditAt DATETIME2 "NOTNULL"
    Score FLOAT "NULL"
    ReviewText NVARCHAR(2000) "NULL"
    PictureName NVARCHAR(500) "NULL"
  }
  BurgerSpots ||--o{ UserReview : review_of
  IdentityUser {
    Id NVARCHAR(450) PK
  }
  BurgerSpots }o--o| IdentityUser : last_edit_by
  UserReview }o--o| IdentityUser : owned
~~~

Note: SQL FLOAT = SQL FLOAT(53) = EF double