using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Course_Management_System
{
    internal class Students
    {
        public string Name;
        public string Semester;
        public string CourseName;

        public Students ( string Name, string Semester, string CourseName)
        {
            this.Name = Name;
            this.Semester = Semester;
            this.CourseName = CourseName;
        }
    }
}
