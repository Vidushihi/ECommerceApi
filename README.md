# ECommerceApi
# Creating Project in Visual Studio:

1. Create a new Project Select WebApi template. Choose .NET version to 8

2. EF Core Db first approach:
 
# Install Below Nuget Packages to Project in order to use Entity framework:

	1. Install-Package Microsoft.EntityFrameworkCore.Tools

	2. Install-Package Microsoft.EntityFrameworkCore.SqlServer

	3. NuGet\Install-Package Microsoft.VisualStudio.Web.CodeGeneration

# Run below command in Package Manager Console to generate DbContext and Model classes for tables:

Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB; Database=ECommerceDb; Trusted_Connection=True;trustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -Context "ECommerceDbContext" -OutputDir "Models" -ContextDir "Dal" -DataAnnotations -force
 
# MSSQLLocalDB Connection String :

Add the below connection string to appsetting.development.json:

"ConnectionStrings": {

    "ECommerceDb": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ECommerceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

  }

# Add below code to program.cs for DI of dbContext to use connection string dynamically from appsettings

builder.Services.AddDbContext<ECommerceDbContext>(option =>

{

    option.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDb"));

});
# Add below code to dependency injection(DI) of Repository Activation to inject a repository to controller
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
 