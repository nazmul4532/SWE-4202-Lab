using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employe_Management_with_Exception_Handling
{
    public partial class Form1 : Form
    {
        Employee_Management_System Office = new Employee_Management_System();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string Contact = newEmployeeContactTextBox.Text;
            string Designation = newEmployeeDesignationComboBox.Text;
            bool flag = false;
            foreach (Employee employee in Office.employees)
            {
                if(employee.employeeContactNo == Contact)
                {
                    flag = true;
                    MessageBox.Show("The Employee already exists in the Database");
                }
            }
            if(flag == false)
            {
                if(Designation == "Manager")
                {
                    Manager dummy = new Manager();
                    dummy.employeeName = newEmployeeNameTextBox.Text;
                    dummy.employeeDesignation = Designation;
                    dummy.employeeContactNo = Contact;
                    dummy.employeeDoJ = newEmployeeDoJTextBox.Text;
                    dummy.employeeSalary = Convert.ToInt32(newEmployeeSalaryTextBox.Text);
                    dummy.employeeLeaves = Convert.ToInt32(newEmployeeLeavesTextBox.Text);
                    dummy.employeeID = Employee_Management_System.employeeId;
                    MessageBox.Show("Employee ID is " + dummy.employeeID);
                    Employee_Management_System.employeeId++;
                    Office.employees.Add(dummy);
                }
                if (Designation == "Salesperson")
                {
                    Salesperson dummy = new Salesperson();
                    dummy.employeeName = newEmployeeNameTextBox.Text;
                    dummy.employeeDesignation = Designation;
                    dummy.employeeContactNo = Contact;
                    dummy.employeeDoJ = newEmployeeDoJTextBox.Text;
                    dummy.employeeSalary = Convert.ToInt32(newEmployeeSalaryTextBox.Text);
                    dummy.employeeLeaves = Convert.ToInt32(newEmployeeLeavesTextBox.Text);
                    dummy.employeeID = Employee_Management_System.employeeId;
                    MessageBox.Show("Employee ID is " + dummy.employeeID);
                    Employee_Management_System.employeeId++;
                    Office.employees.Add(dummy);
                }
                if (Designation == "Typewriter")
                {
                    Typewriter dummy = new Typewriter();
                    dummy.employeeName = newEmployeeNameTextBox.Text;
                    dummy.employeeDesignation = Designation;
                    dummy.employeeContactNo = Contact;
                    dummy.employeeDoJ = newEmployeeDoJTextBox.Text;
                    dummy.employeeSalary = Convert.ToInt32(newEmployeeSalaryTextBox.Text);
                    dummy.employeeLeaves = Convert.ToInt32(newEmployeeLeavesTextBox.Text);
                    dummy.employeeID = Employee_Management_System.employeeId;
                    MessageBox.Show("Employee ID is " + dummy.employeeID);
                    Employee_Management_System.employeeId++;
                    Office.employees.Add(dummy);
                }
            }
        }

        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            int SearchEmployeeID = Convert.ToInt32(SearchEmployeeIDTextBox.Text);
            string SearchDate = SearchDateTextBox.Text;
            bool flag = false;
            listBox.Items.Clear();
            foreach (Employee employee in Office.employees)
            {
                if (employee.employeeID == SearchEmployeeID)
                {
                   flag = true;
                   MessageBox.Show("Employee ID has been Found");
                }
            }
            if(flag == false)
            {
                exceptionByID exp = new exceptionByID();
                throw exp;
            }
            else
                {
                double Salary=0;
                foreach(Employee employee in Office.employees)
                {
                    if(employee.employeeID == SearchEmployeeID)
                    {
                        if(employee.employeeDesignation == "Manager")
                        {
                            Salary = employee.employeeSalary + employee.getSalary(SearchDate) * 0.15;
                        }
                        if (employee.employeeDesignation == "Salesperson")
                        {
                            Salary = employee.employeeSalary + employee.getSalary(SearchDate) * 0.10;
                        }
                        if (employee.employeeDesignation == "Typewriter")
                        {
                            Salary = employee.employeeSalary + employee.getSalary(SearchDate) * 0.05;
                        }
                        string employeeInfo = employee.employeeID + "\t" + employee.employeeName + "\t" + employee.employeeDesignation + "\t \t" + employee.employeeContactNo + "\t" + Convert.ToString(Salary) + "\t" + employee.employeeDoJ + "\t \t" + employee.employeeLeaves;
                        string basicInfo = "ID" + "\t" + "Name" + "\t" + "Designation" + "\t" + "Contact No" + "\t" + "Salary" + "\t" + "Date of Joining" + "\t" + "Leaves" +"\n";
                        listBox.Items.Add(basicInfo);
                        listBox.Items.Add(employeeInfo);
                        MessageBox.Show("Employee information has been shown.");
                        break;
                    }
                    
                }
            }
        }
    }
}

