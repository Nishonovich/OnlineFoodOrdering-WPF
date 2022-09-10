using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Food : Auditable
    {
        [Required, MaxLength(50)]
        public String FoodName { get; set; } = String.Empty;
        [Required]
        public float FoodPrice { get; set; }
        [Required]
        public long FoodTypeId { get; set; }
        public virtual FoodType FoodType { get; set; }
        [Required]
        public String FoodImagePath { get; set; } = String.Empty;
        [Required]
        public String FoodComposition { get; set; } = String.Empty;

        public Food()
        {
            FoodType = new FoodType();
        }

    }
}
