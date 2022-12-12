using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public interface IBusinessLayer
    {
        
    }

    public interface IRepoLayer
    {
        Ticket ChangeTicketStatus(bool v, TicketStatus newStatus);
        List<Ticket>? GetTicketList(bool v);
        Ticket NewTicket(object ticketID);
        Employee RegisterUser(string email, string emailPassword);
        string UserLogin(string email, string emailPassword);
    }
}