using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Rating : Auditable
    {
        public int FoodId { get; set; }
        public short Score { get; set; }
        public string Comment { get; set; } = String.Empty;
    }
}
