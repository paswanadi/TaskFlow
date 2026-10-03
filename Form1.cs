namespace TaskFlow
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbCategory.SelectedIndex = 0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTitle.Text == "")
                    throw new Exception("Enter a title");

                MyTask task = new WorkTask();
                if (cmbCategory.Text == "Study")
                    task = new StudyTask();

                task.Title = txtTitle.Text;
                lstTasks.Items.Add(task.GetInfo());
                txtTitle.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
                lstTasks.Items.Remove(lstTasks.SelectedItem);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
                lstTasks.Items[lstTasks.SelectedIndex] += " (Done)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTasks.Items.Clear();
        }
    }
}
