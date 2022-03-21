namespace Grades
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.TextBox();
            this.studentSemester = new System.Windows.Forms.TextBox();
            this.atttendClass = new System.Windows.Forms.TextBox();
            this.midMark = new System.Windows.Forms.TextBox();
            this.finalMark = new System.Windows.Forms.TextBox();
            this.quizOne = new System.Windows.Forms.TextBox();
            this.quizTwo = new System.Windows.Forms.TextBox();
            this.quizThree = new System.Windows.Forms.TextBox();
            this.quizFour = new System.Windows.Forms.TextBox();
            this.buttonOfDoomOrGlory = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.attendOutput = new System.Windows.Forms.Label();
            this.midOutput = new System.Windows.Forms.Label();
            this.quizOutput = new System.Windows.Forms.Label();
            this.finalOutput = new System.Windows.Forms.Label();
            this.gradeOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.studentOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "SWE 4201 OOC - I Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. of atended";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mid (Out of 75)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final (Out of 150)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quiz I (Out of 15)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quiz II (Out of 15)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Quiz III (Out of 15)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 303);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Quiz IV (Out of 15)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 126);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Quiz:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "Obtained Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(360, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Attendance:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(394, 102);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Mid:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(389, 150);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Final:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(380, 184);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(365, 222);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "Grade:";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(68, 72);
            this.studentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(76, 20);
            this.studentName.TabIndex = 19;
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(68, 99);
            this.studentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(76, 20);
            this.studentID.TabIndex = 20;
            // 
            // studentSemester
            // 
            this.studentSemester.Location = new System.Drawing.Point(68, 126);
            this.studentSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentSemester.Name = "studentSemester";
            this.studentSemester.Size = new System.Drawing.Size(76, 20);
            this.studentSemester.TabIndex = 21;
            // 
            // atttendClass
            // 
            this.atttendClass.Location = new System.Drawing.Point(107, 219);
            this.atttendClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.atttendClass.Name = "atttendClass";
            this.atttendClass.Size = new System.Drawing.Size(76, 20);
            this.atttendClass.TabIndex = 22;
            this.atttendClass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // midMark
            // 
            this.midMark.Location = new System.Drawing.Point(107, 246);
            this.midMark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.midMark.Name = "midMark";
            this.midMark.Size = new System.Drawing.Size(76, 20);
            this.midMark.TabIndex = 23;
            this.midMark.TextChanged += new System.EventHandler(this.midMark_TextChanged);
            // 
            // finalMark
            // 
            this.finalMark.Location = new System.Drawing.Point(107, 273);
            this.finalMark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finalMark.Name = "finalMark";
            this.finalMark.Size = new System.Drawing.Size(76, 20);
            this.finalMark.TabIndex = 24;
            // 
            // quizOne
            // 
            this.quizOne.Location = new System.Drawing.Point(274, 221);
            this.quizOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizOne.Name = "quizOne";
            this.quizOne.Size = new System.Drawing.Size(76, 20);
            this.quizOne.TabIndex = 25;
            // 
            // quizTwo
            // 
            this.quizTwo.Location = new System.Drawing.Point(274, 249);
            this.quizTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizTwo.Name = "quizTwo";
            this.quizTwo.Size = new System.Drawing.Size(76, 20);
            this.quizTwo.TabIndex = 26;
            // 
            // quizThree
            // 
            this.quizThree.Location = new System.Drawing.Point(274, 275);
            this.quizThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizThree.Name = "quizThree";
            this.quizThree.Size = new System.Drawing.Size(76, 20);
            this.quizThree.TabIndex = 27;
            // 
            // quizFour
            // 
            this.quizFour.Location = new System.Drawing.Point(274, 298);
            this.quizFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizFour.Name = "quizFour";
            this.quizFour.Size = new System.Drawing.Size(76, 20);
            this.quizFour.TabIndex = 28;
            // 
            // buttonOfDoomOrGlory
            // 
            this.buttonOfDoomOrGlory.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOfDoomOrGlory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfDoomOrGlory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOfDoomOrGlory.Location = new System.Drawing.Point(232, 63);
            this.buttonOfDoomOrGlory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOfDoomOrGlory.Name = "buttonOfDoomOrGlory";
            this.buttonOfDoomOrGlory.Size = new System.Drawing.Size(110, 80);
            this.buttonOfDoomOrGlory.TabIndex = 29;
            this.buttonOfDoomOrGlory.Text = "Calculate Grade";
            this.buttonOfDoomOrGlory.UseVisualStyleBackColor = false;
            this.buttonOfDoomOrGlory.Click += new System.EventHandler(this.buttonOfDoomOrGlory_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 226);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "classes (Out of 28)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(353, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 280);
            this.button3.TabIndex = 32;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(368, 165);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 8);
            this.button4.TabIndex = 33;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // attendOutput
            // 
            this.attendOutput.AutoSize = true;
            this.attendOutput.Location = new System.Drawing.Point(429, 74);
            this.attendOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attendOutput.Name = "attendOutput";
            this.attendOutput.Size = new System.Drawing.Size(0, 13);
            this.attendOutput.TabIndex = 34;
            // 
            // midOutput
            // 
            this.midOutput.AutoSize = true;
            this.midOutput.Location = new System.Drawing.Point(429, 102);
            this.midOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.midOutput.Name = "midOutput";
            this.midOutput.Size = new System.Drawing.Size(0, 13);
            this.midOutput.TabIndex = 36;
            // 
            // quizOutput
            // 
            this.quizOutput.AutoSize = true;
            this.quizOutput.Location = new System.Drawing.Point(429, 126);
            this.quizOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizOutput.Name = "quizOutput";
            this.quizOutput.Size = new System.Drawing.Size(0, 13);
            this.quizOutput.TabIndex = 37;
            // 
            // finalOutput
            // 
            this.finalOutput.AutoSize = true;
            this.finalOutput.Location = new System.Drawing.Point(429, 150);
            this.finalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finalOutput.Name = "finalOutput";
            this.finalOutput.Size = new System.Drawing.Size(0, 13);
            this.finalOutput.TabIndex = 38;
            // 
            // gradeOutput
            // 
            this.gradeOutput.AutoSize = true;
            this.gradeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeOutput.ForeColor = System.Drawing.Color.Red;
            this.gradeOutput.Location = new System.Drawing.Point(423, 223);
            this.gradeOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gradeOutput.Name = "gradeOutput";
            this.gradeOutput.Size = new System.Drawing.Size(0, 17);
            this.gradeOutput.TabIndex = 39;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(429, 186);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 15);
            this.totalOutput.TabIndex = 40;
            // 
            // studentOutput
            // 
            this.studentOutput.AutoSize = true;
            this.studentOutput.Location = new System.Drawing.Point(382, 275);
            this.studentOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentOutput.Name = "studentOutput";
            this.studentOutput.Size = new System.Drawing.Size(0, 13);
            this.studentOutput.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.studentOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.gradeOutput);
            this.Controls.Add(this.finalOutput);
            this.Controls.Add(this.quizOutput);
            this.Controls.Add(this.midOutput);
            this.Controls.Add(this.attendOutput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonOfDoomOrGlory);
            this.Controls.Add(this.quizFour);
            this.Controls.Add(this.quizThree);
            this.Controls.Add(this.quizTwo);
            this.Controls.Add(this.quizOne);
            this.Controls.Add(this.finalMark);
            this.Controls.Add(this.midMark);
            this.Controls.Add(this.atttendClass);
            this.Controls.Add(this.studentSemester);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "GradesApp";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.TextBox studentSemester;
        private System.Windows.Forms.TextBox atttendClass;
        private System.Windows.Forms.TextBox midMark;
        private System.Windows.Forms.TextBox finalMark;
        private System.Windows.Forms.TextBox quizOne;
        private System.Windows.Forms.TextBox quizTwo;
        private System.Windows.Forms.TextBox quizThree;
        private System.Windows.Forms.TextBox quizFour;
        private System.Windows.Forms.Button buttonOfDoomOrGlory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label attendOutput;
        private System.Windows.Forms.Label midOutput;
        private System.Windows.Forms.Label quizOutput;
        private System.Windows.Forms.Label finalOutput;
        private System.Windows.Forms.Label gradeOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label studentOutput;
    }
}

