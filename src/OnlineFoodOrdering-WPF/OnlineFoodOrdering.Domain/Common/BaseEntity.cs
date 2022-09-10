using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Common
{
    public class BaseEntity
    {
        [Required]
        public long Id { get; set; }
    }
}
