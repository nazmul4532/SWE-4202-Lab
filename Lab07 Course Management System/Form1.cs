using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Course_Management_System
{
    public partial class Form1 : Form
    {
        Course_Management_System main_system = new Course_Management_System();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            string TeacherName = TeacherNameTextBox.Text;
            string TeacherType = TeacherTypeComboBox.Text;
            bool flag = false;
            foreach(Professor prof in main_system.profs)
            {
                if(TeacherName== prof.Name && prof.Type == TeacherType)
                {
                    flag = true;
                }
            }
            foreach(Lecturer lect in main_system.lects)
            {
                if( lect.Type == TeacherType && TeacherName == lect.Name)
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                if (TeacherType == "Lab")
                {
                    Lecturer dummy = new Lecturer(TeacherName, TeacherType);
                    main_system.lects.Add(dummy);
                    TeacherSearchComboBox.Items.Add(dummy.Name);
                    
                    MessageBox.Show("Lecturer has been created successfully!");
                }
                else if (TeacherType == "Theory")
                {
                    Professor dummy = new Professor(TeacherName, TeacherType);
                    main_system.profs.Add(dummy);
                    TeacherSearchComboBox.Items.Add(dummy.Name);
                    
                    MessageBox.Show("Professor has been created successfully!");
                }
                else
                {
                    MessageBox.Show("Select a Teacher Type!");
                }
            }
            if(flag == true)
            {
                MessageBox.Show("Teacher already exists in the Database!");
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            string CourseCode = CourseCodeTextBox.Text;
            string CourseTitle = CourseTitleTextBox.Text;
            string CourseType = CourseTypeComboBox.Text;
            string CourseSemester = CourseSemesterComboBox.Text;
            string TeacherName = CourseTeacherComboBox.Text;
            bool flag = false;
            if (CourseType == "Lab")
            {
                foreach (Lecturer lect in main_system.lects)
                {
                    if (TeacherName == lect.Name)
                    {
                        flag = true;
                        lect.Credit = lect.getCredit();
                        Courses dumCourse = new Courses(CourseCode, CourseTitle, CourseType, CourseSemester);
                        lect.course.Add(dumCourse);
                    }
                }
            }
            if (CourseType == "Theory")
            {
                foreach (Professor prof in main_system.profs)
                {
                    if (TeacherName == prof.Name)
                    {
                        flag = true;
                       prof.Credit = prof.getCredit();
                       Courses dumCourse = new Courses(CourseCode, CourseTitle, CourseType, CourseSemester);
                       prof.course.Add(dumCourse);
                    }
                }
            }
            if (CourseType == "Lab" && flag == false)
            {
                MessageBox.Show("Teacher is not found in the Database or Course Type doesn't match!");
            }
            if (CourseType == "Theory" && flag == false)
            {
                MessageBox.Show("Teacher is not found in the Database or Course Type doesn't match!");
            }
            if (flag == true)
            {
                Courses dumCourse = new Courses(CourseCode,CourseTitle,CourseType,CourseSemester);
                main_system.courses.Add(dumCourse);
                //StudentCourseComboBox.Items.Clear();
                bool flagcourse = false;
                bool flagsem = false;
                foreach(Courses course in main_system.courses)
                {
                    foreach (String name in StudentCourseComboBox.Items)
                    {
                        if(name == dumCourse.Title)
                            flagcourse = true;
                    }
                }
                if (flagcourse == false)
                {
                    StudentCourseComboBox.Items.Add(dumCourse.Title);
                }
                //StudentSemesterComboBox.Items.Clear();
                foreach( Courses course in main_system.courses)
                {
                    foreach(String name in StudentSemesterComboBox.Items)
                    {
                        if( name == dumCourse.Semester)
                            flagsem = true;
                    }
                }
                if (flagsem == false)
                {
                    StudentSemesterComboBox.Items.Add(dumCourse.Semester);
                }
                MessageBox.Show("Course has been successfully Added!");
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string stdName = StudentNameTextBox.Text;
            string stdCourse = StudentCourseComboBox.Text;
            string stdSemester = StudentSemesterComboBox.Text;
            bool flag = false;

            foreach(Courses course in main_system.courses)
            {
                if(stdCourse==course.Title)
                {
                    if(stdSemester==course.Semester)
                    {
                        flag = true;
                        bool namflag = false;
                        Students dum = new Students(stdName,stdSemester,stdCourse);
                        main_system.stdnts.Add(dum);
                        foreach(string name in StudentSearchComboBox.Items)
                        {
                            if(name == dum.Name)
                            {
                                namflag = true;
                            }
                        }
                        if (namflag == false)
                        {
                            StudentSearchComboBox.Items.Add(dum.Name);
                        }
                            MessageBox.Show("Student has enrolled Successfully");
                    }
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Course Title Not found or Course and Student Semester don't match!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string stdName = StudentSearchComboBox.Text;
            stdListBox.Items.Clear();
            foreach(Students std in main_system.stdnts)
            {
                if( std.Name == stdName)
                {
                    flag = true;
                    string stdInfo = std.Name + "  " + std.Semester + "  " + std.CourseName;
                    stdListBox.Items.Add((stdInfo));
                    MessageBox.Show("Student Information has been updated");
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Student is not found in the database!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string teachName = TeacherSearchComboBox.Text;
            bool flag = false;
            teachListBox.Items.Clear();
            foreach(Lecturer lect in main_system.lects)
            {
                if(lect.Name == teachName)
                {
                    flag=true;
                    string lectInfo = lect.Name + "  " + lect.Type + "  " + Convert.ToString(lect.Credit);
                    teachListBox.Items.Add((lectInfo));
                    foreach (Courses cour in lect.course)
                    {
                        string courseInfo = cour.Code + "  " + cour.Type + "  " + cour.Title + "  " + cour.Semester + "\n";
                        teachListBox.Items.Add((courseInfo));
                    }
                }
            }
            foreach(Professor prof in main_system.profs)
            {
                if (prof.Name == teachName)
                {
                    flag = true;
                    string profinfo = prof.Name + " " + prof.Type + " " + Convert.ToString(prof.Credit);
                    teachListBox.Items.Add(profinfo);
                    foreach (Courses cour in prof.course)
                    {
                        string courseInfo = cour.Code + "  " + cour.Type + "  " + cour.Title + "  " + cour.Semester + "\n";
                        teachListBox.Items.Add((courseInfo));
                    }
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Teacher Information has been updated!");
            }
        }

        private void CourseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseTeacherComboBox.Items.Clear ();
            if(CourseTypeComboBox.Text == "Lab")
            {
                foreach (Lecturer lect in main_system.lects)
                {
                    CourseTeacherComboBox.Items.Add (lect.Name);
                }
            }
            if(CourseTypeComboBox.Text == "Theory")
            {
                foreach (Professor prof in main_system.profs)
                {
                    CourseTeacherComboBox.Items.Add (prof.Name);
                }
            }
        }

        private void StudentSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
