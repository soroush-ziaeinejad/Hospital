namespace Hospi
{
    partial class DrugRepository
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mdcnIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdcnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet10 = new Hospi.HospitalDataSet10();
            this.medicinesTableAdapter = new Hospi.HospitalDataSet10TableAdapters.MedicinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("W_tablighat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(420, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Export to excel >>>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(12, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 29);
            this.button2.TabIndex = 8;
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
            this.button1.TabIndex = 7;
            this.button1.Text = "ذخــــــــــیـــــــــره تغـــیـــیــــــــرات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdcnIDDataGridViewTextBoxColumn,
            this.mdcnNameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.pdateDataGridViewTextBoxColumn,
            this.edateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 354);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mdcnIDDataGridViewTextBoxColumn
            // 
            this.mdcnIDDataGridViewTextBoxColumn.DataPropertyName = "Mdcn_ID";
            this.mdcnIDDataGridViewTextBoxColumn.HeaderText = "Mdcn_ID";
            this.mdcnIDDataGridViewTextBoxColumn.Name = "mdcnIDDataGridViewTextBoxColumn";
            // 
            // mdcnNameDataGridViewTextBoxColumn
            // 
            this.mdcnNameDataGridViewTextBoxColumn.DataPropertyName = "Mdcn_Name";
            this.mdcnNameDataGridViewTextBoxColumn.HeaderText = "Mdcn_Name";
            this.mdcnNameDataGridViewTextBoxColumn.Name = "mdcnNameDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // pdateDataGridViewTextBoxColumn
            // 
            this.pdateDataGridViewTextBoxColumn.DataPropertyName = "p_date";
            this.pdateDataGridViewTextBoxColumn.HeaderText = "p_date";
            this.pdateDataGridViewTextBoxColumn.Name = "pdateDataGridViewTextBoxColumn";
            // 
            // edateDataGridViewTextBoxColumn
            // 
            this.edateDataGridViewTextBoxColumn.DataPropertyName = "e_date";
            this.edateDataGridViewTextBoxColumn.HeaderText = "e_date";
            this.edateDataGridViewTextBoxColumn.Name = "edateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.hospitalDataSet10;
            // 
            // hospitalDataSet10
            // 
            this.hospitalDataSet10.DataSetName = "HospitalDataSet10";
            this.hospitalDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // DrugRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 414);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DrugRepository";
            this.Text = "DrugRepository";
            this.Load += new System.EventHandler(this.DrugRepository_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet10 hospitalDataSet10;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private HospitalDataSet10TableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdcnIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdcnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    }
}