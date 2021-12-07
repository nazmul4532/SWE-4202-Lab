using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee

{
    internal class Student
    {
        private int studentId;
        private string studentName;
        private string studentDepartment;
        private int studentSemester;
        public string getStdInfo()
        {
            string studentInfo = studentId.ToString() + "\t" + studentName + "\t" + studentDepartment +"\t"+ studentSemester.ToString();
            return studentInfo;
        }

        public Student (int stdID, string stdName, string stdDept, int stdSem)
        {
            this.studentDepartment = stdDept;
            this.studentName = stdName;
            this.studentId = stdID;
            this.studentSemester = stdSem;

        }
    }
}
