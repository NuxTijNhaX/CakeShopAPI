using CakeShopAPI.Data;
using CakeShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Services
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly CakeShopDbContext _dbContext;

        public ReviewRepository(CakeShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ReviewVM> GetAll()
        {
            var reviews = (from rev in _dbContext.ProductReviews
                           join cus in _dbContext.Customers
                           on rev.CustomerId equals cus.CustomerId
                           select new ReviewVM
                           {
                               Id = rev.Id,
                               Comments = rev.Comments,
                               Rating = rev.Rating,
                               DateTime = rev.DateTime,
                               Customer = cus.Name,
                           }).ToList();

            return reviews;
        }

        public ReviewVM Add(int customerId, ReviewVM review)
        {
            throw new NotImplementedException();
        }
    }
}
