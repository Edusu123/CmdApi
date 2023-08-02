# CmdApi
Repository created to study different concepts envolving a web API developed with .NET 7.

The ideia was to build the same API built in [this tutorial](https://dotnetplaybook.com/develop-a-rest-api-with-net-core/), but using the most recent version of .NET.

Below there are a few annotations that I think are importante to understand the project.

----

* The installation of the dotnet cli is pretty standard (installing the essential components of VS 2022 is enough and you can do it [here](https://visualstudio.microsoft.com/pt-br/downloads/));
* You can create a standard web project with `dotnet new web -n ProjectName` and magically create the .gitignore file through `dotnet create gitignore`;
* The installation of the SQL Server database is pretty standard also. It can be done through the installation of SSMS available [here](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16);
  * This process also installs Azure Data Studio (that I personally prefer);
  * The creation of the local server can be made through `sqllocaldb create "Database Name"` and the database is created by executing the first migration;
* Before anything else, it's important to execute `dotnet tool install --global dotnet-ef` to install the EF tools ([SO reference](https://stackoverflow.com/questions/57066856/command-dotnet-ef-not-found));

:runner: this is an ongoing project :grinning:.
