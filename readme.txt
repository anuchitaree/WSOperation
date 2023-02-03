


dotnet add package Microsoft.EntityFrameworkCore --version 6.0.6
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.6
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.6
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.6
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0.6


dotnet ef migrations add InitialCreate1 --context WSOperation.Models.DBContext 
dotnet ef database update