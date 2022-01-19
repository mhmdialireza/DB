
namespace DataBase_project
{
    partial class SetDoctorsShift
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.patientsTableAdapter = new DataBase_project.Final_hospitalDataSetTableAdapters.patientsTableAdapter();
            this.operations = new System.Windows.Forms.GroupBox();
            this.cleanB = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.selectDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.final_hospitalDataSet = new DataBase_project.Final_hospitalDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(12, 289);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(948, 383);
            this.dataGridView.TabIndex = 33;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // operations
            // 
            this.operations.Controls.Add(this.cleanB);
            this.operations.Controls.Add(this.update);
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.selectDate);
            this.operations.Font = new System.Drawing.Font("IRAN Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.operations.Location = new System.Drawing.Point(986, 77);
            this.operations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operations.Size = new System.Drawing.Size(183, 597);
            this.operations.TabIndex = 31;
            this.operations.TabStop = false;
            this.operations.Text = "عملیات ها";
            // 
            // cleanB
            // 
            this.cleanB.Location = new System.Drawing.Point(18, 517);
            this.cleanB.Name = "cleanB";
            this.cleanB.Size = new System.Drawing.Size(148, 48);
            this.cleanB.TabIndex = 7;
            this.cleanB.Text = "پاک کردن";
            this.cleanB.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.update.Location = new System.Drawing.Point(18, 147);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 48);
            this.update.TabIndex = 6;
            this.update.Text = "تایید روز";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 105);
            this.button5.TabIndex = 5;
            this.button5.Text = "تایید شیفت و ثبت";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // selectDate
            // 
            this.selectDate.Location = new System.Drawing.Point(18, 69);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(148, 48);
            this.selectDate.TabIndex = 0;
            this.selectDate.Text = "تایید پزشک";
            this.selectDate.UseVisualStyleBackColor = true;
            this.selectDate.Click += new System.EventHandler(this.selectDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "پزشک";
            // 
            // dCombo
            // 
            this.dCombo.FormattingEnabled = true;
            this.dCombo.Location = new System.Drawing.Point(167, 48);
            this.dCombo.Name = "dCombo";
            this.dCombo.Size = new System.Drawing.Size(428, 49);
            this.dCombo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dCombo);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(948, 269);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب زمان";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "روز";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(428, 49);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "شیفت";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(428, 49);
            this.comboBox2.TabIndex = 6;
            // 
            // SetDoctorsShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 687);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetDoctorsShift";
            this.Text = "SetDoctorsShift";
            this.Load += new System.EventHandler(this.SetDoctorsShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.operations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final_hospitalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Timer timer1;
        private Final_hospitalDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.Button cleanB;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button selectDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Final_hospitalDataSet final_hospitalDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}