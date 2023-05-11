using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public class LabelDBContext:DbContext
    {
        public LabelDBContext(DbContextOptions<LabelDBContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLbl_Item>().HasKey(s => new {s.Lbl_ItemID, s.UserID});
            modelBuilder.Entity<UserLbl_Bin>().HasKey(r => new {r.Lbl_BinID, r.UserID});
        }
        public DbSet<User> User{get;set;}=default!;

        public DbSet<Lbl_Item> Lbl_Item{get;set;} = default!;
        public DbSet<Lbl_Bin> Lbl_Bin{get;set;} = default!;
    }
}