using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class AccountType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }

        public AccountType()
        {
            BankAccounts = new HashSet<BankAccount>();
        }
    }
}