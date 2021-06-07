using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAO.Model
{
    public partial class DBWebsite : DbContext
    {
        public DBWebsite()
            : base("name=DBWebsite")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<ComboDrinkDetail> ComboDrinkDetails { get; set; }
        public virtual DbSet<ComboFoodDetail> ComboFoodDetails { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Foundation> Foundations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PaWo)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.IdCombo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.ComboName)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.ImgCombo)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.ComboDrinkDetails)
                .WithRequired(e => e.Combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.ComboFoodDetails)
                .WithRequired(e => e.Combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ComboDrinkDetail>()
                .Property(e => e.IdCombo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ComboDrinkDetail>()
                .Property(e => e.IdDrink)
                .IsUnicode(false);

            modelBuilder.Entity<ComboFoodDetail>()
                .Property(e => e.IdCombo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ComboFoodDetail>()
                .Property(e => e.IdFood)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.IdProduct)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.IdCusomter);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drink>()
                .Property(e => e.IdDrink)
                .IsUnicode(false);

            modelBuilder.Entity<Drink>()
                .Property(e => e.ImgDrink)
                .IsUnicode(false);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.ComboDrinkDetails)
                .WithRequired(e => e.Drink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.IdFood)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.ImgFood)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.ComboFoodDetails)
                .WithRequired(e => e.Food)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Foundation>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Foundation)
                .HasForeignKey(e => e.IdFoundation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.IdFood)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.IdDrink)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.IdCombo)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
