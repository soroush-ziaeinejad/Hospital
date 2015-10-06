using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace Hospi
{
   
    public partial class Nurseinfo : Form
    {
        HospitalEntities HE1 = new HospitalEntities();
        public Nurseinfo()
        {
            InitializeComponent();
        }

        private void Nurseinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet10.Nurses' table. You can move, or remove it, as needed.
            this.nursesTableAdapter.Fill(this.hospitalDataSet10.Nurses);
            BindingSource BIS = new BindingSource();
            BIS.DataSource = HE1.Nurses;
            dataGridView1.DataSource = BIS;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HE1.SaveChanges();
            MessageBox.Show("Saved!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs("C:\\Users\\Soroush\\Desktop\\NurseTable.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
