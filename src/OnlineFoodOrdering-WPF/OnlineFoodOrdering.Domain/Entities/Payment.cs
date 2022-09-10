using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class Payment : Auditable
    {
        [Required]
        public long Order_id { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        public double Total_sum { get; set; }

        [Required]
        public long Emoloyee_id { get; set; }

        public virtual Employee Employee { get; set; }

        //payment_date ni yozmadim, chunki Auditabledan meros olingan

        public Payment()
        {
            Employee = new Employee();
            Order = new Order();
        }
    }
}
