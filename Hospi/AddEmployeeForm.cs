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
    public partial class AddEmployeeForm : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case ("پذیرش"):
                    Receptionist RC = new Receptionist();
                    RC.gender = comboBox2.Text;
                    RC.national_code = textBox5.Text;
                    RC.Rcp_id = Convert.ToInt32(textBox1.Text);
                    RC.RcpLname = textBox3.Text;
                    RC.RcpName = textBox2.Text;
                    RC.Salary = Convert.ToInt32(textBox7.Text);
                    HE1.Receptionists.Add(RC);
                    goto case ("راننده");
                case ("راننده"):
                    Driver DR = new Driver();
                    DR.Driver_id = Convert.ToInt32(textBox1.Text);
                    DR.Driver_name = textBox3.Text;
                    DR.Driver_number = textBox4.Text;
                    DR.salary = Convert.ToInt32(textBox7.Text);
                    HE1.Drivers.Add(DR);
                    goto case ("حمل و نقل");
                case ("حمل و نقل"):
                    Carrier CR = new Carrier();
                    CR.Carrier_id = Convert.ToInt32(textBox1.Text);
                    CR.Salary = Convert.ToInt32(textBox7.Text);
                    HE1.Carriers.Add(CR);
                    goto case ("حسابدار");
                case ("حسابدار"):
                    Accountant AC = new Accountant();
                    AC.Act_id = Convert.ToInt32(textBox1.Text);
                    AC.Act_LName = textBox3.Text;
                    AC.Act_name = textBox2.Text;
                    AC.Address = textBox11.Text;
                    AC.Gender = comboBox2.Text;
                    AC.mobile_number = textBox4.Text;
                    AC.National_Code = textBox5.Text;
                    AC.Act_age = Convert.ToInt32(textBox10.Text);
                    HE1.Accountants.Add(AC);
                    goto case ("امنیتی");
                case ("امنیتی"):
                    security SC = new security();
                    SC.national_code = textBox5.Text;
                    SC.salary = Convert.ToInt32(textBox7.Text);
                    SC.sec_ID = Convert.ToInt32(textBox1.Text);
                    SC.sec_name = textBox2.Text;
                    SC.sec_Lname = textBox3.Text;
                    HE1.securities.Add(SC);
                    goto case ("مستخدم");
                case ("مستخدم"):
                    servant SR = new servant();
                    SR.salary = Convert.ToInt32(textBox7.Text);
                    SR.servant_id = Convert.ToInt32(textBox1.Text);
                    SR.servant_Lname = textBox3.Text;
                    SR.servant_name = textBox2.Text;
                    SR.servant_number = textBox4.Text;
                    HE1.servants.Add(SR);
                    goto case("مسئول داروخانه");
                case ("مسئول داروخانه"):
                    Drugstore_cashier DRCS = new Drugstore_cashier();
                    DRCS.DSC_id = Convert.ToInt32(textBox1.Text);
                    DRCS.DSC_name = textBox3.Text;
                    DRCS.DSC_number = textBox4.Text;
                    DRCS.salary = Convert.ToInt32(textBox7.Text);
                    HE1.Drugstore_cashier.Add(DRCS);
                    goto default;
                default:
                    MessageBox.Show("لطفا فیلد کار را به درستی وارد کنید");
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
