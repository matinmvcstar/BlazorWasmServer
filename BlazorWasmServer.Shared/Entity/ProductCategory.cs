using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class ProductCategory
    {
        public long Id { get; set; }

        public ICollection<Product> Products { get;} = new List<Product>();

        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } 

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Column(TypeName = "DateTime")]
        public DateTime DeleteDate { get; set; }
    }
}
