using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public string Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string TableId { get; set; }
        public int Discount { get; set; }
        public int? TotalPrice { get; set; }
        public int Status { get; set; }

        public virtual TableCoffee Table { get; set; }
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
