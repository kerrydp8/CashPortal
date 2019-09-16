using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }
        public virtual AccountType Type { get; set; }
    }
}