using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace BusinessLayer
{
    public class TicketRequests : IBusinessLayer
    {
        private IRepoLayer? repo;
        private bool isManager;

        public TicketRequests(IRepoLayer iRepo)
        {
        repo = iRepo;
        }

        public Ticket NewTicket(Ticket ticket)
        {
            ticket.TicketStat = TicketStatus.PENDING;
            return repo!.NewTicket(ticket);

        }

        public Ticket? ChangeTicketStatus(bool isManager,TicketStatus newStatus)
        {
            if (true)
            {
                return repo?.ChangeTicketStatus(true, newStatus);

            }

            
        }

        public Employee PostEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
