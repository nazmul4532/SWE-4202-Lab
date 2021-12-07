namespace Employee
{
    partial class Form1
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
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.clearStudentButton = new System.Windows.Forms.Button();
            this.showStudentButton = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.teacherDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showTeacherButton = new System.Windows.Forms.Button();
            this.clearTeacherButton = new System.Windows.Forms.Button();
            this.saveTeacherButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.teacherSalaryTextBox = new System.Windows.Forms.TextBox();
            this.teacherDesignationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.studentSemesterTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(20, 49);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID";
            this.Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(89, 46);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIdTextBox.TabIndex = 3;
            this.studentIdTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(89, 73);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 4;
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // studentDepartmentTextBox
            // 
            this.studentDepartmentTextBox.Location = new System.Drawing.Point(89, 102);
            this.studentDepartmentTextBox.Name = "studentDepartmentTextBox";
            this.studentDepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentDepartmentTextBox.TabIndex = 5;
            this.studentDepartmentTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Location = new System.Drawing.Point(23, 385);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(75, 23);
            this.saveStudentButton.TabIndex = 6;
            this.saveStudentButton.Text = "Save";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveOnClick);
            // 
            // clearStudentButton
            // 
            this.clearStudentButton.Location = new System.Drawing.Point(114, 385);
            this.clearStudentButton.Name = "clearStudentButton";
            this.clearStudentButton.Size = new System.Drawing.Size(75, 23);
            this.clearStudentButton.TabIndex = 7;
            this.clearStudentButton.Text = "Clear";
            this.clearStudentButton.UseVisualStyleBackColor = true;
            this.clearStudentButton.Click += new System.EventHandler(this.clearOnClick);
            // 
            // showStudentButton
            // 
            this.showStudentButton.Location = new System.Drawing.Point(256, 385);
            this.showStudentButton.Name = "showStudentButton";
            this.showStudentButton.Size = new System.Drawing.Size(75, 23);
            this.showStudentButton.TabIndex = 8;
            this.showStudentButton.Text = "Show";
            this.showStudentButton.UseVisualStyleBackColor = true;
            this.showStudentButton.Click += new System.EventHandler(this.showStudentOnClick);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(210, 26);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(177, 134);
            this.studentListBox.TabIndex = 9;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(487, 70);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameTextBox.TabIndex = 14;
            this.teacherNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.Location = new System.Drawing.Point(487, 43);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherIdTextBox.TabIndex = 13;
            this.teacherIdTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Location = new System.Drawing.Point(609, 26);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(173, 134);
            this.teacherListBox.TabIndex = 16;
            this.teacherListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // teacherDepartmentTextBox
            // 
            this.teacherDepartmentTextBox.Location = new System.Drawing.Point(487, 99);
            this.teacherDepartmentTextBox.Name = "teacherDepartmentTextBox";
            this.teacherDepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherDepartmentTextBox.TabIndex = 15;
            this.teacherDepartmentTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Student";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // showTeacherButton
            // 
            this.showTeacherButton.Location = new System.Drawing.Point(654, 385);
            this.showTeacherButton.Name = "showTeacherButton";
            this.showTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.showTeacherButton.TabIndex = 21;
            this.showTeacherButton.Text = "Show";
            this.showTeacherButton.UseVisualStyleBackColor = true;
            this.showTeacherButton.Click += new System.EventHandler(this.showTeacherButton_Click);
            // 
            // clearTeacherButton
            // 
            this.clearTeacherButton.Location = new System.Drawing.Point(512, 385);
            this.clearTeacherButton.Name = "clearTeacherButton";
            this.clearTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.clearTeacherButton.TabIndex = 20;
            this.clearTeacherButton.Text = "Clear";
            this.clearTeacherButton.UseVisualStyleBackColor = true;
            this.clearTeacherButton.Click += new System.EventHandler(this.clearTeacherButton_Click);
            // 
            // saveTeacherButton
            // 
            this.saveTeacherButton.Location = new System.Drawing.Point(421, 385);
            this.saveTeacherButton.Name = "saveTeacherButton";
            this.saveTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.saveTeacherButton.TabIndex = 19;
            this.saveTeacherButton.Text = "Save";
            this.saveTeacherButton.UseVisualStyleBackColor = true;
            this.saveTeacherButton.Click += new System.EventHandler(this.saveTeacherButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(393, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 407);
            this.button5.TabIndex = 22;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // teacherSalaryTextBox
            // 
            this.teacherSalaryTextBox.Location = new System.Drawing.Point(487, 159);
            this.teacherSalaryTextBox.Name = "teacherSalaryTextBox";
            this.teacherSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherSalaryTextBox.TabIndex = 26;
            this.teacherSalaryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // teacherDesignationTextBox
            // 
            this.teacherDesignationTextBox.Location = new System.Drawing.Point(487, 127);
            this.teacherDesignationTextBox.Name = "teacherDesignationTextBox";
            this.teacherDesignationTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherDesignationTextBox.TabIndex = 25;
            this.teacherDesignationTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salary";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Designation";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // studentSemesterTextBox
            // 
            this.studentSemesterTextBox.Location = new System.Drawing.Point(89, 130);
            this.studentSemesterTextBox.Name = "studentSemesterTextBox";
            this.studentSemesterTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentSemesterTextBox.TabIndex = 27;
            this.studentSemesterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Semester";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentSemesterTextBox);
            this.Controls.Add(this.teacherSalaryTextBox);
            this.Controls.Add(this.teacherDesignationTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.showTeacherButton);
            this.Controls.Add(this.clearTeacherButton);
            this.Controls.Add(this.saveTeacherButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.teacherDepartmentTextBox);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.teacherIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.showStudentButton);
            this.Controls.Add(this.clearStudentButton);
            this.Controls.Add(this.studentDepartmentTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.saveStudentButton);
            this.Name = "Form1";
            this.Text = "University Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentDepartmentTextBox;
        private System.Windows.Forms.Button saveStudentButton;
        private System.Windows.Forms.Button clearStudentButton;
        private System.Windows.Forms.Button showStudentButton;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.TextBox teacherDepartmentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showTeacherButton;
        private System.Windows.Forms.Button clearTeacherButton;
        private System.Windows.Forms.Button saveTeacherButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox teacherSalaryTextBox;
        private System.Windows.Forms.TextBox teacherDesignationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox studentSemesterTextBox;
        private System.Windows.Forms.Label label10;
    }
}

