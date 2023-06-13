using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class CategoryFood
    {
        public CategoryFood()
        {
            Foods = new HashSet<Food>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
