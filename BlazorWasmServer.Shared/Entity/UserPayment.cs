using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class UserPayment
    {
        public long Id { get; set; }
        public string PaymentType { get; set; }
        public string Provider { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public int account_no { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime expiry { get; set; }

        public string UserId { get; set; }

        ///public ICollection<ApplicationUser> ApplicationUser { get; set; } = new List<ApplicationUser>();

        public ApplicationUser ApplicationUsers { get; set; } = null!;
    }
}
