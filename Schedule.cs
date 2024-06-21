using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace تطبيق_أبو_أحمد_العقاري
{
    public partial class Schedule : Form
    {
        private int rowCount = 1;

        public Schedule()
        {
            InitializeComponent();
            SetupDataGridView();
            FillDataGridView();
        }
        private void SetupDataGridView()
        {
            // Define columns
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Num";
            dataGridView1.Columns[1].Name = "Client";
            dataGridView1.Columns[2].Name = "Day";
            dataGridView1.Columns[3].Name = "Time";
            dataGridView1.Columns[4].Name = "Purpose";
        }

        private void FillDataGridView()
        {
            // Define rows with sample data
            string[] row1 = new string[] { "1", "John Doe", "26/6", "9:00", "Meeting" };
            string[] row2 = new string[] { "2", "Jane Smith", "27/6", "10:00", "Consultation" };
            string[] row3 = new string[] { "3", "Jim Brown", "28/6", "11:00", "Property Viewing" };
            // Add more rows as needed...

            // Add rows to the DataGridView
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            // Add more rows as needed...
        }

        public void AddRow(string client, string day, string time, string purpose)
        {
            string num = rowCount.ToString();
            string[] row = new string[] { num, client, day, time, purpose };
            dataGridView1.Rows.Add(row);
            rowCount++;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAccount employeeAccount = new EmployeeAccount();
            employeeAccount.Show();
        }
    }
}
