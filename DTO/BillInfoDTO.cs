using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfoDTO
    {
        public string Id { get; set; }
        public string BillId { get; set; }
        public string FoodId { get; set; }
        public int Amount { get; set; }

        public virtual BillDTO Bill { get; set; }
        public virtual FoodDTO Food { get; set; }
    }
}
