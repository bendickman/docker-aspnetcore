# .NET 6 Web App, Postgres, Serilog, Elasticsearch, Kibana with Docker Compose

## Development Environment

Minimum requirements to run the application:

- Visual Studio 2022
- .NET 6
- Docker Desktop


## Setup

Clone the repository, open in VS 2022, set the startup project to 'Docker Compose' and run the application. This will start the following containers:

- .NET 6 Web App - `localhost:51567`
- Postgres Database 
- Elasticsearch - `localhost:9200`
- Kibana - `localhost:5601`

## Technologies

- .NET 6 Web App with Razor Pages
-  Postgres SQL Database seeded with test data. This data is stored as a Docker Volume and will be persisted during container start/stop
- Serilog to handle logging
- Elasticsearch to store logging details
- Kibana to provide a user-interface over the Elasticsearch data
