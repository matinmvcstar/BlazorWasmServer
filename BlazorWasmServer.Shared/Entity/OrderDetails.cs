using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class OrderDetails
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        public virtual ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();

        [Column(TypeName = "decimal(25,0)")]
        public decimal Total { get; set; }

        public long PaymentId { get; set; }

        public PaymentDetails PaymentDetails { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
