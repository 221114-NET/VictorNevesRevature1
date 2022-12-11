using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace ModelsLayer
{
    public class Ticket
    {

        
        public Ticket(int ticketID, string ticketType, double ticketAmount, string ticketDescription, string ticketStatus, int UserID)
        {
            this.ticketID = ticketID;
            this.ticketType = ticketType;
            this.ticketAmount = ticketAmount;
            this.ticketDescription = ticketDescription;
            this.ticketStatus= ticketStatus;
            this.UserID = UserID;
        }

        public int ticketID {get;set;}
        public string ticketType {get; set;}
        public double ticketAmount{get;set;}

        public string ticketDescription{get;set;}
        public string ticketStatus{get;set;}

        public int UserID{get;set;}

        

    }
}