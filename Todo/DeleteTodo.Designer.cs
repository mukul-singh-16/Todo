namespace Todo
{
    partial class DeleteTodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Heading = new Label();
            userName = new TextBox();
            todoTitle = new TextBox();
            delete = new Button();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = SystemColors.Control;
            Heading.Font = new Font("Sitka Small", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(176, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(371, 42);
            Heading.TabIndex = 5;
            Heading.Text = "You can delete todo here";
            // 
            // userName
            // 
            userName.Location = new Point(176, 124);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(150, 31);
            userName.TabIndex = 8;
            // 
            // todoTitle
            // 
            todoTitle.Location = new Point(176, 203);
            todoTitle.Name = "todoTitle";
            todoTitle.PlaceholderText = "Title";
            todoTitle.Size = new Size(150, 31);
            todoTitle.TabIndex = 9;
            // 
            // delete
            // 
            delete.Location = new Point(491, 157);
            delete.Name = "delete";
            delete.Size = new Size(112, 34);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // DeleteTodo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(todoTitle);
            Controls.Add(userName);
            Controls.Add(Heading);
            Name = "DeleteTodo";
            Text = "DeleteTodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private TextBox userName;
        private TextBox todoTitle;
        private Button delete;
    }
}