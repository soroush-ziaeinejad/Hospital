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
    public partial class prescriptioning : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        int lastID;
        public prescriptioning()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Patient pt in HE1.Patients)
            {
                if (pt.Patient_Name == comboBox1.Text)
                {
                    textBox1.Text = pt.Disease_type;
                    textBox2.Text = (System.DateTime.Today.Year-pt.Date_of_Birth.Value.Year).ToString();
                    textBox3.Text = pt.Blood_Type;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prs = new Prescription();
            prs.date = System.DateTime.Today;
            prs.NumberInDay = Convert.ToInt32(textBox4.Text);
            prs.Numbers = Convert.ToInt32(textBox5.Text);
            foreach (Doctor DC in HE1.Doctors)
            {
                if (DC.IsLogin == "YES")
                    prs.DID = DC.DID;
            }
            foreach (Medicine MC in HE1.Medicines)
            {
                if (MC.Mdcn_Name == comboBox2.Text)
                    prs.Mdcn_ID = MC.Mdcn_ID;
            }
            foreach (Patient PT in HE1.Patients)
            {
                if (PT.Patient_Name == comboBox1.Text)
                {
                    prs.PID = PT.PID;
                }
            }
            prs.time = System.DateTime.Now.TimeOfDay;
            HE1.Prescriptions.Add(prs);
            
            //foreach (Prescription ps in HE1.Prescriptions)
            //{
            //    lastID = ps.prs_id;
            //}
            //lastID++;
            //prs.prs_id = lastID;

           // MessageBox.Show(prs.prs_id.ToString());
            HE1.SaveChanges();
        }

        private void prescriptioning_Load(object sender, EventArgs e)
        {
            foreach (Medicine MD in HE1.Medicines)
            {
                comboBox2.Items.Add(MD.Mdcn_Name);
            }
            foreach (Patient PT in HE1.Patients)
            {
                comboBox1.Items.Add(PT.Patient_Name);
            }
        }
    }
}
