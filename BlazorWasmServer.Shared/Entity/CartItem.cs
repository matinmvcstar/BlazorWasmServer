using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class CartItem
    {
        public int Id { get; set; }

        public long ShoppingSessionId { get; set; }

        public ShoppingSession ShoppingSession { get; set; } = null!;

        public long ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public long Quanitiy {  get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
