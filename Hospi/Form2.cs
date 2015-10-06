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
    public partial class Form2 : Form
    {
        HospitalEntities HE1 = new HospitalEntities();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Login LG in HE1.Logins)
            {
                if (LG.Username == "admin" || LG.Username == "Admin")
                {
                    if (LG.Password == textBox1.Text.GetHashCode().ToString())
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            if (textBox2.Text != textBox1.Text)
                            {
                                LG.Password = textBox3.Text.GetHashCode().ToString();
                                MessageBox.Show("گذرواژه تغییر کرد");
                                this.Close();
                            }
                            else { MessageBox.Show("رمز عبور جدید با رمز عبور فعلی برابر است"); textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; }
                        }
                        else { MessageBox.Show("تکرار رمز عبور را صحیح وارد نکرده اید"); textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; }
                    }
                    else { MessageBox.Show("گذرواژه فعلی صحیح نمیباشد"); textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; }
                }
            }
            HE1.SaveChanges();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
