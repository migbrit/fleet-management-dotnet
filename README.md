Fleet Management System 🚗

Vehicle fleet management API built with .NET, focusing on Clean Architecture, CQRS, event-driven messaging, performance, and security.

🛠 Technologies

Backend: .NET 8, C#, Entity Framework Core

Architecture: Clean Architecture, DDD

Messaging: RabbitMQ / AWS SQS

Cloud & Deployment: AWS (EC2, Lambda, S3, RDS), Docker, Kubernetes

Authentication: JWT, Identity, OAuth2

Front-end: React (minimal, for API consumption)

Monitoring: Sentry, CloudWatch

📌 Key Features

Vehicle CRUD (brand, model, license plate, engine)

Maintenance history and fleet status

Role-based access control (admin, operator, manager)

Image upload to S3

Event-driven notifications (VehicleRented)

Caching for heavy queries

Security based on OAuth2/JWT

⚡ Project Structure

/src – API and microservices source code

/frontend – Minimal React app for testing

/docs – Swagger/OpenAPI, diagrams, architecture notes

/scripts – Deployment scripts, docker-compose, etc.

🚀 Project Roadmap

The project evolves in phases:

.NET fundamentals and basic CRUD

Clean Architecture & Design Patterns

AWS deployment & CI/CD

Docker & Kubernetes

Messaging and event-driven architecture

Databases, performance, and caching

Advanced security

Minimal front-end and full documentation preparation

💡 How to Run Locally
git clone https://github.com/your-username/fleet-management-dotnet.git
cd fleet-management-dotnet
dotnet run --project src/Fleet.Api


Swagger is available at http://localhost:5000/swagger
