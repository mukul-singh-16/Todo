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
    public partial class SearchTodo : Form
    {
        public SearchTodo()
        {
            InitializeComponent();
        }

        private void SearchTodo_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void search_Click_1(object sender, EventArgs e)
        {
            // Get the entered username
            string username = userName.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Query the database (example using Npgsql for PostgreSQL)
                string connectionString = "Host=your_host;Username=your_user;Password=your_password;Database=your_database";

                using (var connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Title, Description FROM Todos WHERE Username = @username";

                    using (var command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (var reader = command.ExecuteReader())
                        {
                            // Clear the ListBox before adding new items
                            showTodos.Items.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string title = reader.GetString(0);
                                    string description = reader.GetString(1);
                                    showTodos.Items.Add($"Title: {title} | Desc: {description}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No todos found for the given username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
