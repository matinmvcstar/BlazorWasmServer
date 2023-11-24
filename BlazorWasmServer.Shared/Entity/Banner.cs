using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmServer.Shared.Entity
{
	public class Banner
	{
		public int Id { get; set; }

		public byte[] BannerImage { get; set; }

		public DateTime? CreatedDate { get; set; } = DateTime.Now;

		[Column(TypeName = "DateTime")]
		public DateTime? UpdatedDate { get; set; }

		public bool IsDeleted { get; set; } = false;

		[Column(TypeName = "DateTime")]
		public DateTime? DeleteDate { get; set; }

		public string UserId { get; set; }

		public ApplicationUser ApplicationUsers { get; set; } = null!;
	}
}
