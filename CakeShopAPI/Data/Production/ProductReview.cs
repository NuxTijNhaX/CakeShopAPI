using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Data
{
    [Table("ProductReviews", Schema = "Production")]
    public class ProductReview
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public double Rating { get; set; }
        public DateTime DateTime { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
