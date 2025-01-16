namespace Todo
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addTodo = new Button();
            searchTodo = new Button();
            deleteTodo = new Button();
            updateTodo = new Button();
            Heading = new Label();
            SuspendLayout();
            // 
            // addTodo
            // 
            addTodo.Location = new Point(157, 144);
            addTodo.Name = "addTodo";
            addTodo.Size = new Size(112, 34);
            addTodo.TabIndex = 0;
            addTodo.Text = "Add Todo";
            addTodo.UseVisualStyleBackColor = true;
            addTodo.Click += addTodo_Click;
            // 
            // searchTodo
            // 
            searchTodo.AutoSize = true;
            searchTodo.Location = new Point(518, 143);
            searchTodo.Name = "searchTodo";
            searchTodo.Size = new Size(119, 35);
            searchTodo.TabIndex = 1;
            searchTodo.Text = "Search Todo";
            searchTodo.UseVisualStyleBackColor = true;
            searchTodo.Click += searchTodo_Click;
            // 
            // deleteTodo
            // 
            deleteTodo.AutoSize = true;
            deleteTodo.Location = new Point(152, 227);
            deleteTodo.Name = "deleteTodo";
            deleteTodo.Size = new Size(117, 35);
            deleteTodo.TabIndex = 2;
            deleteTodo.Text = "Delete Todo";
            deleteTodo.UseVisualStyleBackColor = true;
            deleteTodo.Click += deleteTodo_Click;
            // 
            // updateTodo
            // 
            updateTodo.AutoSize = true;
            updateTodo.Location = new Point(512, 227);
            updateTodo.Name = "updateTodo";
            updateTodo.Size = new Size(125, 35);
            updateTodo.TabIndex = 3;
            updateTodo.Text = "Update Todo";
            updateTodo.UseVisualStyleBackColor = true;
            updateTodo.Click += updateTodo_Click;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = SystemColors.Control;
            Heading.Font = new Font("Sitka Heading", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(304, 24);
            Heading.Name = "Heading";
            Heading.Size = new Size(189, 58);
            Heading.TabIndex = 4;
            Heading.Text = "Todo App";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Heading);
            Controls.Add(updateTodo);
            Controls.Add(deleteTodo);
            Controls.Add(searchTodo);
            Controls.Add(addTodo);
            Name = "Home";
            Text = "Todo App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTodo;
        private Button searchTodo;
        private Button deleteTodo;
        private Button updateTodo;
        private Label Heading;
    }
}
