using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Todo
{
    public partial class AddTodo : Form
    {
        public AddTodo()
        {
            InitializeComponent();
        }

        private void todoSubmit_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string title = todoTitle.Text;
            string description = todoDesc.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Host=localhost;Port=5432;Database=Tododb;Username=postgres;Password=1234";

            try
            {
                // Insert data into the database
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO todos (username, title, description) VALUES (@username, @title, @description)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("title", title);
                        command.Parameters.AddWithValue("description", description);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("To-Do added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add To-Do.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            userName.Text = string.Empty;
            todoTitle.Text = string.Empty;
            todoDesc.Text = string.Empty;
        }

        private void AddTodo_Load(object sender, EventArgs e)
        {

        }
    }
}
