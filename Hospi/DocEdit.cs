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
    public partial class DocEdit : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public DocEdit()
        {
            InitializeComponent();
        }

        private void DocEdit_Load(object sender, EventArgs e)
        {
            foreach (Doctor Doc in HE1.Doctors)
            {
                if (Doc.IsLogin == "YES")
                {
                    textBox1.Text = Doc.DID.ToString() ;
                    textBox2.Text = Doc.Doc_name;
                    textBox3.Text = Doc.Doc_Lname;
                    textBox4.Text = Doc.PhoneNumber;
                    textBox6.Text = Doc.NationalCode;
                    textBox7.Text = Doc.Specialization;
                    textBox9.Text = Doc.Salary.ToString();
                    comboBox1.Text = Doc.Gender;
                    foreach (Department dept in HE1.Departments)
                    {
                        if (dept.Dept_ID == Doc.Dept_ID)
                        {
                            textBox10.Text = dept.Dept_Name;
                        }
                    }
                    textBox11.Text = Doc.Address;
                    dateTimePicker1.Text = Doc.Employment_date.ToString();

                }
            }
        }
    }
}
