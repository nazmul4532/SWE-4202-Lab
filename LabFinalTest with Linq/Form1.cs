using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LabFinalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<StudentResult> results = new List<StudentResult>();
        
        private void label12_Click(object sender, EventArgs e)
        {

        }
        public double quizSumCalculator(string QuizI, string QuizII, string QuizIII, string QuizIV)
        {
            double quiz1 = Convert.ToDouble(QuizI);
            double quiz2 = Convert.ToDouble(QuizII);
            double quiz3 = Convert.ToDouble(QuizIII);
            double quiz4 = Convert.ToDouble(QuizIV);
            double[] quizMark = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(quizMark);
            double quizTotal = quizMark[1] + quizMark[2] + quizMark[3];
            return quizTotal;
        }
        public double totalMarkCalculator(string AttendMark,double quizTotal,string MidMark,string FinalMark,string VivaMark)
        {
            double attendance = Convert.ToDouble(AttendMark);
            double midMark = Convert.ToDouble(MidMark);
            double finalMark = Convert.ToDouble(FinalMark);
            double vivaMark = Convert.ToDouble(VivaMark);
            double TotalMark = attendance + quizTotal + midMark + finalMark +vivaMark;
            return TotalMark;
        }
        public double percentageCalculator (double totalMark)
        {
            double percentage = (totalMark * 100) / 300;
            return percentage;
        }
        public string GradeCalculator (double result)
        {
            string grade;
            if (result >= 80 && result <= 100)
            { grade = "A+"; }
            else if (result >= 75 && result < 80)
            { grade = "A"; }
            else if (result >= 70 && result < 75)
            { grade = "A-"; }
            else if (result >= 65 && result < 70)
            { grade = "B+"; }
            else if (result >= 60 && result < 65)
            { grade = "B"; }
            else if (result >= 55 && result < 60)
            { grade = "B-"; }
            else if (result >= 50 && result < 55)
            { grade = "C+"; }
            else if (result >= 45 && result < 50)
            { grade = "C"; }
            else if (result >= 40 && result < 45)
            { grade = "D"; }
            else if (result >= 0 && result < 40)
            { grade = "F"; }
            else { grade = "Illegal grade"; }
            
            return grade;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"H:\Visual Studio Lab\LabFinalTest\SWE4201MarkSheet.csv";
            using (var reader = new StreamReader(path))
            {
                InformationDisplayListBox.Items.Add("ID \t\t Name\t\t\tpercentage\tGrade");
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    StudentResult std = new StudentResult();
                    std.studentID = values[0];
                    std.studentName = values[1];
                    if (values[2] != "")
                    {
                        std.studentAttendance = values[2];
                    }
                    if (values[3] != "")
                    {
                        std.studentQuizI = values[3];
                    }
                    if (values[4] != "")
                    {
                        std.studentQuizII = values[4];
                    }
                    if (values[5] != "")
                    {
                        std.studentQuizIII = values[5];
                    }
                    if (values[6] != "")
                    {
                        std.studentQuizIV = values[6];
                    }
                    if (values[7] != "")
                    {
                        std.studentMid = values[7];
                    }
                    if (values[8] != "")
                        std.studentFinal = values[8];
                    if (values[9] != "")
                    {
                        std.studentViva = values[9];
                    }
                    if (std.studentID != "ID")
                    {
                        double quizSum = Math.Round(quizSumCalculator(std.studentQuizI, std.studentQuizII, std.studentQuizIII, std.studentQuizIV), 2);
                        double totalMark = Math.Round(totalMarkCalculator(std.studentAttendance, quizSum, std.studentMid, std.studentFinal, std.studentViva), 2);
                        double percentage = Math.Round(percentageCalculator(totalMark), 2);
                        string grade = GradeCalculator(percentage);

                        std.studentTotal = Convert.ToString(totalMark);
                        std.studentQuizTotal = Convert.ToString(quizSum);
                        std.studentPercentage = Convert.ToString(percentage);
                        std.studentGrade = grade;

                        results.Add(std);


                        InformationDisplayListBox.Items.Add(std.studentID + "\t" + std.studentName + "\t\t" + std.studentPercentage + "%" + "\t\t" + std.studentGrade);
                    }
                    }
                }
        }

        private void SearchByIDButton_Click(object sender, EventArgs e)
        {
            string searchID = SearchIDTextBox.Text;
            /*   bool flag = false;
               foreach(StudentResult std in results)
               {
                   if(searchID == std.studentID)
                   {
                       flag = true;
                       AttendanceMarkLabel.Text = std.studentAttendance;
                       QuizIMarkLabel.Text = std.studentQuizI;
                       QuizIIMarkLabel.Text = std.studentQuizII;
                       QuizIIIMarkLabel.Text = std.studentQuizIII;
                       QuizIVMarkLabel.Text = std.studentQuizIV;
                       QuizBestThreeSum.Text = std.studentQuizTotal;
                       MidMarkLabel.Text = std.studentMid;
                       FinalMarkLabel.Text = std.studentFinal;
                       VivaMarkLabel.Text = std.studentViva;
                       TotalMarkLabel.Text = std.studentTotal;
                       PercentageMarkLabel.Text = std.studentPercentage +"%";
                       GradeLabel.Text = std.studentGrade;
                       MessageBox.Show("Student Has been Found");
                   }
               }
               if(flag == false)
               {
                   MessageBox.Show("Student Can't be Found");
               }*/
            bool flag = false;
            var List = from std in results 
                       where std.studentID == searchID 
                       select std;
            foreach(var std in List)
            {
                AttendanceMarkLabel.Text = std.studentAttendance;
                QuizIMarkLabel.Text = std.studentQuizI;
                QuizIIMarkLabel.Text = std.studentQuizII;
                QuizIIIMarkLabel.Text = std.studentQuizIII;
                QuizIVMarkLabel.Text = std.studentQuizIV;
                QuizBestThreeSum.Text = std.studentQuizTotal;
                MidMarkLabel.Text = std.studentMid;
                FinalMarkLabel.Text = std.studentFinal;
                VivaMarkLabel.Text = std.studentViva;
                TotalMarkLabel.Text = std.studentTotal;
                PercentageMarkLabel.Text = std.studentPercentage + "%";
                GradeLabel.Text = std.studentGrade;
                flag = true;
                MessageBox.Show("Student Info has been Updated");
            }
            if(flag==false)
            {
                MessageBox.Show("Student ID is not found in the Database");
                return;
            }

        }
    }
}
