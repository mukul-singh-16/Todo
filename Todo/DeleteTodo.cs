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
    public partial class DeleteTodo : Form
    {
        public DeleteTodo()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Retrieve data from text boxes
            string username = userName.Text;
            string title = todoTitle.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Both Username and Title are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DB string
            string connectionString = "Host=localhost;Port=5432;Database=TodoApp;Username=postgres;Password=yourpassword";

            try
            {
                // Delete data from the database
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM todos WHERE username = @username AND title = @title";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("title", title);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("To-Do deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No matching To-Do found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }
    }
}
