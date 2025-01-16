namespace Todo
{
    partial class UpdateTodo
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
            todoSubmit = new Button();
            todoDesc = new TextBox();
            todoTitle = new TextBox();
            userName = new TextBox();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = SystemColors.Control;
            Heading.Font = new Font("Sitka Small", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(173, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(405, 42);
            Heading.TabIndex = 6;
            Heading.Text = "You can delete update here";
            // 
            // todoSubmit
            // 
            todoSubmit.AutoSize = true;
            todoSubmit.Location = new Point(496, 201);
            todoSubmit.Name = "todoSubmit";
            todoSubmit.Size = new Size(130, 35);
            todoSubmit.TabIndex = 14;
            todoSubmit.Text = "Update  Todo";
            todoSubmit.UseVisualStyleBackColor = true;
            // 
            // todoDesc
            // 
            todoDesc.Location = new Point(192, 280);
            todoDesc.Name = "todoDesc";
            todoDesc.PlaceholderText = "Todo desc";
            todoDesc.Size = new Size(150, 31);
            todoDesc.TabIndex = 13;
            // 
            // todoTitle
            // 
            todoTitle.Location = new Point(192, 210);
            todoTitle.Name = "todoTitle";
            todoTitle.PlaceholderText = "TodoTitle";
            todoTitle.Size = new Size(150, 31);
            todoTitle.TabIndex = 12;
            // 
            // userName
            // 
            userName.Location = new Point(192, 139);
            userName.Name = "userName";
            userName.PlaceholderText = "UserName";
            userName.Size = new Size(150, 31);
            userName.TabIndex = 11;
            // 
            // UpdateTodo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(todoSubmit);
            Controls.Add(todoDesc);
            Controls.Add(todoTitle);
            Controls.Add(userName);
            Controls.Add(Heading);
            Name = "UpdateTodo";
            Text = "UpdateTodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private Button todoSubmit;
        private TextBox todoDesc;
        private TextBox todoTitle;
        private TextBox userName;
    }
}