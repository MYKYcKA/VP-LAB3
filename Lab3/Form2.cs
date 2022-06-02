using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public List<EmployeeDTO> employeeList = new List<EmployeeDTO>();

        public Form2()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            var form2 = new Form2();
            var selected = employeeList.Where(x => x.GetType().GetProperty(comboBox1.SelectedItem as string).GetValue(x, null).Equals(SearchtextBox1.Text)).ToList();
            form2.employeeList = selected;
            form2.dataGridView1.DataSource = selected;
            form2.dataGridView1.Columns[0].Visible = NamecheckBox1.Checked;
            form2.dataGridView1.Columns[1].Visible = SurnamecheckBox2.Checked;
            form2.dataGridView1.Columns[2].Visible = BirthDatecheckBox1.Checked;
            form2.dataGridView1.Columns[3].Visible = PhoneNumbercheckBox2.Checked;
            form2.dataGridView1.Columns[4].Visible = AddresscheckBox4.Checked;
            form2.dataGridView1.Columns[5].Visible = CitycheckBox3.Checked;
            form2.dataGridView1.Columns[6].Visible = StreetcheckBox2.Checked;
            form2.dataGridView1.Columns[7].Visible = BuildingcheckBox1.Checked;
            form2.dataGridView1.Columns[8].Visible = AppartmentcheckBox5.Checked;
            var averageAge = 0;
            foreach (var employee in selected)
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                var birtdate = DateTime.Parse(employee.BirthDate);
                var age = DateTime.Now - birtdate;
                var years = (zeroTime + age).Year - 1;
                averageAge += years;
            }
            if (selected.Count != 0)
                averageAge /= selected.Count;
            form2.label1.Text += $" {averageAge}";
            form2.ShowDialog();
        }
    }
}
