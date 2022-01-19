
namespace DataBase_project
{
    partial class medical_Recordes
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
            this.finalhospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.IDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IFName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cleanB = new System.Windows.Forms.Button();
            this.operations = new System.Windows.Forms.GroupBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.final_hospitalDataSet1 = new DataBase_project.Final_hospitalDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.finalhospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // finalhospitalDataSetBindingSource
            // 
            this.finalhospitalDataSetBindingSource.DataSource = this.final_hospitalDataSet;
            this.finalhospitalDataSetBindingSource.Position = 0;
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
            // IDC
            // 
            this.IDC.BackColor = System.Drawing.Color.White;
            this.IDC.Location = new System.Drawing.Point(19, 48);
            this.IDC.Name = "IDC";
            this.IDC.Size = new System.Drawing.Size(304, 48);
            this.IDC.TabIndex = 1;
            this.IDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "توضیحات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(807, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 43);
            this.label6.TabIndex = 12;
            this.label6.Text = "شناسه بیمار";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 43);
            this.label7.TabIndex = 14;
            this.label7.Text = "تاریخ بهبود";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(841, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 43);
            this.label8.TabIndex = 16;
            this.label8.Text = "تاریخ ابتلا";
            // 
            // IFName
            // 
            this.IFName.Location = new System.Drawing.Point(526, 53);
            this.IFName.Name = "IFName";
            this.IFName.Size = new System.Drawing.Size(304, 48);
            this.IFName.TabIndex = 17;
            this.IFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 33);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IFName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDC);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 257);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سوابق پزشکی";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(75, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 47);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "هنوز بهبود نیافته است";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("IRAN Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(304, 33);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(526, 191);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(275, 49);
            this.comboBox.TabIndex = 20;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(526, 51);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(256, 48);
            this.searchBox.TabIndex = 17;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(13, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(948, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست‌وجو";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 49);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 54);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(118, 43);
            this.label3.TabIndex = 20;
            this.label3.Text = "شناسه بیمار";
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
            // operations
            // 
            this.operations.Controls.Add(this.cleanB);
            this.operations.Controls.Add(this.update);
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.submit);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(977, 109);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 642);
            this.operations.TabIndex = 23;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
            this.operations.Enter += new System.EventHandler(this.operations_Enter);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.final_hospitalDataSet;
            this.patientsBindingSource.CurrentChanged += new System.EventHandler(this.patientsBindingSource_CurrentChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(18, 416);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(942, 334);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // final_hospitalDataSet1
            // 
            this.final_hospitalDataSet1.DataSetName = "Final_hospitalDataSet";
            this.final_hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medical_Recordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 764);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.operations);
            this.Name = "medical_Recordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical_Recordes";
            ((System.ComponentModel.ISupportInitialize)(this.finalhospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource finalhospitalDataSetBindingSource;
        private Final_hospitalDataSet final_hospitalDataSet;
        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TextBox IDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IFName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Final_hospitalDataSet final_hospitalDataSet1;
    }
}