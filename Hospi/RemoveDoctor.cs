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
    public partial class RemoveDoctor : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public RemoveDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DialogResult getResult = MessageBox.Show("Are you sure you want to delete Dr " + comboBox1.Text + "?", "Warning", MessageBoxButtons.YesNo);
                if (getResult == System.Windows.Forms.DialogResult.Yes)
                {
                    string ThisName = comboBox1.Text;
                    foreach (Doctor Doci in HE1.Doctors)
                    {
                        if (Doci.Doc_Lname == ThisName)
                        {
                            HE1.Doctors.Remove(Doci);
                            
                        }
                    }
                }
            }
            HE1.SaveChanges();
        }

        private void RemoveDoctor_Load(object sender, EventArgs e)
        {
            foreach (Doctor Docijoon in HE1.Doctors)
            {
                if (Docijoon.Doc_Lname != null)
                {
                    MessageBox.Show(Docijoon.Doc_Lname);
                    comboBox1.Items.Add(Docijoon.Doc_Lname.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
