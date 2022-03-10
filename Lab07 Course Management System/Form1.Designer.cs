namespace Lab07_Course_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.TeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.TeacherTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CourseCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CourseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CourseTitleTextBox = new System.Windows.Forms.TextBox();
            this.CourseSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.CourseTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.StudentCourseComboBox = new System.Windows.Forms.ComboBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.stdListBox = new System.Windows.Forms.ListBox();
            this.teachListBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.StudentSearchComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherSearchComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course Code ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teacher Type";
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Location = new System.Drawing.Point(172, 142);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.AddTeacherButton.TabIndex = 7;
            this.AddTeacherButton.Text = "Add Teacher";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // TeacherNameTextBox
            // 
            this.TeacherNameTextBox.Location = new System.Drawing.Point(147, 61);
            this.TeacherNameTextBox.Name = "TeacherNameTextBox";
            this.TeacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TeacherNameTextBox.TabIndex = 8;
            // 
            // TeacherTypeComboBox
            // 
            this.TeacherTypeComboBox.FormattingEnabled = true;
            this.TeacherTypeComboBox.Items.AddRange(new object[] {
            "Theory",
            "Lab"});
            this.TeacherTypeComboBox.Location = new System.Drawing.Point(147, 96);
            this.TeacherTypeComboBox.Name = "TeacherTypeComboBox";
            this.TeacherTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.TeacherTypeComboBox.TabIndex = 10;
            // 
            // CourseCodeTextBox
            // 
            this.CourseCodeTextBox.Location = new System.Drawing.Point(385, 61);
            this.CourseCodeTextBox.Name = "CourseCodeTextBox";
            this.CourseCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CourseCodeTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Course Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Course Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Semester";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Teacher";
            // 
            // CourseTypeComboBox
            // 
            this.CourseTypeComboBox.FormattingEnabled = true;
            this.CourseTypeComboBox.Items.AddRange(new object[] {
            "Theory",
            "Lab"});
            this.CourseTypeComboBox.Location = new System.Drawing.Point(385, 96);
            this.CourseTypeComboBox.Name = "CourseTypeComboBox";
            this.CourseTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.CourseTypeComboBox.TabIndex = 17;
            this.CourseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseTypeComboBox_SelectedIndexChanged);
            // 
            // CourseTitleTextBox
            // 
            this.CourseTitleTextBox.Location = new System.Drawing.Point(385, 135);
            this.CourseTitleTextBox.Name = "CourseTitleTextBox";
            this.CourseTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.CourseTitleTextBox.TabIndex = 18;
            // 
            // CourseSemesterComboBox
            // 
            this.CourseSemesterComboBox.FormattingEnabled = true;
            this.CourseSemesterComboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eigth"});
            this.CourseSemesterComboBox.Location = new System.Drawing.Point(385, 172);
            this.CourseSemesterComboBox.Name = "CourseSemesterComboBox";
            this.CourseSemesterComboBox.Size = new System.Drawing.Size(100, 21);
            this.CourseSemesterComboBox.TabIndex = 19;
            // 
            // CourseTeacherComboBox
            // 
            this.CourseTeacherComboBox.FormattingEnabled = true;
            this.CourseTeacherComboBox.Location = new System.Drawing.Point(385, 204);
            this.CourseTeacherComboBox.Name = "CourseTeacherComboBox";
            this.CourseTeacherComboBox.Size = new System.Drawing.Size(100, 21);
            this.CourseTeacherComboBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Semester";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(526, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Course";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(591, 61);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StudentNameTextBox.TabIndex = 23;
            // 
            // StudentSemesterComboBox
            // 
            this.StudentSemesterComboBox.FormattingEnabled = true;
            this.StudentSemesterComboBox.Location = new System.Drawing.Point(591, 96);
            this.StudentSemesterComboBox.Name = "StudentSemesterComboBox";
            this.StudentSemesterComboBox.Size = new System.Drawing.Size(100, 21);
            this.StudentSemesterComboBox.TabIndex = 24;
            this.StudentSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentSemesterComboBox_SelectedIndexChanged);
            // 
            // StudentCourseComboBox
            // 
            this.StudentCourseComboBox.FormattingEnabled = true;
            this.StudentCourseComboBox.Location = new System.Drawing.Point(591, 130);
            this.StudentCourseComboBox.Name = "StudentCourseComboBox";
            this.StudentCourseComboBox.Size = new System.Drawing.Size(100, 21);
            this.StudentCourseComboBox.TabIndex = 25;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(410, 231);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 26;
            this.AddCourseButton.Text = "Add Teacher";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(616, 165);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentButton.TabIndex = 27;
            this.AddStudentButton.Text = "Add Teacher";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // stdListBox
            // 
            this.stdListBox.FormattingEnabled = true;
            this.stdListBox.Location = new System.Drawing.Point(59, 277);
            this.stdListBox.Name = "stdListBox";
            this.stdListBox.Size = new System.Drawing.Size(228, 147);
            this.stdListBox.TabIndex = 28;
            // 
            // teachListBox
            // 
            this.teachListBox.FormattingEnabled = true;
            this.teachListBox.Location = new System.Drawing.Point(529, 277);
            this.teachListBox.Name = "teachListBox";
            this.teachListBox.Size = new System.Drawing.Size(222, 147);
            this.teachListBox.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Show Student Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(635, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StudentSearchComboBox
            // 
            this.StudentSearchComboBox.FormattingEnabled = true;
            this.StudentSearchComboBox.Location = new System.Drawing.Point(59, 429);
            this.StudentSearchComboBox.Name = "StudentSearchComboBox";
            this.StudentSearchComboBox.Size = new System.Drawing.Size(100, 21);
            this.StudentSearchComboBox.TabIndex = 33;
            // 
            // TeacherSearchComboBox
            // 
            this.TeacherSearchComboBox.FormattingEnabled = true;
            this.TeacherSearchComboBox.Location = new System.Drawing.Point(529, 429);
            this.TeacherSearchComboBox.Name = "TeacherSearchComboBox";
            this.TeacherSearchComboBox.Size = new System.Drawing.Size(100, 21);
            this.TeacherSearchComboBox.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.TeacherSearchComboBox);
            this.Controls.Add(this.StudentSearchComboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.teachListBox);
            this.Controls.Add(this.stdListBox);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.StudentCourseComboBox);
            this.Controls.Add(this.StudentSemesterComboBox);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CourseTeacherComboBox);
            this.Controls.Add(this.CourseSemesterComboBox);
            this.Controls.Add(this.CourseTitleTextBox);
            this.Controls.Add(this.CourseTypeComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CourseCodeTextBox);
            this.Controls.Add(this.TeacherTypeComboBox);
            this.Controls.Add(this.TeacherNameTextBox);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Course Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.TextBox TeacherNameTextBox;
        private System.Windows.Forms.ComboBox TeacherTypeComboBox;
        private System.Windows.Forms.TextBox CourseCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CourseTypeComboBox;
        private System.Windows.Forms.TextBox CourseTitleTextBox;
        private System.Windows.Forms.ComboBox CourseSemesterComboBox;
        private System.Windows.Forms.ComboBox CourseTeacherComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.ComboBox StudentSemesterComboBox;
        private System.Windows.Forms.ComboBox StudentCourseComboBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.ListBox stdListBox;
        private System.Windows.Forms.ListBox teachListBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox StudentSearchComboBox;
        private System.Windows.Forms.ComboBox TeacherSearchComboBox;
    }
}

