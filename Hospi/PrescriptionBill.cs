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
    public partial class PrescriptionBill : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public PrescriptionBill()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Patient pt in HE1.Patients)
            {
                if (pt.Patient_Name == comboBox1.Text)
                {
                    foreach (Prescription prs in HE1.Prescriptions)
                    {
                        if (prs.PID == pt.PID)
                        {
                            foreach(Medicine Mdc in HE1.Medicines)
                            {
                                if (Mdc.Mdcn_ID == prs.Mdcn_ID)
                                    MessageBox.Show("jadval por shavad");
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) * (100 - Convert.ToInt32(textBox2.Text))).ToString();
        }

        private void PrescriptionBill_Load(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
            foreach (Patient PT in HE1.Patients)
                comboBox1.Items.Add(PT.Patient_Name);
        }
    }
}
