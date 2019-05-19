# Dotnet SQL Server Example
ASP.NET Core API Server that uses SQL SERVER in the backend

### Requirements
-----------------
+ Using Docker & Docker Compose
+ NET CORE SDK 2.1 or 2.2
+ ASPNET RUNTIME 2.1 or 2.2
+ SQL SERVER

## Notes
---------
dotnet-sqlserver-example.sln using for Visual Studio
using src.sln for docker compose

ConnectionString in appsettings.json
+ Sql Server: still run in docker
+ Using docker-compose: `Server=db`
+ The app runs in Visual Studio then `Server=localhost`


### Issues
-----------
+ How to migrate database in docker compose. We need to start database and migrate database first and then start web app.

My bad solution:
+ Run `docker-compose up db`
+ dotnet ef migrations add InitialCreate
+ Run `docker-compose up web`


### Usage
----------

#### Migration database
```
cd src/dotnet-sqlserver-example
dotnet ef migrations add InitialCreate
```

#### Using Docker-Compose
```
cd devops
docker-compose up
```

#### Start project in Visual Studio
Open dotnet-sqlserver-example.csproj
Run sql server in docker and run code in visual studio