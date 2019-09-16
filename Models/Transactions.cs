using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Amount { get; set; }
        public int SubmitterId { get; set; }
        public DateTime Reconciled { get; set; }
        public int ReconciledAmount { get; set; }
        public virtual ApplicationUser Owner { get; set; }
        public virtual ApplicationUser Submitter { get; set; }
        public virtual BankAccount Account { get; set; }
    }
}