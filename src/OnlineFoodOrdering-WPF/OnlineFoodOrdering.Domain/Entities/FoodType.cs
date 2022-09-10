using OnlineFoodOrdering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Domain.Entities
{
    public class FoodType : BaseEntity
    {
        public String TypeName = String.Empty;
        public String Description = String.Empty;

    }
}
