using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModelsLayer;


namespace RepoLayer
{
    public class RepositoryClass : IRepoLayer
    {
        public Ticket ChangeTicketStatus(bool v, TicketStatus newStatus)
        {
            throw new NotImplementedException();
        }

        public List<Ticket>? GetTicketList(bool v)
        {
            throw new NotImplementedException();
        }

        public Ticket NewTicket(object ticketID)
        {
            throw new NotImplementedException();
        }

        public Employee RegisterUser(string email, string emailPassword)
        {
            throw new NotImplementedException();
        }

        public string UserLogin(string email, string emailPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee>? PostEmployeeAsync(Employee emp)
        {
            //use ADO.NET to push to database
            SqlConnection conn = new SqlConnection("Server=tcp:victor-p1server.database.windows.net,1433;Initial Catalog=VictorProjectOne;Persist Security Info=False;User ID=victor203;Password=Kaike1234-;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand command = new SqlCommand($"INSERT INTO Employees (email, emailPasswords) VALUES(@email,@emailPassword", conn);
            conn.Open(); //opening connection

            //parameters to query
            command.Parameters.AddWithValue("@FirstName", emp.fname);
            command.Parameters.AddWithValue("@LastName", emp.lname);
            command.Parameters.AddWithValue("@email", emp.email);
            command.Parameters.AddWithValue("@emailPassword", emp.emailPassword);
            int rowsAffected = await command.ExecuteNonQueryAsync();
            //call the private get a employee to get an employee
            if (rowsAffected == 1)
            {
                conn.Close();
                return emp;
            }
            else
            {
                return null!;
            }
        }

        public Employee PostEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}