using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BlazorWasmServer.Shared.Entity
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public OrderDetails? OrderDetails { get; set; }

        public ShoppingSession? ShoppingSession { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

        public ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();

        public ICollection<Banner> Banners { get; set; } = new List<Banner>();

        public ICollection<Slider> Sliders { get; set; } = new List<Slider>();

        [MaxLength(11)]
        public string Phone { get; set; }

        [MaxLength(11)]
        public string MobilePhone { get; set; }

        [MaxLength(27)]
        public string Shaba { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [MaxLength(8)]
        public string CreationDateString { get; set; }

        [MaxLength(6)]
        public string CreationTimeString { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime LastDate { get; set; } = DateTime.Now;

        [Column(TypeName = "DateTime")]
        public DateTime LastTime { get; set; } = DateTime.Now;

        [MaxLength(8)]
        public string LastDateString { get; set; }

        [MaxLength(6)]
        public string LastTimeString { get; set; }

        public string LastUser { get; set; }
    }

}
