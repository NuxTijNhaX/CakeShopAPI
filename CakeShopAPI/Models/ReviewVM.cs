using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Models
{
    public class ReviewVM
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public double Rating { get; set; }
        public DateTime DateTime { get; set; }
        public string Customer { get; set; }
    }
}
