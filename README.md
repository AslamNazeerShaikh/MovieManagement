# MovieManagement

MovieManagement is a template for creating a hexagonal architecture application in C# for handling varoius requests, CRUD operations and backend services while using the repository design pattern with unit of work at the core. 

Based on the DDD model, we've created onion architecture (aka hexagonal or clean architecture). The idea of the Onion Architecture is based on the inversion of control principle, i.e. placing the domain and services layers at the center of your application, externalizing the infrastructure.

## Benefits of Hexagonal or Clean Architecture

 - **Plug & play**: We can add or remove adapter based on our development,
   like we can replace Rest adapter with GraphQL or gRPC adapter. The
   rest of the logic will be remain the same
 - **Testability**: As it decoupled all layers, so it is easy to write a
   test case for each components.
 - **Adaptability**/Enhance: Adding a new way to interact with applications
   is very easy.
 - **Sustainability**: We can keep all third party libraries in
   Infrastructure layer and hence maintainence will be easy.
 - **Database Independent**: Since database is separated from data access,
   it is quite easy to switch database providers.
 - **Clean code**: As business logic is away from presentation layer, it is
   easy to implement UI (like React, Angular or Blazor).
 - **Well organized**: Project is well organized for better understanding
   and for onboarding for new joinee to project.
