namespace TaskFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbCategory.SelectedIndex = 0;

            dgvTasks.Columns.Add("Title", "Title");
            dgvTasks.Columns.Add("Category", "Category");
            dgvTasks.Columns.Add("Start", "Start Date");
            dgvTasks.Columns.Add("End", "End Date");
            dgvTasks.Columns.Add("Status", "Status");

            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.ReadOnly = true;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.Text == "")
                    throw new Exception("Enter a title");

                if (dtpEnd.Value.Date < dtpStart.Value.Date)
                    throw new Exception("End date cannot be before start date");

                MyTask task = new WorkTask();
                if (cmbCategory.Text == "Study")
                    task = new StudyTask();
                if (cmbCategory.Text == "Workout")
                    task = new WorkoutTask();
                if (cmbCategory.Text == "Movies")
                    task = new MovieTask();
                if (cmbCategory.Text == "Dummy")
                    task = new Dummy();

                task.Title = txtTitle.Text;

                dgvTasks.Rows.Add(task.Title, task.GetInfo(),
                    dtpStart.Value.ToShortDateString(),
                    dtpEnd.Value.ToShortDateString(),
                    "Pending");

                txtTitle.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
                dgvTasks.Rows.Remove(dgvTasks.CurrentRow);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
                dgvTasks.CurrentRow.Cells["Status"].Value = "Done";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTasks.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}