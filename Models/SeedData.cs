/**/
using LabelPrinter.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LabelDBContext(serviceProvider.GetRequiredService<DbContextOptions<LabelDBContext>>()))
            {
                if (context.User.Any())
                {
                    return;
                }
                List<User> users = new List<User>{
                    new User {UserName="njohnson", FirstName="Norman", LastName="Johnson", Password="njohnson", Role="Psychologist" },
                    new User {UserName="hadams", FirstName="Harry", LastName="Adams", Password="hadams", Role="Mathematician" },
                    new User {UserName="bhalpern", FirstName="Beth", LastName="Halpern", Password="bhalpern", Role="Zoologist" },
                    new User {UserName="tfielding", FirstName="Ted", LastName="Fielding", Password="tfielding", Role="Astrophysicist" },
                    new User {UserName="alevine", FirstName="Arthur", LastName="Levine", Password="alevine", Role="Marine Biologist" }
                };
                context.AddRange(users);

                List<Lbl_Item> itmLbls = new List<Lbl_Item>{
                    new Lbl_Item {}
                }

            }
        }
    }

}
