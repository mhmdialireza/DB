
namespace DataBase_project
{
    partial class Visits
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.GroupBox();
            this.cleanB = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.selectDate = new System.Windows.Forms.Button();
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tCombo = new System.Windows.Forms.ComboBox();
            this.dCombo = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(61, 417);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(942, 334);
            this.dataGridView.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(56, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(948, 123);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست‌وجو";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // 
            // operations
            // 
            this.operations.Controls.Add(this.cleanB);
            this.operations.Controls.Add(this.update);
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.selectDate);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(1020, 110);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 642);
            this.operations.TabIndex = 27;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
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
            this.update.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.update.Location = new System.Drawing.Point(18, 147);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 48);
            this.update.TabIndex = 6;
            this.update.Text = "تایید پزشک";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 105);
            this.button5.TabIndex = 5;
            this.button5.Text = "تایید ساعت و ثبت";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectDate
            // 
            this.selectDate.Location = new System.Drawing.Point(18, 69);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(148, 48);
            this.selectDate.TabIndex = 0;
            this.selectDate.Text = "تایید تاریخ";
            this.selectDate.UseVisualStyleBackColor = true;
            this.selectDate.Click += new System.EventHandler(this.submit_Click);
            // 
            // final_hospitalDataSet
            // 
            this.final_hospitalDataSet.DataSetName = "Final_hospitalDataSet";
            this.final_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.final_hospitalDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tCombo);
            this.groupBox1.Controls.Add(this.dCombo);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(56, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 269);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب زمان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "بیمار";
            // 
            // pCombo
            // 
            this.pCombo.FormattingEnabled = true;
            this.pCombo.Location = new System.Drawing.Point(394, 209);
            this.pCombo.Name = "pCombo";
            this.pCombo.Size = new System.Drawing.Size(428, 49);
            this.pCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "ساعت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "پزشک";
            // 
            // tCombo
            // 
            this.tCombo.FormattingEnabled = true;
            this.tCombo.Location = new System.Drawing.Point(394, 131);
            this.tCombo.Name = "tCombo";
            this.tCombo.Size = new System.Drawing.Size(428, 49);
            this.tCombo.TabIndex = 2;
            this.tCombo.SelectedIndexChanged += new System.EventHandler(this.tCombo_SelectedIndexChanged);
            this.tCombo.Click += new System.EventHandler(this.tCombo_Click);
            // 
            // dCombo
            // 
            this.dCombo.FormattingEnabled = true;
            this.dCombo.Location = new System.Drawing.Point(394, 48);
            this.dCombo.Name = "dCombo";
            this.dCombo.Size = new System.Drawing.Size(428, 49);
            this.dCombo.TabIndex = 1;
            this.dCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.dCombo.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // Visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 767);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.groupBox1);
            this.Name = "Visits";
            this.Text = "Visits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button selectDate;
        private Final_hospitalDataSet final_hospitalDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tCombo;
        private System.Windows.Forms.ComboBox dCombo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pCombo;
    }
}