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
    public partial class AddDoctor : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor NEWDC = new Doctor();
                NEWDC.Address = textBox11.Text;
                foreach (Department DEPT in HE1.Departments)
                {
                    if (DEPT.Dept_Name == textBox10.Text)
                        NEWDC.Dept_ID = DEPT.Dept_ID;
                }
                NEWDC.DID = Convert.ToInt32(textBox1.Text);
                NEWDC.Doc_Lname = textBox3.Text;
                NEWDC.Doc_name = textBox2.Text;

                NEWDC.Employment_date = Convert.ToDateTime(dateTimePicker1.Text);
                NEWDC.Gender = comboBox1.Text;
                NEWDC.NationalCode = textBox6.Text;
                NEWDC.PhoneNumber = textBox4.Text;
                NEWDC.Salary = Convert.ToInt32(textBox9.Text);
                NEWDC.Specialization = textBox7.Text;

                HE1.Doctors.Add(NEWDC);
                HE1.SaveChanges();
                MessageBox.Show("دکتر" + " " + NEWDC.Doc_Lname + " " + "با موفقیت اضافه شد");
            }
            catch { MessageBox.Show("check inputs. maybe ID is duplicate"); }
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            if (HE1.Doctors.Count() > 10)
            {
                MessageBox.Show("تعداد دکترها به حد نصاب رسیده است و نمیتوانید دکتر جدیدی را اضافه کنید");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
