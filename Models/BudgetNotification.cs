using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class BudgetNotification
    {
        public int Id { get; set; }
        public int BudgetId { get; set; }
        public string RecipientId { get; set; }
        public string SenderId { get; set; }

        public DateTime Created { get; set; }
        public string Subject { get; set; }
        public string NotificationBody { get; set; }
        public bool IsRead { get; set; }

        //nav
        public virtual Budget Budget { get; set; }
        public virtual ApplicationUser Recipient { get; set; }
        public virtual ApplicationUser Sender { get; set; }
    }
}