using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        [Required]
        public long OrderId { get; set; }

        [Required]
        public long FoodId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double TotalPrice { get; set; }
    }
}
