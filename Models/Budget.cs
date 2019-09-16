using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class Budget //Budget categories, such as "Utilities"
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseholdId { get; set; }
        public virtual Household Household {get; set;}
        public virtual ICollection<BudgetHistory> BudgetHistories { get; set; }
        public virtual ICollection<BudgetNotification> BudgetNotifications { get; set; }

        public Budget()
        {
            BudgetHistories = new HashSet<BudgetHistory>();
            BudgetNotifications = new HashSet<BudgetNotification>();
        }
    }
}