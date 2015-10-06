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
    public partial class ADMIN_Nurse : Form
    {
        public ADMIN_Nurse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNurseForm AddNurseForm = new AddNurseForm();
            AddNurseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveNurseForm RemoveNurseForm = new RemoveNurseForm();
            RemoveNurseForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurseinfo NI = new Nurseinfo();
            NI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
