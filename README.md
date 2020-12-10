

## Microservices Architecture

## Development Environment

- Visual Studio 2019
- .NET Core 3.1
- SQL Server
- Postman

## Technologies

- C#
- ASP.NET Core
- Ocelot
- Swashbuckle
- Serilog
- JWT
- SQL Server
- HTML
- CSS
- JavaScript

## Architecture

There are three microservices:

- **File microservice**: allows to manage the file of the task.
- **Tasks microservice**: allows to manage the task.
- **Identity microservice**: allows to manage users.

Using the Gateway concept, you can run each micro service at a time or all services at the same time, and call time, just call the gateway and it is configured to route the API.

Gateway is configured on the route: http://localhost:44359

Below an example of a call with Gateway, remembering that when calling the gateway is necessary to perform user authentication

http://localhost:44359/api/FileTask/GetFilesByTask/1
