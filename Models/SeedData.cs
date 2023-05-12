
using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider){
            using(var context = new LabelContext(serviceProvider.GetRequiredService<DbContextOptions<LabelContext>>())){
                if(context.Users.Any()){ return;}
                List<User> users = new List<User>{
                    new User {UserName="njohnson", FirstName="Norman", LastName="Johnson", Password="njohnson", Role="Psychologist" },
                    new User {UserName="hadams", FirstName="Harry", LastName="Adams", Password="hadams", Role="Mathematician" },
                    new User {UserName="bhalpern", FirstName="Beth", LastName="Halpern", Password="bhalpern", Role="Zoologist" },
                    new User {UserName="tfielding", FirstName="Ted", LastName="Fielding", Password="tfielding", Role="Astrophysicist" },
                    new User {UserName="alevine", FirstName="Arthur", LastName="Levine", Password="alevine", Role="Marine Biologist" }
                };
                context.Users.AddRange(users);

                List<Lbl_Item> itmLbls = new List<Lbl_Item>{
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 47, 0),qty=1,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 48, 0),qty=1,item="74951",upc="703673749510",description="Visionary Move Mobile Glassboard - Magnetic 4' x 6'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 49, 0),qty=4,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 50, 0),qty=1,item="27692",upc="717641276922",description="Trend Podium Desk", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 51, 0),qty=1,item="27675",upc="717641276250",description="iTeach Flat Panel Cart", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 52, 0),qty=8,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 53, 0),qty=1,item="221OH-03",upc="703673838740",description="Tuff-Rite Markerboard - Origin Trim (Mahogany) - 4' x 8' - dot grid", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 54, 0),qty=1,item="202AP-25",upc="703673284004",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 16'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 55, 0),qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 56, 0),qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 57, 0),qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 58, 0),qty=1,item="1005",upc="703673371322",description="Basic Easel - Hardboard", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 1, 7, 59, 0),qty=1,item="1000",upc="703673371315",description="Ideal Easel", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 0, 0),qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 1, 0),qty=1,item="221OH-03",upc="703673838740",description="Tuff-Rite Markerboard - Origin Trim (Mahogany) - 4' x 8' - dot grid", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 2, 0),qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 3, 0),qty=8,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 4, 0),qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 5, 0),qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 6, 0),qty=7,item="27675",upc="717641276250",description="iTeach Flat Panel Cart", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 7, 0),qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 8, 0),qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 9, 0),qty=1,item="27692",upc="717641276922",description="Trend Podium Desk", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 3, 8, 10, 0),qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 8, 11, 0),qty=2,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base"},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 8, 12, 0),qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 8, 13, 0),qty=1,item="27675",upc="717641276250",description="iTeach Flat Panel Cart", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 8, 14, 0),qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 15, 0),qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 16, 0),qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 17, 0),qty=6,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 18, 0),qty=1,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 19, 0),qty=1,item="27692",upc="717641276922",description="Trend Podium Desk", user=users[2]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 20, 0),qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 5, 9, 22, 0),qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[1]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 6, 9, 23, 0),qty=2,item="27675",upc="717641276250",description="iTeach Flat Panel Cart", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 6, 9, 24, 0),qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'", user=users[5]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 6, 9, 25, 0),qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart", user=users[4]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 6, 9, 26, 0),qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard", user=users[3]},
                    new Lbl_Item {addDate= new DateTime(2023, 5, 6, 9, 27, 0),qty=1,item="74951",upc="703673749510",description="Visionary Move Mobile Glassboard - Magnetic 4' x 6'", user=users[1]},
                };
                context.AddRange(itmLbls);
                
                List<Lbl_Bin> binLbls = new List<Lbl_Bin>{
                    new Lbl_Bin {addDate=new DateTime(2020, 5, 1, 7, 47, 0), qty=2, binID="2885-5-23", binName="2885 Room 5 Bin 23", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2020, 5, 22, 7, 47, 0), qty=2, binID="2885-2-48", binName="2885 Room 3 Bin 48", user=users[5]},
                    new Lbl_Bin {addDate=new DateTime(2020,6, 29, 7, 47, 0), qty=2, binID="2885-1-90", binName="2885 Room 1 Bin 90", user=users[5]},
                    new Lbl_Bin {addDate=new DateTime(2020, 6, 12, 7, 47, 0), qty=2, binID="2501-4-39", binName="2501 Room 4 Bin 39", user=users[5]},
                    new Lbl_Bin {addDate=new DateTime(2020, 9, 10, 7, 47, 0), qty=2, binID="2501-2-22", binName="2501 Room 2 Bin 22", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2020, 9, 16, 7, 47, 0), qty=2, binID="2501-2-23", binName="2501 Room 2 Bin 23", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2020, 11, 30, 7, 47, 0), qty=2, binID="2501-4-40", binName="2501 Room 4 Bin 40", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2020, 12, 12, 7, 47, 0), qty=2, binID="2885-2-90", binName="2885 Room 2 Bin 90", user=users[4]},
                    new Lbl_Bin {addDate=new DateTime(2021, 1, 11, 7, 47, 0), qty=2, binID="2885-3-223", binName="2885 Room 3 Bin 223", user=users[4]},
                    new Lbl_Bin {addDate=new DateTime(2021, 2, 25, 7, 47, 0), qty=2, binID="2501-1-12", binName="2501 Room 1 Bin 12", user=users[4]},
                    new Lbl_Bin {addDate=new DateTime(2021, 3, 17, 7, 47, 0), qty=2, binID="2501-1-23", binName="2501 Room 1 Bin 23", user=users[3]},
                    new Lbl_Bin {addDate=new DateTime(2021, 5, 13, 7, 47, 0), qty=2, binID="2885-5-40", binName="2885 Room 5 Bin 40", user=users[3]},
                    new Lbl_Bin {addDate=new DateTime(2021, 6, 12, 7, 47, 0), qty=2, binID="2501-2-22", binName="2501 Room 2 Bin 22", user=users[3]},
                    new Lbl_Bin {addDate=new DateTime(2021, 7, 9, 7, 47, 0), qty=2, binID="2501-2-29", binName="2501 Room 2 Bin 29", user=users[4]},
                    new Lbl_Bin {addDate=new DateTime(2022, 4, 1, 7, 47, 0), qty=2, binID="2885-3-23", binName="2885 Room 3 Bin 23", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2022, 7, 2, 7, 47, 0), qty=2, binID="2501-5-23", binName="2501 Room 5 Bin 23", user=users[5]},
                    new Lbl_Bin {addDate=new DateTime(2022, 9, 18, 7, 47, 0), qty=2, binID="2885-2-334", binName="2885 Room 2 Bin 334", user=users[1]},
                    new Lbl_Bin {addDate=new DateTime(2022, 10, 11, 7, 47, 0), qty=2, binID="2501-3-28", binName="2501 Room 3 Bin 28", user=users[2]},
                    new Lbl_Bin {addDate=new DateTime(2022, 11, 9, 7, 47, 0), qty=2, binID="2885-3-3", binName="2885 Room 3 Bin 3", user=users[2]},
                    new Lbl_Bin {addDate=new DateTime(2023, 2, 23, 7, 47, 0), qty=2, binID="2501-5-66", binName="2501 Room 5 Bin 66", user=users[2]}
                };
                context.AddRange(binLbls);
                context.SaveChanges();
            }
        }
    }

}
