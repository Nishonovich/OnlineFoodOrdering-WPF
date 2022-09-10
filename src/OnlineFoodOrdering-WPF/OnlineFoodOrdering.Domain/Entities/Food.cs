using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Food
    {
        public String FoodName { get; set; } = String.Empty;
        public float FoodPrice { get; set; }
        public long FoodTypeId { get; set; }
        public String FoodImagePath { get; set; } = String.Empty;
        public String FoodComposition { get; set; } = String.Empty;



    }
}
