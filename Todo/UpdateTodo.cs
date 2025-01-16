using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class UpdateTodo : Form
    {
        public UpdateTodo()
        {
            InitializeComponent();
        }

        private void todoSubmit_Click(object sender, EventArgs e)
        {
            // Get input values
            string username = userName.Text.Trim();
            string title = todoTitle.Text.Trim();
            string description = todoDesc.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update the database (example using Npgsql for PostgreSQL)
                string connectionString = "Host=your_host;Username=your_user;Password=your_password;Database=your_database";

                using (var connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Todos SET Description = @description WHERE Username = @username AND Title = @title";

                    using (var command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@description", description);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Todo updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching Todo found!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
