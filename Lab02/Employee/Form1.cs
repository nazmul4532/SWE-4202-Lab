using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        List<Student> Students = new List<Student>();
        List<Teacher> Teachers = new List<Teacher>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearOnClick(object sender, EventArgs e)
        {
            studentIdTextBox.Text =String.Empty;
            studentDepartmentTextBox.Text = String.Empty;
            studentNameTextBox.Text = String.Empty;
            studentSemesterTextBox.Text = String.Empty;
            
        }

        private void saveOnClick(object sender, EventArgs e)
        {
            int stdId = Convert.ToInt32(studentIdTextBox.Text);
            string stdName = studentNameTextBox.Text;
            string stdDepartment = studentDepartmentTextBox.Text;
            int stdSemester = Convert.ToInt32(studentSemesterTextBox.Text);

            Student dummy_std = new Student(stdId ,stdName, stdDepartment, stdSemester);

            Students.Add(dummy_std);


            MessageBox.Show("Student has been added successfully!");

            studentListBox.Items.Clear();
            for (int i = 0; i < Students.Count; i++)
            {
                studentListBox.Items.Add(Students[i].getStdInfo());
            }

        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void clearTeacherButton_Click(object sender, EventArgs e)
        {
            teacherDepartmentTextBox.Text = String.Empty;
            teacherNameTextBox.Text = String.Empty;
            teacherDesignationTextBox.Text = String.Empty;
            teacherIdTextBox.Text = String.Empty;
            teacherSalaryTextBox.Text = String.Empty; 
        }

        private void showTeacherButton_Click(object sender, EventArgs e)
        {
            teacherListBox.Items.Clear();
            for (int j = 0; j < Teachers.Count; j++)
            {
                teacherListBox.Items.Add(Teachers[j].getTeacherInfo());
            }
        }

        private void showStudentOnClick(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            for (int i = 0;i<Students.Count;i++)
              {
                studentListBox.Items.Add(Students[i].getStdInfo());
              }
        }

        private void saveTeacherButton_Click(object sender, EventArgs e)
        {
            int teachId = Convert.ToInt32(teacherIdTextBox.Text);
            string teachName = teacherNameTextBox.Text;
            string teachDepartment = teacherDepartmentTextBox.Text;
            int teachSalary = Convert.ToInt32(teacherSalaryTextBox.Text);
            string teacherDesignation = teacherDesignationTextBox.Text;


            Teacher dummy_teach = new Teacher();
            dummy_teach.setID(teachId);
            dummy_teach.setName(teachName);
            dummy_teach.setDepartment(teachDepartment);
            dummy_teach.setDesignation(teacherDesignation);
            dummy_teach.setSalary(teachSalary);
            
            

            Teachers.Add(dummy_teach);

            MessageBox.Show("Teacher has been added successfully!");
        }
    }
}
