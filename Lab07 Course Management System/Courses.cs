using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Course_Management_System
{
    internal class Courses
    {
        public string Code;
        public string Title;
        public string Type;
        public string Semester;

        public Courses (string Code, string Title, string Type, string Semester)
        {
            this.Code = Code;
            this.Title = Title;
            this.Type = Type;
            this.Semester = Semester;
        }
    }
}
