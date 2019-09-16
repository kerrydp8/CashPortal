using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class BudgetItem //Individual items for a particular budget category (ex: Electric bill under the Utilities budget category)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int BudgetId { get; set; }

        public virtual Budget Budget { get; set; }

    }
}