using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOfDoomOrGlory_Click(object sender, EventArgs e)
        {
            if (atttendClass.Text == "" || midMark.Text == "" || finalMark.Text == "" || quizOne.Text == "" || quizTwo.Text == "" || quizThree.Text == "" || quizFour.Text == "")
            {
                MessageBox.Show("Some of the Marks are Missing");
                return;
            }
            if (studentName.Text == "" || studentSemester.Text == "" || studentID.Text == "")
            {
                MessageBox.Show("Some of the Student Information is Missing");
                return;
            }
            double attendanceInput = Convert.ToDouble(atttendClass.Text);
            double midInput = Convert.ToDouble(midMark.Text);
            double finalInput = Convert.ToDouble(finalMark.Text);
            double quizOneInput = Convert.ToDouble(quizOne.Text);
            double quizTwoInput = Convert.ToDouble(quizTwo.Text);
            double quizThreeInput = Convert.ToDouble(quizThree.Text);
            double quizFourInput = Convert.ToDouble(quizFour.Text);
            double[] quizMark = { quizOneInput, quizTwoInput, quizThreeInput, quizFourInput };
            Array.Sort(quizMark);
            double quizTotal = quizMark[1] + quizMark[2] + quizMark[3];
            double attendMark = Math.Round(attendanceInput * 30.0 / 28.0,0,MidpointRounding.AwayFromZero);
            double totalMark = attendMark + midInput + finalInput + quizTotal;
            
            attendOutput.Text = attendMark.ToString()+"/30";
            midOutput.Text = midMark.Text+"/75";
            quizOutput.Text = quizTotal.ToString()+"/45";
            finalOutput.Text = finalMark.Text+"/150";
            double result = Math.Round(totalMark * 100 / 300, 0, MidpointRounding.AwayFromZero);
            string grade;
            if (result>=80 && result <=100)
            { grade = "A+"; }
            else if (result >= 75 && result <= 79)
            { grade = "A"; }
            else if(result >= 70 && result <= 74)
            { grade = "A-"; }
            else if(result >= 65 && result <= 69)
            { grade = "B+"; }
            else if(result >= 60 && result <= 64)
            { grade = "B"; }
            else if(result >= 55 && result <= 59)
            { grade = "B-"; }
            else if(result >= 50 && result <= 54)
            { grade = "C+"; }
            else if(result >= 45 && result <= 49)
            { grade = "C"; }
            else if(result >= 40 && result <= 44)
            { grade = "D"; }
            else if(result >= 0 && result <= 39)
            { grade = "F"; }
            else { grade = "Illegal grade"; }
            gradeOutput.Text = grade;
            studentOutput.Text = studentName.Text +" has obtained "+Convert.ToString(result)+ "% marks.";
            totalOutput.Text = Convert.ToString(totalMark) + "/300";
        }

        private void midMark_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
