using OnlineFoodOrdering.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        [Required]
        public long OrderId { get; set; }
        public virtual Order Order { get; set; }


        [Required]
        public long FoodId { get; set; }
        public virtual Food Food { get; set; }


        [Required]
        public int Quantity { get; set; }


        [Required]
        public double TotalPrice { get; set; }

        public OrderDetail()
        {
            Order = new Order();
            Food = new Food();
        }
    }
}
