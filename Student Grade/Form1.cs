namespace Student_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError_reset();
            if (int.TryParse(txtMark.Text, out int mark) && mark >= 0 && mark <= 100)
            {
                lstMarks.Items.Add(mark);
                txtMark.Clear();
                txtMark.Focus();
            }
            else
            {
                txtMark.Clear();
                lblError.Text = "Please enter a valid mark between 0 and 100.";
            }
        }

        private void lblError_reset()
        {
            lblError.Text = "";
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            lblError_reset();
            if (lstMarks.Items.Count == 0)
            {
                return;
            }

            List<int> marks = lstMarks.Items.Cast<int>().ToList();
            int maxMark = marks.Max();
            int minMark = marks.Min();
            double average = marks.Average();

            lblMaxResult.Text = maxMark.ToString();
            lblMinResult.Text = minMark.ToString();
            lblGradeResult.Text = average.ToString("F2");

            if (average < 50)
            {
                lblGradeResult.ForeColor = Color.Red;
            }
            else
            {
                lblGradeResult.ForeColor = Color.Green;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblError_reset();
            txtMark.Clear();
            lblGradeResult.Text = "";
            lblMinResult.Text = "";
            lblMaxResult.Text = "";
            lstMarks.Items.Clear();
            txtMark.ForeColor = Color.Black;
            txtMark.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMark_TextChanged(object sender, EventArgs e)
        {
            lblError_reset();
        }

        private void txtMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

