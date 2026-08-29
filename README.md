# Ticket May --- Backend

Ticket Management system for my portfolio.

This README serves as both documentation for my project and subsequent projects

ASP.NET Core Web API with layered architecture, EF Core, MSSQL container

This is the back-end repository.

## Stack
 
| Concern | Choice | Reason |
|---|---|---|
| Runtime | .NET 8 | I like C#, version 8 for compatibility
| Framework | ASP.NET Core Web API | I want to use a Web API over MVC or Blazor for decoupled architecture
| ORM | Entity Framework Core **8.0.15** (pinned — see Notes) | Deeply engrained in the ecosystem. Alternatives aren't worth the search. Need it for migrations and LINQ
| Database | MSSQL 2022 Container | Microsoft ecosystem
| API docs | Swagger / Swashbuckle | Test API without any frontend planned
| Dev OS | Fedora | See Notes
| Conternerization | Docker | Run MSSQL without installing it, plus eventual orchestration


# Notes

EF Core must be version 8 just like our runtime .NET 8.

Why Fedora: Ubuntu's AppArmor policy conflicted with Docker and I couldn't kill containers.

# Lexicon

**ARCHITECTURE**

**Decoupled Architecture:** Separation of concerns between frontend and backend. Two different repos interracting over HTTP

**Layered Architecture:** Separation of concerns inside backend. 