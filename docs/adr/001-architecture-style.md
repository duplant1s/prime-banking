# ADR 001 — Architecture Style

## Context

Prime Banking is an early-stage backend project intended for learning and portfolio purposes.

The project aims to explore:

- Transactions
- Transfers
- Idempotency
- Reliability
- Observability

The domain is still evolving.

---

## Decision

Use:

Modular Monolith + Clean Architecture per module

Structure:

```text
PrimeBanking.Api/

Modules/

    Accounts/
        Application/
        Domain/
        Infrastructure/

    Transfers/
        Application/
        Domain/
        Infrastructure/

Shared/
```

---

## Alternatives Considered

### Global Clean Architecture

```text
Api/
Application/
Domain/
Infrastructure/
```

Pros:

- Familiar
- Simple
- Common in .NET

Cons:

- Feature scattering
- Large folders over time
- Lower cohesion

---

### Microservices

Pros:

- Independent deployment
- Independent scaling

Cons:

- Distributed complexity
- Harder local development
- Network concerns
- Premature for MVP

---

## Rationale

A modular monolith provides:

- clear boundaries
- easier local development
- simpler deployment
- future extraction path

without introducing distributed systems complexity too early.

---

## Trade-offs

Pros:

- High cohesion
- Better module ownership
- Easier evolution

Cons:

- More upfront structure
- Not independently deployable
- Requires discipline

---

## Future Considerations

Possible future topics:

- CQRS evaluation
- Outbox pattern
- Event-driven notifications
- Reliability patterns
