using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class TableCoffee
    {
        public TableCoffee()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
