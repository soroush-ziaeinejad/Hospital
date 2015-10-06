namespace Hospi
{
    partial class Nurseinfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new Hospi.HospitalDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hospitalDataSet10 = new Hospi.HospitalDataSet10();
            this.nursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nursesTableAdapter = new Hospi.HospitalDataSet10TableAdapters.NursesTableAdapter();
            this.nIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marrigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIDDataGridViewTextBoxColumn,
            this.nursenameDataGridViewTextBoxColumn,
            this.nurseLnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.marrigeDataGridViewTextBoxColumn,
            this.employmentdateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 349);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(12, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "بازگـــشـــــت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(214, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "ذخــــــــــیـــــــــره تغـــیـــیــــــــرات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hospitalDataSet10
            // 
            this.hospitalDataSet10.DataSetName = "HospitalDataSet10";
            this.hospitalDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nursesBindingSource
            // 
            this.nursesBindingSource.DataMember = "Nurses";
            this.nursesBindingSource.DataSource = this.hospitalDataSet10;
            // 
            // nursesTableAdapter
            // 
            this.nursesTableAdapter.ClearBeforeFill = true;
            // 
            // nIDDataGridViewTextBoxColumn
            // 
            this.nIDDataGridViewTextBoxColumn.DataPropertyName = "NID";
            this.nIDDataGridViewTextBoxColumn.HeaderText = "NID";
            this.nIDDataGridViewTextBoxColumn.Name = "nIDDataGridViewTextBoxColumn";
            // 
            // nursenameDataGridViewTextBoxColumn
            // 
            this.nursenameDataGridViewTextBoxColumn.DataPropertyName = "Nurse_name";
            this.nursenameDataGridViewTextBoxColumn.HeaderText = "Nurse_name";
            this.nursenameDataGridViewTextBoxColumn.Name = "nursenameDataGridViewTextBoxColumn";
            // 
            // nurseLnameDataGridViewTextBoxColumn
            // 
            this.nurseLnameDataGridViewTextBoxColumn.DataPropertyName = "Nurse_Lname";
            this.nurseLnameDataGridViewTextBoxColumn.HeaderText = "Nurse_Lname";
            this.nurseLnameDataGridViewTextBoxColumn.Name = "nurseLnameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "National_Code";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "National_Code";
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // marrigeDataGridViewTextBoxColumn
            // 
            this.marrigeDataGridViewTextBoxColumn.DataPropertyName = "Marrige";
            this.marrigeDataGridViewTextBoxColumn.HeaderText = "Marrige";
            this.marrigeDataGridViewTextBoxColumn.Name = "marrigeDataGridViewTextBoxColumn";
            // 
            // employmentdateDataGridViewTextBoxColumn
            // 
            this.employmentdateDataGridViewTextBoxColumn.DataPropertyName = "Employment_date";
            this.employmentdateDataGridViewTextBoxColumn.HeaderText = "Employment_date";
            this.employmentdateDataGridViewTextBoxColumn.Name = "employmentdateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("W_tablighat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(420, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Export to excel >>>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nurseinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Nurseinfo";
            this.Text = "Nurseinfo";
            this.Load += new System.EventHandler(this.Nurseinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private HospitalDataSet10 hospitalDataSet10;
        private System.Windows.Forms.BindingSource nursesBindingSource;
        private HospitalDataSet10TableAdapters.NursesTableAdapter nursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marrigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}