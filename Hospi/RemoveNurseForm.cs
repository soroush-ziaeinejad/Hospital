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
    public partial class RemoveNurseForm : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public RemoveNurseForm()
        {
            InitializeComponent();
        }

        private void RemoveNurseForm_Load(object sender, EventArgs e)
        {
            foreach (Nurse Nursi in HE1.Nurses)
            {
                if (Nursi.Nurse_Lname != null)
                {
                    MessageBox.Show(Nursi.Nurse_Lname);
                    comboBox1.Items.Add(Nursi.Nurse_Lname.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DialogResult getResult = MessageBox.Show("Are you sure you want to delete Mr/Mrs " + comboBox1.Text + "?", "Warning", MessageBoxButtons.YesNo);
                if (getResult == System.Windows.Forms.DialogResult.Yes)
                {
                    string ThisName = comboBox1.Text;
                    foreach (Nurse nursy in HE1.Nurses)
                    {
                        if (nursy.Nurse_Lname == ThisName)
                        {
                            HE1.Nurses.Remove(nursy);

                        }
                    }
                }
            }
            HE1.SaveChanges();
        }
    }
}
