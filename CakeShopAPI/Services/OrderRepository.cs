using CakeShopAPI.Data;
using CakeShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CakeShopDbContext _dbContext;

        public OrderRepository(CakeShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(OrderVM order)
        {
            Guid orderId = new Guid();
            double totalCost = 0;

            foreach (var orderLine in order.orderLines)
            {
                OrderLine newOrderLine = new OrderLine()
                {
                    guidOrder = orderId,
                    Quantity = orderLine.Quantity,
                    SizeId = GetSizeId(orderLine.Size),
                    ProductId = orderLine.ProductId
                };

                totalCost += (GetProductPrice(orderLine.ProductId) * orderLine.Quantity);

                _dbContext.OrderLines.Add(newOrderLine);
            }

            Order newOrder = new Order()
            {
                guidOrder = orderId,
                CustomerId = order.CustomerId,
                Date = DateTime.Now,
                TotalCost = totalCost,
            };
            _dbContext.Orders.Add(newOrder);

            _dbContext.SaveChanges();
        }

        public void Delete(OrderVM order)
        {
            throw new NotImplementedException();
        }

        public List<OrderVM> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderVM order)
        {
            throw new NotImplementedException();
        }

        private int GetSizeId(string sizeName)
        {
            int sizeId = (from size in _dbContext.Sizes
                          where size.Name == sizeName
                          select size.Id).FirstOrDefault();

            return sizeId;
        }

        private double GetProductPrice(int productId)
        {
            double price = (from pro in _dbContext.Products
                            where pro.Id == productId
                            select pro.Price).FirstOrDefault();

            return price;
        }
    }
}
