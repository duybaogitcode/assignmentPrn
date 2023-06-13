using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }

        public string Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
