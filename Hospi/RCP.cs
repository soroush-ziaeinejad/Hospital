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
    public partial class RCP : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public RCP()
        {
            InitializeComponent();
        }

        private void RCP_Load(object sender, EventArgs e)
        {
            foreach (Receptionist ACC in HE1.Receptionists)
            {
                if (ACC.isLogin == "YES")
                {
                    label4.Text = ACC.RcpName;
                    label3.Text = ACC.RcpLname;
                }
                foreach (Patient pt in HE1.Patients)
                    comboBox1.Items.Add(pt.Patient_Name);
                foreach (Doctor D in HE1.Doctors)
                    comboBox2.Items.Add(D.Doc_Lname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appoinment Ap = new Appoinment();
            Ap.Ap_time = System.DateTime.Today.TimeOfDay;
            Ap.Ap_date = dateTimePicker1.Value.Date;
            Ap.DID = 1;
            Ap.PID = 2;
            Ap.Rcp_id = 3;
            foreach (Doctor DC in HE1.Doctors)
            {
                if (DC.Doc_Lname == comboBox2.Text)
                    Ap.DID = DC.DID;
            }
            foreach (Patient PT in HE1.Patients)
            {
                if (PT.Patient_Name == comboBox1.Text)
                    Ap.PID = PT.PID;
            }
            foreach (Receptionist R in HE1.Receptionists)
            {
                if (R.isLogin == "YES")
                    Ap.Rcp_id = R.Rcp_id;
            }
            HE1.Appoinments.Add(Ap);
            //HE1.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HE1.SaveChanges();
        }
    }
}
