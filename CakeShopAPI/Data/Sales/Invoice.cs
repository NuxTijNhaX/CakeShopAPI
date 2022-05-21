using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Data
{
    [Table("Invoices", Schema = "Sales")]
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }

        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
