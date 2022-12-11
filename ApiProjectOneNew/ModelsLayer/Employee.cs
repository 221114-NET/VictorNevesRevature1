using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace ModelsLayer
{
    public class Employee
    {

        public Employee(int UserID, string fname, string lname, string email, string emailPassword, bool isManager)
        {
            this.UserID = UserID;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.emailPassword= emailPassword;

        }

        public int UserID {get;set;}
        public string fname {get;set;}
        public string lname {get;set;}
        public string email {get;set;}
        public string emailPassword {get;set;}
        public bool isManager { get; set; } = false;

        public string WelcomeEmployee()
        {
            return $"Welcome {this.fname} {this.lname}";

        }

    }
}
