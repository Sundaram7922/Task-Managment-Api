## 📝 Task Management API

A simple .NET Core Web API for managing tasks, users, and comments with JWT-based authentication and role-based authorization.

### 📌 Features

- Create and retrieve tasks
- Assign tasks to users
- Role-based access control (`Admin`, `User`)
- JWT authentication
- In-memory database (EF Core)
- Swagger UI for testing

---

### 🚀 Getting Started

#### 🔧 Prerequisites

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)

#### 📅 Clone the Repository

```bash
git clone https://github.com/your-username/Task-management-api.git
cd Task-management-api
```

#### ⚙️ Run the API

```bash
dotnet run
```

API will be available at: `https://localhost:5001` or `http://localhost:5000`

---

### 🔐 Authentication (JWT)

1. Go to `POST /auth/login` in Swagger.
2. Use one of the seeded users:
   - Username: `admin`, Role: `Admin`
   - Username: `john`, Role: `User`
   - (No password required for demo)
3. Copy the token from the response.
4. Click **Authorize** button in Swagger and paste the token as:  
   ```
   Bearer <your-token-here>
   ```

---

### 🔀 Endpoints

#### 📜 Auth
- `POST /auth/login` → Get JWT token

#### 📌 Tasks
- `POST /tasks` → Create task (Authorized)
- `GET /tasks/{id}` → Get task by ID (Authorized)
- `GET /tasks/user/{userId}` → Get tasks for user (Authorized)

---

### 💪 Sample Seed Data

| User ID | Username | Role  |
|---------|----------|-------|
| 1       | admin    | Admin |
| 2       | john     | User  |

| Task ID | Title  | Assigned User ID |
|---------|--------|------------------|
| 1       | Task 1 | 2                |

---

### 🛠️ Tech Stack

- ASP.NET Core
- Entity Framework Core (InMemory)
- JWT Authentication
- Swagger (Swashbuckle)

---

### 📄 Database Design (ER Overview)

- `Users` (Id, Username, Role)
- `Tasks` (Id, Title, Description, Status, AssignedUserId)
- `TaskComments` (Id, TaskId, UserId, CommentText, CreatedAt)

---

### 🧠 Sample SQL Queries

> (Only relevant if using SQL Server)

```sql
-- Tasks assigned to a user
SELECT * FROM Tasks WHERE AssignedUserId = 2;

-- Comments on a task
SELECT * FROM TaskComments WHERE TaskId = 1;
```

---

### Sundaram - +919810964508
