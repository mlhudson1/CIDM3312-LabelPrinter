using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public class LabelContext:DbContext{
        public LabelContext(DbContextOptions<LabelContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<User> Users{get;set;}=default!;

        public DbSet<Lbl_Item> Lbls_Item{get;set;} = default!;
        public DbSet<Lbl_Bin> Lbls_Bin{get;set;} = default!;
    }
}