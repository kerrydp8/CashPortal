using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public int HouseholdId { get; set; }
        public string Body { get; set; }
        public int OwnerId { get; set; }
        public int RecipientId { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime Sent { get; set; }

        public virtual Household Household { get; set; }
        public virtual ApplicationUser Recipient { get; set; }
        public virtual ApplicationUser Owner { get; set; }

    }
}