using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class Product
    {
        public long Id { get; set; }

        public OrderItems? OrderItems { get; set; }

        public CartItem? CartItem { get; set; }

        public long DiscountId { get; set; }

        public Discount Discount { get; set; } = null!;

        public long InventoryId { get; set; }

        public ProductInventory Inventory { get; set; } = null!;

        public string Name { get; set; }

        public string Description { get; set; }

        public string SKU { get; set; }

        public long CategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; } = null!;

        [Column(TypeName = "decimal(25,0)")]
        public decimal PriceOld { get; set; } = 0;

        [Column(TypeName = "decimal(25,0)")]
        public decimal PriceNew { get; set; } = 0;

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
