using CakeShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Services
{
    public interface IReviewRepository
    {
        List<ReviewVM> GetAll();
        ReviewVM Add(int customerId, ReviewVM review);
    }
}
