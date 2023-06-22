using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodDTO
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public int Price { get; set; }

        public virtual CategoryFoodDTO Category { get; set; }
        public virtual ICollection<BillInfoDTO> BillInfos { get; set; }
    }
}
