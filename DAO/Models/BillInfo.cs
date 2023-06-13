using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class BillInfo
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string FoodId { get; set; }
        public int Amount { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Food Food { get; set; }
    }
}
