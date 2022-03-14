using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Management_with_Exception_Handling
{
    internal class Typewriter : Employee
    {
        public override double getSalary(string Date)
        {
            int days;
            int entryDay;
            int entryMonth;
            int entryYear;
            int currentDay;
            int currentMonth;
            int currentYear;
            entryDay = Convert.ToInt32(employeeDoJ[0]) * 10 + Convert.ToInt32(this.employeeDoJ[1]);
            entryMonth = Convert.ToInt32(employeeDoJ[3]) * 10 + Convert.ToInt32(employeeDoJ[4]);
            entryYear = Convert.ToInt32(employeeDoJ[6]) * 10 + Convert.ToInt32(employeeDoJ[7]);
            currentDay = Convert.ToInt32(Date[0]) * 10 + Convert.ToInt32(Date[1]);
            currentMonth = Convert.ToInt32(Date[3]) * 10 + Convert.ToInt32(Date[4]);
            currentYear = Convert.ToInt32(Date[6]) * 10 + Convert.ToInt32(Date[7]);
            int entry;
            int current;
            entry = entryYear * 365 + entryMonth * 30 + entryDay;
            current = currentYear * 365 + currentMonth * 30 + currentDay;
            days = current - entry;
            int YearsOfService = days / 365;
            double CurrentSalary = employeeSalary + (employeeSalary * YearsOfService);
            return CurrentSalary;
        }
    }
}
