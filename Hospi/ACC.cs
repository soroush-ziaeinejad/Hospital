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
    public partial class ACC : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public ACC()
        {
            InitializeComponent();
        }

        private void ACC_Load(object sender, EventArgs e)
        {
            foreach (Accountant ACC in HE1.Accountants)
            {
                if (ACC.IsLogin == "YES")
                {
                    label4.Text = ACC.Act_name;
                    label3.Text = ACC.Act_LName;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Accountant acc in HE1.Accountants)
                acc.IsLogin = "NO";
            HE1.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrescriptionBill prsbill = new PrescriptionBill();
            prsbill.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalaryForm SF = new SalaryForm();
            SF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
