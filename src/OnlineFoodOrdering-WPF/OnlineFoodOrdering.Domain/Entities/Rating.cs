using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Rating : Auditable
    {
        [Required]
        public long FoodId { get; set; }
        public virtual Food Food { get; set; }
    
        public short Score { get; set; }
        
        public string Comment { get; set; } = String.Empty;

        public Rating()
        {
            Food = new Food();
        }
    }
}
