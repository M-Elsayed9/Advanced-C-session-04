using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.Subscribe(RemoveStaff);
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)

        {
            Staff.Remove((Employee)sender);
            Console.WriteLine($"{sender} Removed Because of {e.Cause}");

        }
    }
}
