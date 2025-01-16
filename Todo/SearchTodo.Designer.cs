namespace Todo
{
    partial class SearchTodo
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
            search = new Button();
            menuStrip1 = new MenuStrip();
            showTodos = new ListBox();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = SystemColors.Control;
            Heading.Font = new Font("Sitka Small", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(118, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(566, 42);
            Heading.TabIndex = 6;
            Heading.Text = "You can search todo by username here";
            // 
            // userName
            // 
            userName.Location = new Point(137, 74);
            userName.Name = "userName";
            userName.PlaceholderText = "   username";
            userName.Size = new Size(150, 31);
            userName.TabIndex = 8;
            // 
            // search
            // 
            search.Location = new Point(475, 71);
            search.Name = "search";
            search.Size = new Size(112, 34);
            search.TabIndex = 9;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // showTodos
            // 
            showTodos.FormattingEnabled = true;
            showTodos.ItemHeight = 25;
            showTodos.Location = new Point(134, 148);
            showTodos.Name = "showTodos";
            showTodos.Size = new Size(474, 229);
            showTodos.TabIndex = 11;
            // 
            // SearchTodo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showTodos);
            Controls.Add(search);
            Controls.Add(userName);
            Controls.Add(Heading);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SearchTodo";
            Text = "SearchTodo";
            Load += SearchTodo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private TextBox userName;
        private Button search;
        private MenuStrip menuStrip1;
        private ListBox showTodos;
    }
}