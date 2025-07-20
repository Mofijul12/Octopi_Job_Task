# User Management System - ASP.NET Core MVC

 User Management System built with ASP.NET Core MVC featuring:
- Full CRUD (Create, Read, Update, Delete)
-  Modal forms for create and edit
- Search by name/email dynamically
- Filter by status (Active/Inactive)
- Sort by age (Ascending/Descending)
- Delete confirmation popup

---

## 🚀 Setup Instructions

### 1. Clone the Repository
```bash
git clone https://github.com/Mofijul12/Octopi_Job_Task.git
cd user-management-system
```

### 2. Setup the Database
- Open the solution in Visual Studio
- Configure your `appsettings.json` connection string to your local SQL Server
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=OctopiDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

- Run the following command in the terminal:
```bash
dotnet ef database update
```

### 3. Run the Application
```bash
dotnet run
```
Open in browser: `https://localhost:xxxx/Users/Index`

---

## 🗃️ Database Schema

### Table: Users


| Column | Type | Description |
|--------|------|-------------|
| Id     | int  | Primary Key |
| Name   | nvarchar(100) | User's full name |
| Email  | nvarchar(100) | Unique email |
| Age    | int  | User's age |
| Status | nvarchar(20) | 'Active' or 'Inactive' |
<img width="300" height="200" alt="image" src="https://github.com/user-attachments/assets/d1c0d82b-2068-47ad-acf8-0174f16bbe9d" />

---

## 🔌 API Endpoints

### GET /Users
Returns the full user list.

### POST /Users/Create
Creates a new user.
```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "age": 30,
  "status": "Active"
}
```

### GET /Users/Edit/{id}
Loads the edit modal for a user.

### POST /Users/Edit
Updates an existing user.


### POST /Users/DeleteConfirmed/{id}
Deletes the user.

### GET /Users/Search
Filters the user list dynamically.
**Query Parameters:**
- `searchName`
- `searchEmail`
- `status`
- `sortOrder` ("age_asc" or "age_desc")


---

## 📷 Screenshots
<img width="1914" height="972" alt="image" src="https://github.com/user-attachments/assets/c679a9af-f17b-4c2f-84c4-5a5306fd583d" />


---

---
