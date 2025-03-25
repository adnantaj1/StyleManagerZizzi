# 👕 Style Manager Application

A full-stack .NET 8 + Blazor Server application that allows managing **product styles**, combining colors and sizes into unique style entries.

---

## 🚀 Tech Stack

- **Backend:** ASP.NET Core Web API (.NET 8)
- **Frontend:** Blazor Server (C#)
- **Database:** SQL Server with Entity Framework Core
- **Other Tools:** Swagger (API testing), HttpClientFactory, Data Annotations (Validation)

---

## 🧠 Features

- Add new **Colors** with name and number
- Add new **Sizes** with name and number
- Create a **Style** by selecting:
  - Style Number
  - A Color
  - A Size
- View all created styles in a table
- 🚫 Prevent duplicate styles with same color + size + number
- ✅ Validations on backend & frontend

---

## 💡 Why This Architecture?

- **DTOs** keep data clean and prevent circular references
- **EF Core relationships** for navigation (Style → Color/Size)
- **Data integrity enforced**:
  - Application-level: check before saving
  - DB-level: unique constraint in migration
- **HttpClient per service** in Blazor for cleaner code
- **Separation of Concerns** between API and UI

---

## 🛠️ How to Run

### 1. Run Backend (API)

```bash
cd StyleManagerApiZizzi
dotnet run

Swagger UI will be available at https://localhost:7041/swagger

2. Run Frontend (Blazor Server)
cd StyleManagerUIZizzi
dotnet run

Or use Visual Studio to run both projects simultaneously

App will be available at https://localhost:7178

🔐 Database Setup
Local SQL Server used

Connection string in appsettings.json

EF Core Migrations included:

dotnet ef database update

📌 Known Constraints
StyleNumber + ColorId + SizeId must be unique

No authentication — all APIs are open

No delete/edit features (could be added easily)