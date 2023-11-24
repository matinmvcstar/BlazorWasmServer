using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class ShoppingSession
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser? User { get; set; } = null!;

        public ICollection<CartItem> CartItems { get; set; } = null!;

        [Column(TypeName = "decimal(25,0)")]
        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
