# MovieManagement

MovieManagement is a template for creating a hexagonal architecture application in C# for handling various requests, CRUD operations, and backend services while using the repository design pattern with the unit of work at the core. 

Based on the DDD model, we've created onion architecture (aka hexagonal or clean architecture). The idea of the Onion Architecture is based on the inversion of control principle, i.e. placing the domain and services layers at the center of your application, externalizing the infrastructure.

![MovieManagement Repository Cover Page](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/0.png)


# Project Structure & High-Level Overview

A cross-platform C# application. The MovieManagement solution contains a total of 3 projects out of which 2 are types of C# Class Library. The Project 

`[MovieManagement.Domain]` is the core project of this solution containing Bussines Logic Layer: 1. `Entities` & 2. `Repository`. 

`[MovieManagement.DataAccess]` is the outer layer of this solution, it depended on the domain project and contains 1. `Local Database files`, 2. `Database Context`, 3. `EF Core Migrations` & 4. `Concrete  Implementations`.

`[MovieManagement.WebAPI]` is the startup project of this solution containing Application Logic Layer: 1. `Controllers`, 2. `Action Methods`, 3. `Connection Strings` & 4. `Startup Logic`.
 
![Project Structrue](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/5.png)


**Project Prerequisites:**

 - Other:
   - DotNet SDK 7.0 or Above
   - Good Internet Connection

 - IDE:
   - Visual Studio 2022
   - Visual Studio Code
   - JetBrains Rider 2023

 - Packages:
     - Microsoft.AspNetCore.OpenApi  `Version="7.0.2"`
     - Microsoft.EntityFrameworkCore  `Version="7.0.2"`
     - Microsoft.EntityFrameworkCore.Design  `Version="7.0.2"`
     - Microsoft.EntityFrameworkCore.Tools  `Version="7.0.2"`
     - Swashbuckle.AspNetCore  `Version="6.4.0"`
     - Microsoft.EntityFrameworkCore.Sqlite  `Version="7.0.2"`

**Project Steup:**
 - Clone the master branch repo: `git clone https://github.com/AslamNazeerShaikh/MovieManagement.git`
 - Change the current directory to the project directory: `cd .\MovieManagement\`
 - Restore the .NET packages and project dependencies: `dotnet restore`
 - Now change the current directory to startup project directory: `cd .\MovieManagement.WebApi\`
 - To run the project execute the command: `dotnet run`

## Benefits of Hexagonal or Clean Architecture

 - **Plug & play**: We can add or remove adapters based on our development
   like we can replace the Rest adapter with GraphQL or gRPC adapter. The
   rest of the logic will remain the same
 - **Testability**: As it decoupled all layers, it is easy to write a
   test case for each component.
 - **Adaptability**/Enhance: Adding a new way to interact with applications
   is very easy.
 - **Sustainability**: We can keep all third-party libraries in
   Infrastructure layer and hence maintenance will be easy.
 - **Database Independent**: Since the database is separated from data access,
   it is quite easy to switch database providers.
 - **Clean code**: As business logic is away from the presentation layer, it is
   easy to implement UI (like React, Angular, or Blazor).
 - **Well organized**: The project is well organized for better understanding
   and for onboarding new joiners to the project.

## Repository Design Pattern

![What is Repository Pattern](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/2.png)

**Benefits of Repository Pattern**
1.  It centralizes data logic or business logic and service logic.
2.  It gives a substitution point for the unit tests.
3.  Provides a flexible architecture.
4.  If you want to modify the data access logic or business access logic, you don’t need to change the repository logic.

**Benefits of Generic Repository Pattern**
1.  It reduces redundancy of code.
2.  It force programmer to work using the same pattern.
3.  It creates possibility of less error.
4.  If you use this pattern then it is easy to maintain the centralized data access logic. 

![Benefits of Repository Design Pattern](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/1.png)


## Unit of Work Pattern 
The unit of work class serves one purpose: to make sure that when you use multiple repositories, they share a single database context. That way, when a unit of work is complete you can call the SaveChanges method on that instance of the context and be assured that all related changes will be coordinated.

![Diagram of Unit Of Work](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/4.png)

 ## Consequences of the Unit of Work Pattern
-   Increases the level of abstraction and keep business logic free of data access code
-   Increased maintainability, flexibility and testability
-   More classes and interfaces but less duplicated code
-   The business logic is further away from the data because the repository abstracts the infrastructure. This has the effect that it might be harder to optimize certain operations which are performed against the data source.

![Benefits of Unit Of Work](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/3.png)

### Contribute
As a free and open-source project, we are very grateful to everyone who helps us to develop this project.
