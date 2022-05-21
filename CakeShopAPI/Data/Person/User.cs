using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShopAPI.Data
{
    [Table("Users", Schema = "Person")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
