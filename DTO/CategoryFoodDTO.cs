using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryFoodDTO
    {

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FoodDTO> Foods { get; set; }
    }
}
