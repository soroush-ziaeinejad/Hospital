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
    
    public partial class AddNurseForm : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public AddNurseForm()
        {
            InitializeComponent();
        }

        private void AddNurseForm_Load(object sender, EventArgs e)
        {
            if (HE1.Nurses.Count() > 10)
            {
                MessageBox.Show("تعداد پرستااران به حد مجاز رسیده است و نمیتوانید پرستار اضافه کنید");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Nurse NEWDC = new Nurse();
                NEWDC.Address = textBox11.Text;
                foreach (Department DEPT in HE1.Departments)
                {
                    if (DEPT.Dept_Name == textBox10.Text)
                        NEWDC.DeptID = DEPT.Dept_ID;
                }
                NEWDC.NID = Convert.ToInt32(textBox1.Text);
                NEWDC.Nurse_Lname = textBox3.Text;
                NEWDC.Nurse_name = textBox2.Text;

                NEWDC.Employment_date = Convert.ToDateTime(dateTimePicker1.Text);
                NEWDC.Birth_date = Convert.ToDateTime(dateTimePicker2.Text);
                NEWDC.Gender = comboBox1.Text;
                NEWDC.Marrige = comboBox2.Text;
                NEWDC.Shift = comboBox3.Text;
                NEWDC.National_Code = textBox6.Text;
                NEWDC.Number = textBox4.Text;
                NEWDC.Salary = Convert.ToInt32(textBox9.Text);
                NEWDC.City = textBox7.Text;

                HE1.Nurses.Add(NEWDC);
                HE1.SaveChanges();
                MessageBox.Show("پرستار" + " " + NEWDC.Nurse_Lname + " " + "با موفقیت اضافه شد");
            }
            catch { MessageBox.Show("check inputs. maybe ID is duplicate"); }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
