using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public interface IBusinessLayer
    {
        Employee PostEmployee(Employee emp);
    }

    public interface IRepoLayer
    {
        Ticket ChangeTicketStatus(bool v, TicketStatus newStatus);
        List<Ticket>? GetTicketList(bool v);
        Ticket NewTicket(object ticketID);
        Employee PostEmployee(Employee emp);
        Employee RegisterUser(string email, string emailPassword);
        string UserLogin(string email, string emailPassword);
    }
}