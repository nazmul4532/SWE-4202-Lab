using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Course_Management_System
{
    internal class Teachers
    {
        public string Name;
        public string Type;
        public List<Courses> course = new List<Courses>();
        public double Credit = 0;
        public virtual double getCredit()
        {
            return -1;
        }
    }
}
