using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public int Price { get; set; }
        public bool? Status { get; set; }
        public string Avatar { get; set; }

        public virtual CategoryFood Category { get; set; }
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
