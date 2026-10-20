namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(txtNum1.Text, out a) &&
                int.TryParse(txtNum2.Text, out b))
            {
                lblResult.Text = "Result: " + Math.Max(a, b);
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }
        private int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}
