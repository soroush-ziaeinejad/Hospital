using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospi
{
    public partial class SalaryForm : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "دکتر")
            {
                foreach (Doctor doci in HE1.Doctors)
                {
                    comboBox2.Items.Add(doci.Doc_Lname);
                }
            }
            else if (comboBox1.Text == "حسابدار")
            {
                foreach (Accountant AcC in HE1.Accountants)
                {
                    comboBox2.Items.Add(AcC.Act_LName);
                }

            }
            else if (comboBox1.Text == "پذیرش")
            {
                foreach (Receptionist RCP in HE1.Receptionists)
                {
                    comboBox2.Items.Add(RCP.RcpLname);
                }

            }
            else
            {
                MessageBox.Show("لطفا شغل بنده خدا را انتخاب کنید");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "دکتر")
            {
                foreach (Doctor doci in HE1.Doctors)
                {
                    if (doci.Doc_Lname == comboBox2.Text)
                    {
                        textBox1.Text = doci.Salary.ToString();
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }
            }
            else if (comboBox1.Text == "حسابدار")
            {
                foreach (Accountant AcC in HE1.Accountants)
                {
                    if (AcC.Act_LName == comboBox2.Text)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }

            }
            else if (comboBox1.Text == "پذیرش")
            {
                foreach (Receptionist RCP in HE1.Receptionists)
                {
                    if (RCP.RcpLname == comboBox2.Text)
                    {
                        textBox1.Text = RCP.Salary.ToString();
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("لطفا بنده خدا را انتخاب کنید");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) - (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text)/100)).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
