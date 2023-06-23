using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string TypeId { get; set; }
        public string Avatar { get; set; }

        public virtual AccountType Type { get; set; }
    }
}
