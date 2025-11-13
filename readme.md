# 📘 LibraryAppV2

> API para gerenciamento de livros, empréstimos e comentários — evoluída a partir do projeto **LibraryApp (Console)**.  
> Desenvolvida em **ASP.NET Core**, baseada em **Clean Architecture** e **CQRS**, com inspiração no projeto *DevFreela*.

---

## 🚀 Visão Geral

O **LibraryAppV2** é uma API REST voltada para o controle e empréstimo de livros.  
Ela permite que usuários cadastrem obras, realizem empréstimos, adicionem comentários e (em breve) gerem **resenhas automáticas com IA (OpenAI API)**.

---

## 🧩 Funcionalidades Principais

- 📚 Gerenciamento de livros (CRUD completo)  
- 👤 Cadastro e autenticação de usuários (JWT)  
- 🔄 Controle de empréstimos (`Loans`)  
- 💬 Comentários em livros (`BookComment`)  
- 🤖 Geração futura de resenhas automáticas via OpenAI  
- 🔐 Validação de permissões e autenticação  
- 📄 Documentação via **Swagger / OpenAPI**

---

## ⚙️ Tecnologias Utilizadas

| Categoria | Ferramenta |
|------------|-------------|
| Linguagem | C# (.NET 9) |
| Framework | ASP.NET Core Web API |
| Banco de Dados | SQL Server (EF Core) |
| Autenticação | JWT Bearer |
| Mapeamento | AutoMapper |
| Padrão de Arquitetura | Clean Architecture + CQRS |
| Comunicação | MediatR |
| Documentação | Swagger / Swashbuckle |
| Testes (futuro) | xUnit / Moq |
| IA (futuro) | OpenAI API |

---

## 🧱 Estrutura do Projeto
LibraryAppV2
│
├── src/
│ ├── LibraryApp.API/ # Camada de apresentação (Controllers, Configs)
│ ├── LibraryApp.Application/ # Casos de uso (Commands, Queries, DTOs)
│ ├── LibraryApp.Domain/ # Entidades e regras de negócio
│ └── LibraryApp.Infrastructure/ # Acesso a dados, serviços externos
│
├── tests/ # Testes unitários e de integração
│
└── docs/ # Documentação técnica (diagramas, endpoints, etc.)

---

## 🧠 Arquitetura (Clean Architecture)

A aplicação é dividida em camadas com **responsabilidades isoladas**:

Presentation (API) ─▶ Application ─▶ Domain ◀── Infrastructure


| Camada | Responsabilidade |
|---------|------------------|
| **API** | Endpoints, DTOs e autenticação |
| **Application** | Orquestração via Commands/Queries (MediatR) |
| **Domain** | Entidades e regras de negócio puras |
| **Infrastructure** | Implementação de repositórios e integrações externas |

---

## 🧩 Entidades Principais

| Entidade | Descrição |
|-----------|------------|
| **Book** | Representa um livro no sistema |
| **User** | Representa um usuário ou leitor |
| **Loan** | Registra o empréstimo de um livro |
| **BookComment** | Comentário ou resenha (manual ou via IA) |

### Enum de Status do Livro
```csharp
public enum BookStatusEnum
{
    Available = 0,
    Borrowed = 1,
    Reserved = 2,
    Lost = 3
}

Fluxos Principais
🔹 Empréstimo de Livro

Usuário solicita o empréstimo (POST /api/loans)

Sistema verifica se o livro está disponível (BookStatusEnum.Available)

Cria o registro de empréstimo (Loan)

Atualiza o status do livro para Borrowed

Retorna os detalhes do empréstimo

🔹 Comentários e Resenhas

Usuários podem comentar em qualquer livro existente

Comentários gerados por IA são marcados como IsAiGenerated = true

Futuramente, será possível gerar automaticamente uma resenha via OpenAI API

📄 Documentação da API

A documentação interativa estará disponível em:

https://localhost:5001/swagger

🧾 Como Executar o Projeto
1. Clonar o repositório
git clone https://github.com/devjoaopedrom/LibraryAppV2.git
cd LibraryAppV2

2. Configurar variáveis de ambiente (User Secrets)
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=.;Database=LibraryAppV2;Trusted_Connection=True;"
dotnet user-secrets set "Jwt:Issuer" "LibraryAppV2"
dotnet user-secrets set "Jwt:Key" "chave-super-secreta"

3. Executar migrações
dotnet ef database update --project src/LibraryApp.Infrastructure

4. Rodar a API
dotnet run --project src/LibraryApp.API

🧭 Estrutura de Casos de Uso (CQRS)
Application/
 ├── Books/
 │    ├── Commands/
 │    │    └── CreateBookCommand.cs
 │    └── Queries/
 │         └── GetBooksQuery.cs
 │
 ├── Loans/
 │    ├── Commands/
 │    └── Queries/
 │
 └── Comments/
      ├── Commands/
      └── Queries/


Cada comando ou consulta retorna ou consome DTOs, que definem o formato dos dados trafegados entre camadas.

🧩 Padrões Adotados

Repository Pattern

CQRS (Command Query Responsibility Segregation)

DTOs para entrada e saída de dados

Handlers desacoplados via MediatR

AutoMapper para conversão entre entidades e DTOs

Soft delete e controle de status com BookStatusEnum

🧠 Próximos Passos

 Implementar integração com OpenAI API para geração automática de resenhas

 Adicionar testes unitários e de integração

 Adicionar controle de reservas de livros

 Criar dashboard administrativo (futuro front-end)

 💬 Contribuição

Pull requests são bem-vindos!
Para contribuir:

Crie uma branch:

git checkout -b feature/nome-da-feature


Faça suas alterações

Envie um pull request explicando sua modificação

📜 Licença

Este projeto é licenciado sob a MIT License.
Desenvolvido por João Pedro 🚀.