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

        public string Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
