
namespace DataBase_project
{
    partial class Patients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.IFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.INCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IMNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ILName = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.GroupBox();
            this.vButtom = new System.Windows.Forms.Button();
            this.cleanB = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.tableAdapterManager1 = new DataBase_project.Final_hospitalDataSet1TableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.operations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IFName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.INCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IMNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ILName);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بیماران";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 33);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(883, 55);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(42, 43);
            this.label9.TabIndex = 18;
            this.label9.Text = "نام";
            // 
            // IFName
            // 
            this.IFName.Location = new System.Drawing.Point(526, 53);
            this.IFName.Name = "IFName";
            this.IFName.Size = new System.Drawing.Size(304, 48);
            this.IFName.TabIndex = 17;
            this.IFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IFName.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 43);
            this.label8.TabIndex = 16;
            this.label8.Text = "کدملی";
            // 
            // INCode
            // 
            this.INCode.Location = new System.Drawing.Point(526, 114);
            this.INCode.Name = "INCode";
            this.INCode.Size = new System.Drawing.Size(304, 48);
            this.INCode.TabIndex = 15;
            this.INCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 43);
            this.label7.TabIndex = 14;
            this.label7.Text = "شماره موبایل";
            // 
            // IMNumber
            // 
            this.IMNumber.Location = new System.Drawing.Point(19, 121);
            this.IMNumber.Name = "IMNumber";
            this.IMNumber.Size = new System.Drawing.Size(304, 48);
            this.IMNumber.TabIndex = 13;
            this.IMNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(841, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 43);
            this.label6.TabIndex = 12;
            this.label6.Text = "تاریخ تولد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام خانوادگی";
            // 
            // ILName
            // 
            this.ILName.BackColor = System.Drawing.Color.White;
            this.ILName.Location = new System.Drawing.Point(19, 48);
            this.ILName.Name = "ILName";
            this.ILName.Size = new System.Drawing.Size(304, 48);
            this.ILName.TabIndex = 1;
            this.ILName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operations
            // 
            this.operations.Controls.Add(this.vButtom);
            this.operations.Controls.Add(this.cleanB);
            this.operations.Controls.Add(this.update);
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.button1);
            this.operations.Controls.Add(this.submit);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(976, 111);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 642);
            this.operations.TabIndex = 1;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
            // 
            // vButtom
            // 
            this.vButtom.Location = new System.Drawing.Point(18, 415);
            this.vButtom.Name = "vButtom";
            this.vButtom.Size = new System.Drawing.Size(148, 48);
            this.vButtom.TabIndex = 8;
            this.vButtom.Text = "ویزیت";
            this.vButtom.UseVisualStyleBackColor = true;
            this.vButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // cleanB
            // 
            this.cleanB.Location = new System.Drawing.Point(18, 575);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(148, 48);
            this.cleanB.TabIndex = 7;
            this.cleanB.Text = "پاک کردن";
            this.cleanB.UseVisualStyleBackColor = true;
            this.cleanB.Click += new System.EventHandler(this.button7_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(18, 136);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 48);
            this.update.TabIndex = 6;
            this.update.Text = "بروزرسانی";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.delete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "ثبت سوابق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(18, 69);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(148, 48);
            this.submit.TabIndex = 0;
            this.submit.Text = "ایجاد";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(948, 123);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست‌وجو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(145, 43);
            this.label2.TabIndex = 18;
            this.label2.Text = "در تمام فیلد ها";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(47, 51);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(735, 48);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.mobilenumberDataGridViewTextBoxColumn,
            this.nationalcodeDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.patientsBindingSource;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(17, 418);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(942, 334);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // mobilenumberDataGridViewTextBoxColumn
            // 
            this.mobilenumberDataGridViewTextBoxColumn.DataPropertyName = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.HeaderText = "mobile_number";
            this.mobilenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobilenumberDataGridViewTextBoxColumn.Name = "mobilenumberDataGridViewTextBoxColumn";
            // 
            // nationalcodeDataGridViewTextBoxColumn
            // 
            this.nationalcodeDataGridViewTextBoxColumn.DataPropertyName = "national_code";
            this.nationalcodeDataGridViewTextBoxColumn.HeaderText = "national_code";
            this.nationalcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalcodeDataGridViewTextBoxColumn.Name = "nationalcodeDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
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
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DataBase_project.Final_hospitalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.visitsTableAdapter = null;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1171, 766);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRAN Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.operations.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox INCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IMNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ILName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private Final_hospitalDataSet final_hospitalDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button vButtom;
        private Final_hospitalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}