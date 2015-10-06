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
    
    public partial class Form1 : Form
    {
        string ID;
        int ErrorCounter = 0;
        HospitalEntities HE1 = new HospitalEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                //Login NewAccess = new Login();
                //NewAccess.Username = "admin";
                //NewAccess.Password = "admin".GetHashCode().ToString();
                //NewAccess.access = "ADMINISTRATOR";
                //HE1.Logins.Add(NewAccess);
                //foreach (Accountant ACCO in HE1.Accountants)
                //{
                //    Login NewAccess2 = new Login();
                //    NewAccess2.Username = ACCO.Act_id.ToString();
                //    NewAccess2.Password = ACCO.mobile_number.ToString().GetHashCode().ToString();
                //    NewAccess2.access = "ACCOUNTANT";
                //    HE1.Logins.Add(NewAccess2);
                //}
                //foreach (Receptionist reci in HE1.Receptionists)
                //{
                //    Login NewAccess3 = new Login();
                //    NewAccess3.Username = reci.Rcp_id.ToString();
                //    NewAccess3.Password = reci.DeptID.GetHashCode().ToString();
                //    NewAccess3.access = "RECEPTIONIST";
                //    MessageBox.Show("Add mishe");
                //    HE1.Logins.Add(NewAccess3);
                //}
                //foreach (Doctor Doci in HE1.Doctors)
                //{
                //    Login NewAccess4 = new Login();
                //    NewAccess4.Username = Doci.DID.ToString();
                //    MessageBox.Show(Doci.Dept_ID.GetHashCode().ToString());
                //    NewAccess4.Password = Doci.Dept_ID.GetHashCode().ToString();
                //    NewAccess4.access = "DOCTOR";
                //    HE1.Logins.Add(NewAccess4);
                //}
                //HE1.SaveChanges();
            } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("C:\\Users\\Soroush\\Documents\\Visual Studio 2012\\Projects\\Hospital\\Hospital\\src\\hospital4.png");
        
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        
        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            
            string user = textBox1.Text;
            string password = textBox2.Text.GetHashCode().ToString();
            string accessibility="";
            string EnteredUser = "";
            int flag = 0;
            
            
            foreach (Login LG in HE1.Logins)
            {
                //MessageBox.Show(user + "  " + password);
                if (LG.Username == user && (LG.Password == password || LG.Password == textBox2.Text))
                {
                    ErrorCounter = 0;
                    flag = 1;
                    if (LG.access != "ADMINISTRATOR")
                        ID = LG.Username;
                    accessibility = LG.access;
                    EnteredUser = LG.Username;
                    break;
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("نام کاربری یا پسورد خود را اشتباه وارد کرده اید");
                ErrorCounter++;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (ErrorCounter > 3)
            {
                MessageBox.Show("متاسفانه بیش از حد مجاز اشتباه وارد کرده اید. مجددا وارد برنامه شوید");
                this.Close();
            }
            //MessageBox.Show(accessibility);
            if (accessibility == "ADMINISTRATOR")
            {
                ADM new_adm_form = new ADM();
                new_adm_form.Show();

            }
            if (accessibility == "ACCOUNTANT")
            {
                foreach (Accountant Reci in HE1.Accountants)
                {
                    if (Reci.Act_id.ToString() == EnteredUser)
                    {
                        Reci.IsLogin = "YES";
                    }
                    else Reci.IsLogin = "NO";
                }
                HE1.SaveChanges();
                ACC new_acc_form = new ACC();
                new_acc_form.Show();

            }
            if (accessibility == "RECEPTIONIST")
            {
                foreach (Receptionist Reci in HE1.Receptionists)
                {
                    if (Reci.Rcp_id.ToString() == EnteredUser)
                    {
                        Reci.isLogin = "YES";
                    }
                    else Reci.isLogin = "NO";
                }
                HE1.SaveChanges();
                RCP new_rcp_form = new RCP();
                new_rcp_form.Show();

            }
            if (accessibility == "DOCTOR")
            {
                foreach (Doctor DocI in HE1.Doctors)
                {
                    if (DocI.DID.ToString() == EnteredUser)
                    {
                        //MessageBox.Show("doci islogins mishe yes");
                        DocI.IsLogin = "YES";
                    }
                    else DocI.IsLogin = "NO";
                }
                HE1.SaveChanges();
                DOC new_doc_form = new DOC();
                new_doc_form.Show();

            }
        }

        private void rectangleShape1_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Soroush\\Documents\\Visual Studio 2012\\Projects\\Hospital\\Hospital\\src\\hospital5ed.png");
            label2.Show();
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Soroush\\Documents\\Visual Studio 2012\\Projects\\Hospital\\Hospital\\src\\hospital4.png");
            label2.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("admin".GetHashCode().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("boss".GetHashCode().ToString());
        }
    }
}
