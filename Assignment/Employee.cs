using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        public int VacationStock
        {
            get { return VacationStock; }
            set { VacationStock = value; }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int days = (To - From).Days;

            if (days <= VacationStock)
            {
                VacationStock -= days;
                return true;
            }
            return false;
        }
        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStock });
            }
            else if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age });
            }
        }

        public void Subscribe(EventHandler<EmployeeLayOffEventArgs> action)
        {
            EmployeeLayOff += action;
        }

        public void UnSubscribe(EventHandler<EmployeeLayOffEventArgs> action)
        {
            EmployeeLayOff -= action;
        }
    }
}
