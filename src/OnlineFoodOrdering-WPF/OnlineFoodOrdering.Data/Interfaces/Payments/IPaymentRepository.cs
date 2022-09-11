using OnlineFoodOrdering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Interfaces.Payments
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
    }
}
