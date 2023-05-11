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
        public DbSet<Role> Role{get;set;}=default!;
        public DbSet<Printer> Printer{get;set;} = default!;
        public DbSet<Media> Media{get;set;} = default!;
        public DbSet<Lbl_Work_Order> Lbl_Work_Order{get;set;} = default!;
        public DbSet<Lbl_Item> Lbl_Item{get;set;} = default!;
        public DbSet<Lbl_Document> Lbl_Document{get;set;} = default!;
        public DbSet<Lbl_Bin> Lbl_Bin{get;set;} = default!;
        public DbSet<Lbl_Address> Lbl_Address{get;set;} = default!;
    }
}