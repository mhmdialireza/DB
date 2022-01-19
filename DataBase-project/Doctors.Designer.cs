
namespace DataBase_project
{
    partial class Doctors
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
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cleanB = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.operations = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
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
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(28, 417);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(942, 334);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
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
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(23, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(948, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست‌وجو";
            // 
            // cleanB
            // 
            this.cleanB.Location = new System.Drawing.Point(18, 575);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(148, 48);
            this.cleanB.TabIndex = 7;
            this.cleanB.Text = "پاک کردن";
            this.cleanB.UseVisualStyleBackColor = true;
            this.cleanB.Click += new System.EventHandler(this.cleanB_Click);
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // operations
            // 
            this.operations.Controls.Add(this.cleanB);
            this.operations.Controls.Add(this.update);
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.submit);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(987, 110);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 642);
            this.operations.TabIndex = 23;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 33);
            this.dateTimePicker1.TabIndex = 19;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
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
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 257);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پزشکان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 43);
            this.label3.TabIndex = 21;
            this.label3.Text = "شماره اتاق";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 49);
            this.comboBox1.TabIndex = 20;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 767);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.operations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Final_hospitalDataSet final_hospitalDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox INCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IMNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ILName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}