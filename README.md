# Valuta

Valuta is a modern, real-time chat application designed for seamless communication between individuals and groups. It features a high-performance functional backend and a responsive, interactive frontend.

## 🚀 Features

- **Real-time Messaging:** Low-latency chat using WebSockets.
- **Direct & Group Chats:** Support for private 1-on-1 conversations and collaborative group rooms.
- **Functional Core:** Backend built with F# for robustness and type safety.
- **Modern UI:** Responsive web interface built with Next.js, Tailwind CSS, and Shadcn UI.
- **Docker Ready:** Fully containerized setup for easy development and deployment.

## 🛠 Tech Stack

- **Frontend:** [Next.js 15](https://nextjs.org/) (App Router), TypeScript, Tailwind CSS, Shadcn UI.
- **Backend:** [F# .NET 10](https://dotnet.microsoft.com/en-us/languages/fsharp), ASP.NET Core.
- **Orchestration:** Docker Compose.

## 🏃 Getting Started

### Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (for local backend dev)
- [Node.js 22+](https://nodejs.org/) & [pnpm](https://pnpm.io/) (for local frontend dev)

### Quick Start (Docker)

The fastest way to get the entire system running is using Docker Compose:

```bash
docker compose up -d
```

- **Web App:** [http://localhost:3000](http://localhost:3000)
- **API:** [http://localhost:5235](http://localhost:5235)

### Local Development

#### Backend (Valuta.Api)
```bash
cd Valuta.Api
dotnet run
```

#### Frontend (valuta-web)
```bash
cd valuta-web
pnpm install
pnpm dev
```

## 📂 Project Structure

- `Valuta.Api/`: F# backend service handling business logic and real-time communication.
- `valuta-web/`: Next.js frontend application.
- `compose.yaml`: Docker orchestration for the entire stack.
- `Valuta.sln`: Visual Studio solution file integrating all components.

## 📄 License

This project is licensed under the MIT License.
