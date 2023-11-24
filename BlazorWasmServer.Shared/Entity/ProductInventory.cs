using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class ProductInventory
    {
        public long Id { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
