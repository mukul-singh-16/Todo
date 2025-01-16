namespace Todo
{
    partial class AddTodo
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
            todoDesc = new TextBox();
            todoSubmit = new Button();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = SystemColors.Control;
            Heading.Font = new Font("Sitka Small", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(178, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(372, 42);
            Heading.TabIndex = 6;
            Heading.Text = "You can create todo here";
            // 
            // userName
            // 
            userName.Location = new Point(225, 124);
            userName.Name = "userName";
            userName.PlaceholderText = "UserName";
            userName.Size = new Size(150, 31);
            userName.TabIndex = 7;
            // 
            // todoTitle
            // 
            todoTitle.Location = new Point(225, 195);
            todoTitle.Name = "todoTitle";
            todoTitle.PlaceholderText = "TodoTitle";
            todoTitle.Size = new Size(150, 31);
            todoTitle.TabIndex = 8;
            // 
            // todoDesc
            // 
            todoDesc.Location = new Point(225, 265);
            todoDesc.Name = "todoDesc";
            todoDesc.PlaceholderText = "Todo desc";
            todoDesc.Size = new Size(150, 31);
            todoDesc.TabIndex = 9;
            // 
            // todoSubmit
            // 
            todoSubmit.Location = new Point(529, 186);
            todoSubmit.Name = "todoSubmit";
            todoSubmit.Size = new Size(112, 34);
            todoSubmit.TabIndex = 10;
            todoSubmit.Text = "Submit";
            todoSubmit.UseVisualStyleBackColor = true;
            // 
            // AddTodo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(todoSubmit);
            Controls.Add(todoDesc);
            Controls.Add(todoTitle);
            Controls.Add(userName);
            Controls.Add(Heading);
            Name = "AddTodo";
            Text = "AddTodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private TextBox userName;
        private TextBox todoTitle;
        private TextBox todoDesc;
        private Button todoSubmit;
    }
}