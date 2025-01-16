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
            else
            {
                MessageBox.Show("To-Do added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }

        }
        private void ClearFields()
        {
            userName.Text = string.Empty;
            todoTitle.Text = string.Empty;
            todoDesc.Text = string.Empty;
        }
    }
}
