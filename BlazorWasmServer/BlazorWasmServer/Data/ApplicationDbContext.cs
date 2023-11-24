using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmServer.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPayment> UserPayments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductsInventory { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<ShoppingSession> ShoppingSessions { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Slider> Slider { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductInventory>()
                .HasOne(e => e.Product)
                .WithOne(e => e.Inventory)
                .HasForeignKey<Product>(e => e.InventoryId)
                .IsRequired(false);

            modelBuilder.Entity<PaymentDetails>()
                .HasOne(e => e.OrderDetails)
                .WithOne(e => e.PaymentDetails)
                .HasForeignKey<PaymentDetails>(e => e.OrderDetailsId)
                .IsRequired(false);

            modelBuilder.Entity<Product>()
                .HasOne(e => e.OrderItems)
                .WithOne(e => e.Product)
                .HasForeignKey<OrderItems>(e => e.ProductId)
                .IsRequired(false);

            modelBuilder.Entity<Product>()
                .HasOne(e => e.CartItem)
                .WithOne(e => e.Product)
                .HasForeignKey<CartItem>(e => e.ProductId)
                .IsRequired(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(e => e.OrderDetails)
                .WithOne(e => e.User)
                .HasForeignKey<OrderDetails>(e => e.UserId)
                .IsRequired(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(e => e.ShoppingSession)
                .WithOne(e => e.User)
                .HasForeignKey<ShoppingSession>(e => e.UserId)
                .IsRequired(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductCategory)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Discount)
                .HasForeignKey(e => e.DiscountId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<OrderDetails>()
                .HasMany(e => e.OrderItems)
                .WithOne(e => e.OrderDetail)
                .HasForeignKey(e => e.OrderDetailsId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ShoppingSession>()
                .HasMany(e => e.CartItems)
                .WithOne(e => e.ShoppingSession)
                .HasForeignKey(e => e.ShoppingSessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.UserAddresses)
                .WithOne(e => e.ApplicationUsers)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.UserPayments)
                .WithOne(e => e.ApplicationUsers)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.Sliders)
                .WithOne(e => e.ApplicationUsers)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.Banners)
                .WithOne(e => e.ApplicationUsers)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
