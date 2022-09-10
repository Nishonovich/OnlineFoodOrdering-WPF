using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class FoodType : BaseEntity
    {
        [Required, MaxLength(50)]
        public String TypeName { get; set; } = String.Empty;
        [Required]
        public String Description { get; set; } = String.Empty;

    }
}
