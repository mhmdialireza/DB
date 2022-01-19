
namespace DataBase_project
{
    partial class SearchVisit
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
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.operations = new System.Windows.Forms.GroupBox();
            this.cleanB = new System.Windows.Forms.Button();
            this.pCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.final_hospitalDataSet1 = new DataBase_project.Final_hospitalDataSet1();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new DataBase_project.Final_hospitalDataSet1TableAdapters.visitsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // operations
            // 
            this.operations.Controls.Add(this.cleanB);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(998, 116);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 307);
            this.operations.TabIndex = 31;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
            // 
            // cleanB
            // 
            this.cleanB.Location = new System.Drawing.Point(17, 134);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(148, 48);
            this.cleanB.TabIndex = 7;
            this.cleanB.Text = "پاک کردن";
            this.cleanB.UseVisualStyleBackColor = true;
            this.cleanB.Click += new System.EventHandler(this.cleanB_Click);
            // 
            // pCombo
            // 
            this.pCombo.FormattingEnabled = true;
            this.pCombo.Location = new System.Drawing.Point(136, 105);
            this.pCombo.Name = "pCombo";
            this.pCombo.Size = new System.Drawing.Size(661, 49);
            this.pCombo.TabIndex = 5;
            this.pCombo.SelectedIndexChanged += new System.EventHandler(this.pCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "پزشک";
            // 
            // dCombo
            // 
            this.dCombo.FormattingEnabled = true;
            this.dCombo.Location = new System.Drawing.Point(136, 39);
            this.dCombo.Name = "dCombo";
            this.dCombo.Size = new System.Drawing.Size(661, 49);
            this.dCombo.TabIndex = 1;
            this.dCombo.SelectedIndexChanged += new System.EventHandler(this.dCombo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dCombo);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(29, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 180);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو با نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(820, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "بیمار";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.final_hospitalDataSet;
            // 
            // final_hospitalDataSet
            // 
            this.final_hospitalDataSet.DataSetName = "Final_hospitalDataSet";
            this.final_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "patients";
            this.patientsBindingSource1.DataSource = this.final_hospitalDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 310);
            this.dataGridView1.TabIndex = 34;
            // 
            // final_hospitalDataSet1
            // 
            this.final_hospitalDataSet1.DataSetName = "Final_hospitalDataSet1";
            this.final_hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "visits";
            this.visitsBindingSource.DataSource = this.final_hospitalDataSet1;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(34, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(943, 237);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست و جو با تاریخ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(118, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "جست‌وجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchVisit";
            this.Text = "SearchVisit";
            this.Load += new System.EventHandler(this.SearchVisit_Load);
            this.operations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.ComboBox pCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Final_hospitalDataSet final_hospitalDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Final_hospitalDataSet1 final_hospitalDataSet1;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private Final_hospitalDataSet1TableAdapters.visitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}