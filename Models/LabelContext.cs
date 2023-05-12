using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public class LabelContext:DbContext{
        public LabelContext(DbContextOptions<LabelContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLbl_Item>().HasKey(s => new {s.Lbl_ItemID, s.UserID});
            modelBuilder.Entity<UserLbl_Bin>().HasKey(r => new {r.Lbl_BinID, r.UserID});
        }
        public DbSet<User> Users{get;set;}=default!;

        public DbSet<Lbl_Item> Lbls_Item{get;set;} = default!;
        public DbSet<Lbl_Bin> Lbls_Bin{get;set;} = default!;
    }
}