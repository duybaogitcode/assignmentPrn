using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public string Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string TableId { get; set; }
        public int Discount { get; set; }
        public int? TotalPrice { get; set; }
        public int Status { get; set; }

        public virtual TableCoffeeDTO Table { get; set; }
        public virtual ICollection<BillInfoDTO> BillInfos { get; set; }
    }
}
