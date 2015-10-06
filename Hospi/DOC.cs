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
    public partial class DOC : Form
    {
        HospitalEntities HE1 = new HospitalEntities();

        public DOC()
        {
            InitializeComponent();
        }

        private void DOC_Load(object sender, EventArgs e)
        {
            foreach (Doctor Doc in HE1.Doctors)
            {
                if (Doc.IsLogin == "YES")
                {
                    label3.Text = Doc.Doc_Lname;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Doctor doc in HE1.Doctors)
                doc.IsLogin = "NO";
            HE1.SaveChanges();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://www.drugs.com/pdr/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://www.darunama.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DocEdit de = new DocEdit();
            de.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prescriptioning prsc = new prescriptioning();
            prsc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mypatient mypt = new Mypatient();
            mypt.Show();
        }
    }
}
