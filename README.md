# MovieManagement

MovieManagement is a template for creating a hexagonal architecture application in C# for handling various requests, CRUD operations, and backend services while using the repository design pattern with the unit of work at the core. 

Based on the DDD model, we've created onion architecture (aka hexagonal or clean architecture). The idea of the Onion Architecture is based on the inversion of control principle, i.e. placing the domain and services layers at the center of your application, externalizing the infrastructure.

![MovieManagement Repository Cover Page](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/0.png)


# Project Structure & High-Level Overview

**Project Prerequisites:**

 - Other:
   - DotNet SDK 7.0 or Above
   - Good Internet Connection

 - IDE:
   - Visual Studio 2022
   - Visual Studio Code
   - JetBrains Rider 2022.3

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

![Project Structrue](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/5.png)

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

## Benefits of Repository Design Pattern
![Benefits of Repository Design Pattern](https://github.com/AslamNazeerShaikh/MovieManagement/blob/development/Images%20&%20Documents/1.png)
