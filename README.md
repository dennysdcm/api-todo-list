# Todo API

A .NET Core Web API application built for managing a simple Todo List.

## API Endpoints

The following are the main endpoints of the Todo API:

* GET /api/todo - Retrieve all Todo items.
* GET /api/todo/{id} - Retrieve a specific Todo item by ID.
* POST /api/todo - Create a new Todo item
* PUT /api/todo/{id} - Update an existing Todo item.
* DELETE /api/todo/{id} - Delete a todo item

## Prerequisites

* .NET 8.0 or later
* Docker

## Running Locally

### 1. Build and Run with Docker Compose

To build and run the application using Docker compose, run the following command:

```sh
docker compose -f docker-compose.yml up --build -d
```

This will start up the application and a SQL Server database instance. The API will be accesible at http://localhost:5000

### 2. Debugging

To run the project in Debug mode:

1. Open the solution in Visual Studio.
2. Set ApiTodoList as the startup project.
3. Run SQL Server with docker compose using docker-compose-debug.yml file
```sh
docker compose -f docker-compose-debug.yml up -d
```
4. Press F5 to Start the application in debug mode.

This will start up the application and open the browser at https://localhost:7280/swagger/index.html

## Dependencies

* .NET 8
* Entity Framework Core
* SQL Server
* Docker
* Docker Compose

## Contact Information

For any question for further assistance, please reach out to:

* Email: email@example.com