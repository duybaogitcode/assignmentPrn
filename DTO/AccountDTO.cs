using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string TypeId { get; set; }

        public AccountDTO()
        {
        }
        public virtual AccountTypeDTO Type { get; set; }
    }
}
