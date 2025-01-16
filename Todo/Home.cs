namespace Todo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addTodo_Click(object sender, EventArgs e)
        {
            AddTodo addTodo = new AddTodo();
            addTodo.Show();
        }

        private void deleteTodo_Click(object sender, EventArgs e)
        {
            DeleteTodo delTodo = new DeleteTodo();
            delTodo.Show();
        }

        private void searchTodo_Click(object sender, EventArgs e)
        {
            SearchTodo searchTodo = new SearchTodo();   
            searchTodo.Show();

        }

        private void updateTodo_Click(object sender, EventArgs e)
        {
            UpdateTodo updateTodo = new UpdateTodo();
            updateTodo.Show();

        }
    }
}
