namespace تطبيق_أبو_أحمد_العقاري
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

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BossForm bossForm = new BossForm();
            bossForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}