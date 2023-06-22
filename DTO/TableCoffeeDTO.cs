using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableCoffeeDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<BillDTO> Bills { get; set; }
    }
}
