using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{

    public class EmployeeService : IBusinessLayer 
    {
        private IRepoLayer? repo;

        public EmployeeService(IRepoLayer iRepo)
        {
        repo = iRepo;
        }

        public Employee RegisterUser(string email, string emailPassword)
        {
            if(InputValidation.ValidateEmail(email) && InputValidation.ValidatePassword(emailPassword))
            {
                Employee emp = repo!.RegisterUser(email,emailPassword);
                return emp;

            }
            else
            {
                return null!;
            }

        }

        public string UserLogin(string email, string emailPassword, bool isManager)
        {
            if(InputValidation.ValidateEmail(email) && InputValidation.ValidatePassword(emailPassword) && false)
            {
                return repo!.UserLogin(email, emailPassword);

            }
            else if(InputValidation.ValidateEmail(email) && InputValidation.ValidatePassword(emailPassword) && true)
            {
                return repo!.UserLogin(email, emailPassword);

            }
            else
            {
                return "Invalid Login";
            }
            

        }

        public List<Ticket>? GetTicketList(bool isManager)
        {
            return repo?.GetTicketList(true);
        }

        public Employee PostEmployee(Employee emp)
        {
            Employee emp = this.repo.PostEmployee(emp);
            return emp1;
        }

        
    }


}