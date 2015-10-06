using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospi
{
    public partial class ADM : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public ADM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN_Doctor NEW_Admin_Doctor_Form = new ADMIN_Doctor();
            NEW_Admin_Doctor_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox2 newAboutBox = new AboutBox2();
            newAboutBox.AppName = "Hospital Database management";
            newAboutBox.Author = "Soroush Ziaeinejad & Shahin Rahbari Asl";
            newAboutBox.Version = "1.0.0.1";
            newAboutBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN_Nurse ADMN = new ADMIN_Nurse();
            ADMN.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 pass = new Form2();
            pass.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DrugstoreForm DSF = new DrugstoreForm();
            DSF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeForm EF = new EmployeeForm();
            EF.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Backup";
            saveFileDialog1.Filter = ".bak |*.bak";
            saveFileDialog1.ShowDialog();
            SqlConnection myconn = new SqlConnection("user id=admin;password=admin;server=WIN7-PC;Trusted_Connection=yes; database=Hospital ; connection timeout=30");
            myconn.Open();
            SqlCommand SQLC = new SqlCommand("Backup database Hospital to disk='" + saveFileDialog1.FileName + "'WITH DIFFERENTIAL", myconn);
            SQLC.ExecuteReader();
            myconn.Close();
            MessageBox.Show("بک آپ از دیتابیس گرفته شد");
        }
    }
}
