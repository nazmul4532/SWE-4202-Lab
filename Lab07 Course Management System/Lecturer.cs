using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Course_Management_System
{
    internal class Lecturer : Teachers
    {
        public Lecturer(string Name,string Type)
        {
            this.Name = Name;
            this.Type = Type;
            this.Credit = 0;
        }
        public override double getCredit()
        {
            return this.Credit + 1.5;
        }
    }
}
