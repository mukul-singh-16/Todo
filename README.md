# Todo Application

A simple Todo application built using C# and Windows Forms. This app allows users to create, update, delete, and search their Todo items.

## Features

- **Create Todo**: Add new todo items with titles and descriptions.
- **Update Todo**: Update existing todo items.
- **Delete Todo**: Remove todo items.
- **Search Todo**: Search todo items by username.

## Technologies Used

- C#
- Windows Forms
- PostgreSQL (for storing data)
- Npgsql (to connect to PostgreSQL from C#)

## Setup Instructions

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet) (for Windows Forms applications)
- PostgreSQL (for database storage)
- Visual Studio (for development and running the project)

### Steps to Set Up

1. Clone the repository:
   https://github.com/mukul-singh-16/Todo.git


Install the necessary dependencies:

Open the project in Visual Studio.
Add the Npgsql package to your project:
Install-Package Npgsql

Set up the PostgreSQL database:

Install PostgreSQL if you haven't already.

Create a database and a table to store todo items.

Example SQL to create the table:
sql
CREATE TABLE todos (
    id SERIAL PRIMARY KEY,
    username VARCHAR(100),
    title VARCHAR(100),
    description TEXT
);

Update the connection string in your application to match your PostgreSQL database settings.

Build and run the application in Visual Studio.

Folder Structure
lua
Copy
Edit
/TodoApp
|-- /bin
|-- /obj
|-- /Todo
|   |-- UpdateTodo.cs
|   |-- DeleteTodo.cs
|   |-- SearchTodo.cs
|   |-- Program.cs
|   |-- TodoForm.cs
|-- /Properties
|-- .gitignore
|-- README.md
Known Issues
Ensure that the PostgreSQL server is running and accessible.
Some temporary files may be stored in the .vs folder, which should be ignored by Git.
Contributing
If you'd like to contribute to this project, feel free to fork it, create a new branch, and submit a pull request.
