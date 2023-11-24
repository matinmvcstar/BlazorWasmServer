using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class PaymentDetails
    {
        public long Id { get; set; }

        public OrderDetails? OrderDetails { get; set; }

        public long OrderDetailsId { get; set; }

        public long Amount { get; set; } = 0;

        public string ProviderName { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
