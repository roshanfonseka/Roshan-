namespace WindowsFormsApplication1
{
    partial class Student_Details
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
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label gradePointAvgLabel;
            System.Windows.Forms.Label activeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Details));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gradePointAvgTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.registrationDataGridView = new System.Windows.Forms.DataGridView();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Registration_SystemDataSet = new WindowsFormsApplication1.Student_Registration_SystemDataSet();
            this.registrationTableAdapter = new WindowsFormsApplication1.Student_Registration_SystemDataSetTableAdapters.RegistrationTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Student_Registration_SystemDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            gradePointAvgLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(studentIdLabel);
            this.groupBox1.Controls.Add(this.studentIdTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(dOBLabel);
            this.groupBox1.Controls.Add(this.dOBDateTimePicker);
            this.groupBox1.Controls.Add(gradePointAvgLabel);
            this.groupBox1.Controls.Add(this.gradePointAvgTextBox);
            this.groupBox1.Controls.Add(activeLabel);
            this.groupBox1.Controls.Add(this.activeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Student Details";
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIdLabel.Location = new System.Drawing.Point(23, 35);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(70, 16);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "Student Id:";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "StudentId", true));
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.registrationBindingSource, "StudentId", true));
            this.studentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox.Location = new System.Drawing.Point(168, 32);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(615, 22);
            this.studentIdTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(23, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 16);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.registrationBindingSource, "Name", true));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(168, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(615, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(23, 88);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(40, 16);
            dOBLabel.TabIndex = 4;
            dOBLabel.Text = "DOB:";
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "DOB", true));
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "DOB", true));
            this.dOBDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(168, 84);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(615, 22);
            this.dOBDateTimePicker.TabIndex = 5;
            // 
            // gradePointAvgLabel
            // 
            gradePointAvgLabel.AutoSize = true;
            gradePointAvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradePointAvgLabel.Location = new System.Drawing.Point(23, 113);
            gradePointAvgLabel.Name = "gradePointAvgLabel";
            gradePointAvgLabel.Size = new System.Drawing.Size(109, 16);
            gradePointAvgLabel.TabIndex = 6;
            gradePointAvgLabel.Text = "Grade Point Avg:";
            // 
            // gradePointAvgTextBox
            // 
            this.gradePointAvgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "GradePointAvg", true));
            this.gradePointAvgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.registrationBindingSource, "GradePointAvg", true));
            this.gradePointAvgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradePointAvgTextBox.Location = new System.Drawing.Point(168, 110);
            this.gradePointAvgTextBox.Name = "gradePointAvgTextBox";
            this.gradePointAvgTextBox.Size = new System.Drawing.Size(615, 22);
            this.gradePointAvgTextBox.TabIndex = 7;
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activeLabel.Location = new System.Drawing.Point(23, 141);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(48, 16);
            activeLabel.TabIndex = 8;
            activeLabel.Text = "Active:";
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Active", true));
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.registrationBindingSource, "Active", true));
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckBox.Location = new System.Drawing.Point(168, 136);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(615, 24);
            this.activeCheckBox.TabIndex = 9;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.registrationDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Student Details";
            // 
            // registrationDataGridView
            // 
            this.registrationDataGridView.AutoGenerateColumns = false;
            this.registrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.registrationDataGridView.DataSource = this.registrationBindingSource;
            this.registrationDataGridView.Location = new System.Drawing.Point(6, 16);
            this.registrationDataGridView.Name = "registrationDataGridView";
            this.registrationDataGridView.Size = new System.Drawing.Size(797, 291);
            this.registrationDataGridView.TabIndex = 0;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.student_Registration_SystemDataSet;
            // 
            // student_Registration_SystemDataSet
            // 
            this.student_Registration_SystemDataSet.DataSetName = "Student_Registration_SystemDataSet";
            this.student_Registration_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Registration2TableAdapter = null;
            this.tableAdapterManager.Registration3TableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = this.registrationTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Student_Registration_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GradePointAvg";
            this.dataGridViewTextBoxColumn4.HeaderText = "GradePointAvg";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Active";
            this.dataGridViewTextBoxColumn5.HeaderText = "Active";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(842, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Student_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox gradePointAvgTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Student_Registration_SystemDataSet student_Registration_SystemDataSet;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private Student_Registration_SystemDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private Student_Registration_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView registrationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}