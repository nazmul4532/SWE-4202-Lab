using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Teacher
    {
        private int teacherId;
        private string teacherName;
        private string teacherDepartment;
        private string teacherDesignation;
        private int teacherSalary;
        public string getTeacherInfo()
        {
            string teacherInfo = teacherId.ToString() + "\t" + teacherName + "\t" + teacherDepartment + "\t" + teacherDesignation + "\t" + teacherSalary.ToString();
            return teacherInfo;
        }
        public void setID(int teacherId)
        { this.teacherId = teacherId; }

        public void setName(string teacherName)
        { this.teacherName = teacherName; }
        public void setDepartment(string teacherDepartment)
        { this.teacherDepartment = teacherDepartment; }

        public void setDesignation(string teacherDesignation)
        { this.teacherDesignation = teacherDesignation; }

        public void setSalary(int teacherSalary)
        { this.teacherSalary = teacherSalary; }

    }
}
