# Prime Banking

Prime Banking is a backend engineering showcase project built with ASP.NET Core.

The goal of this project is not to build a toy banking app, but to explore real backend engineering concepts such as transactions, idempotency, modular architecture, reliability, observability and persistence.

## Current Status

- ASP.NET Core API created
- Swagger configured
- Health check endpoint available
- PostgreSQL running with Docker Compose
- Modular Monolith structure created

## Tech Stack

- ASP.NET Core
- PostgreSQL
- Docker / Docker Compose
- Swagger / OpenAPI

## Architecture

The project starts as a Modular Monolith with Clean Architecture per module.

Initial modules:

- Accounts
- Transfers

Each module can contain:

- Application
- Domain
- Infrastructure

All the architectural decisions have been documented and can be checked in the [Architecture Decision Record](/docs/adr).

## Local Development

Start PostgreSQL:

```bash
docker compose up -d
```

Run the API:

```bash
dotnet run --project src/PrimeBanking.Api
```

Open Swagger:

```bash
https://localhost:7050/
```

## Roadmap

Upcoming work:

- Accounts persistence
- EF Core
- Transactions
- Idempotency
- Notifications
- Reliability patterns
- Observability
