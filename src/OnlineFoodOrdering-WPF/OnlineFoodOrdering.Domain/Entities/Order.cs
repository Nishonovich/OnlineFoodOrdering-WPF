using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Order : Auditable
    {
        [Required]
        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public float TotalAmount { get; set; }

        [Required]
        public bool OrderStatus { get; set; }

        [Required]
        public long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public string Address { get; set; } = string.Empty;

        public Order()
        {
            Customer = new Customer();
            Employee = new Employee();
        }
    }
}
