using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
    public class UserAddress
    {
        public long Id { get; set; }

        public string Address { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Region { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(10)]
        public string Country { get; set; }

        [MaxLength(11)]
        public string Phone { get; set; }

        [MaxLength(11)]
        public string Fax { get; set; }

        [MaxLength(11)]
        public string Mobile { get; set; }

        [MaxLength(30)]
        public string MapLocation { get; set; }

        public string UserId { get; set; }
        ///public ICollection<ApplicationUser> ApplicationUser { get; set; } = new List<ApplicationUser>();

        public ApplicationUser ApplicationUsers { get; set; } = null!;
    }
}
