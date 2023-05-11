using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<User> User{get;set;}=default!;

        public DbSet<Lbl_Item> Lbl_Item{get;set;} = default!;
        public DbSet<Lbl_Bin> Lbl_Bin{get;set;} = default!;
    }
}