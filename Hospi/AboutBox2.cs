using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospi
{
    partial class AboutBox2 : Form
    {
        public string Author = "Soroush Ziaeinejad & Shahin Rahbari Asl";
        public string AppName = "Hospital Database management";
        public string Version = "1.0.0.1";
        public AboutBox2()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                return "Hospital Database Implementation Project";
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return "1.0.0.1";
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return "Hospital management system"+Environment.NewLine+Environment.NewLine+
                "Soroush Ziaeinejad & Shahin Rahbari Asl" + Environment.NewLine +Environment.NewLine+ "Database Laboratory"
            +Environment.NewLine+Environment.NewLine+"Professor: Mr Torkashvan";
            }
        }

        public string AssemblyProduct
        {
            get
            {
                return "Hospital Databsae";
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                return "IUST";
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox2_Load(object sender, EventArgs e)
        {

        }
    }
}
