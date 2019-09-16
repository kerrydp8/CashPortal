using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashPortal.Models
{
    public class Household
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public Household()
        {
            Users = new HashSet<ApplicationUser>();
        }
    }
}