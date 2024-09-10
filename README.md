.NET API Project
Overview
This project is a .NET Core Web API built with Clean Architecture principles, implementing the CQRS (Command Query Responsibility Segregation) pattern, utilizing MediatR for request/response and notification handling, and AutoMapper for object-to-object mapping.

#Key Technologies

.NET Core - Cross-platform framework for building web APIs.

Clean Architecture - Ensures separation of concerns and high maintainability by organizing code into layers.

CQRS - Segregates write (commands) and read (queries) operations for better scalability and performance.

MediatR - Simplifies communication between different parts of the application through request/response and notification patterns.

AutoMapper - Streamlines the process of mapping objects between different layers, reducing manual mapping code.

#The project follows the Clean Architecture approach and is divided into several layers:

Domain - Contains the core entities, business logic, and domain services.

Application - Implements the CQRS pattern and contains the use cases (commands, queries, handlers). It also integrates with MediatR for request/response handling.

Infrastructure - Contains external services, database access, and configurations.

API - The entry point of the application, defining controllers and configuring services.
CQRS with MediatR

#The project follows the CQRS pattern by segregating the responsibilities of commands (write operations) and queries (read operations). Each command or query is handled by a separate Handler.

Commands: Used for creating, updating, or deleting data.

Queries: Used for fetching data.

MediatR: Mediates between controllers and the handlers to simplify the communication.
