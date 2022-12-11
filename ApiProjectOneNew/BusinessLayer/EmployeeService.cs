using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace BusinessLayer
{
    public interface EmployeeService
    {
        public Employee EmployeeRegistration(string UserID, string email, string emailPassword, bool isManager=false);
        public Employee EmployeeLogin(string email, string emailPassword);

        public Manager ManagerLogin(string email, string emailPassword, bool isManager=true);
    }
}