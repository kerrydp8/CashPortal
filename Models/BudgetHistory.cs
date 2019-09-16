﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class BudgetHistory
    {
        public int Id { get; set; }
        public int BudgetId { get; set; }
        public string PropertyName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime Updated { get; set; }
        public string UserId { get; set; }

        public virtual Budget Budget { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}