# SistemaApp Api

A project proposed by my mentor, in order to challenge my skills and improve my overall knowledge about .Net ecosystem.

## Description

This project was made using the following technologies:

- ASP.NET Core 6
- EF Core 6
- Dapper
- Microsoft SqlServer

## How to install

you gonna need a C# compiler and .Net 6

Download and install VisualStudio [here](https://visualstudio.microsoft.com/pt-br/free-developer-offers/) Or use VisualStudioCode with C# Extension.

Download and install .Net 6 [here](https://dotnet.microsoft.com/en-us/download)

dotnet ef must be installed as a global tool using:

```dotnet
dotnet tool install --global dotnet-ef

dotnet tool update --global dotnet-ef
```

then install

```dotnet
dotnet add package Microsoft.EntityFrameworkCore.Design
```

if you need more information you can check the documentation [here](https://docs.microsoft.com/en-us/ef/core/cli/dotnet).

## How to run the project

Clone the repo:

```git
git clone https://github.com/matheuscubas/SistemaApp.git
```

Open the application and go to the file "appsetings.json" and change the ConnectionString: DefaultConnection to match your Server
change the field Server, and if you use any authentication on you Db replace the "Integrated Security" to "User Id=myUsername;Password=myPassword;"
if you nedd read more about it [here](https://www.connectionstrings.com/sql-server/)

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=[YourServer];Database=SistemaApp;TrustServerCertificate=True;Integrated Security = true;"
}
```

run this at root SistemaApp to to apply migrations and crate the database.

```dotnet
dotnet ef run database update --project SistemaApp.Core -s SistemaApp.Api
```

then run the application, the dabase will be seeded on launch.

## Conclusion

## Author

- :bust_in_silhouette: Matheus Vidal
- Github: [@matheuscubas](https://github.com/matheuscubas)
- Linkedin:  [Matheus Vidal](https://www.linkedin.com/in/matheusvcubas)

## Acknowledgments

I would like to thank my mentor [Guilherme](https://github.com/guilhermerochas/) for his time to elaborate and guide me through this project. I'm grateful for his efforts into training and helping me to achieve my goals as a developer.

## License

[MIT](https://choosealicense.com/licenses/mit/)
