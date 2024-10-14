using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            Members.Add(E);
            ///Try Register for EmployeeLayOff Event Here
            E.Subscribe(RemoveMember);
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
            if (e.Cause == LayOffCause.VacationStock && sender is not BoardMember)
            {
                Members.Remove((Employee)sender);
            }
        }
    }
}
