
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
                    new Lbl_Item {qty=1,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base"},
                    new Lbl_Item {qty=1,item="74951",upc="703673749510",description="Visionary Move Mobile Glassboard - Magnetic 4' x 6'"},
                    new Lbl_Item {qty=4,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'"},
                    new Lbl_Item {qty=1,item="27692",upc="717641276922",description="Trend Podium Desk"},
                    new Lbl_Item {qty=1,item="27675",upc="717641276250",description="iTeach Flat Panel Cart"},
                    new Lbl_Item {qty=8,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart"},
                    new Lbl_Item {qty=1,item="221OH-03",upc="703673838740",description="Tuff-Rite Markerboard - Origin Trim (Mahogany) - 4' x 8' - dot grid"},
                    new Lbl_Item {qty=1,item="202AP-25",upc="703673284004",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 16'"},
                    new Lbl_Item {qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'"},
                    new Lbl_Item {qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard"},
                    new Lbl_Item {qty=1,item="1005",upc="703673371322",description="Basic Easel - Hardboard"},
                    new Lbl_Item {qty=1,item="1000",upc="703673371315",description="Ideal Easel"},
                    new Lbl_Item {qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'"},
                    new Lbl_Item {qty=1,item="221OH-03",upc="703673838740",description="Tuff-Rite Markerboard - Origin Trim (Mahogany) - 4' x 8' - dot grid"},
                    new Lbl_Item {qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'"},
                    new Lbl_Item {qty=8,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'"},
                    new Lbl_Item {qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart"},
                    new Lbl_Item {qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard"},
                    new Lbl_Item {qty=7,item="27675",upc="717641276250",description="iTeach Flat Panel Cart"},
                    new Lbl_Item {qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'"},
                    new Lbl_Item {qty=1,item="27692",upc="717641276922",description="Trend Podium Desk"},
                    new Lbl_Item {qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=2,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base"},
                    new Lbl_Item {qty=1,item="202AN-25",upc="703673284028",description="Porcelain Markerboard - Deluxe Aluminum Trim - 5' x 12'"},
                    new Lbl_Item {qty=1,item="27675",upc="717641276250",description="iTeach Flat Panel Cart"},
                    new Lbl_Item {qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'"},
                    new Lbl_Item {qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart"},
                    new Lbl_Item {qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard"},
                    new Lbl_Item {qty=6,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=1,item="90276-4623-PL",upc="703673368384",description="Trend Flipper 60 x 24 Table w/Gormmet - Graphite Nebula Top - Platinum Edgeband - Black Base"},
                    new Lbl_Item {qty=1,item="27692",upc="717641276922",description="Trend Podium Desk"},
                    new Lbl_Item {qty=1,item="3208H-105",upc="703673835947",description="Reboard Rubbertak Tackboard - Ultra Trim (Black) - 4' x 8'"},
                    new Lbl_Item {qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=2,item="27675",upc="717641276250",description="iTeach Flat Panel Cart"},
                    new Lbl_Item {qty=1,item="202AG-25",upc="703673291002",description="Porcelain Markerboard - Deluxe Aluminum Trim - 4' x 6'"},
                    new Lbl_Item {qty=1,item="27608",upc="717641276083",description="Xtra Wide Presentation Cart"},
                    new Lbl_Item {qty=1,item="1006",upc="703673371339",description="Basic Easel - Markerboard"},
                    new Lbl_Item {qty=1,item="74951",upc="703673749510",description="Visionary Move Mobile Glassboard - Magnetic 4' x 6'"},
                };
                context.AddRange(itmLbls);
                
                List<Lbl_Bin> binLbls = new List<Lbl_Bin>{
                    new Lbl_Bin { qty=2, binID="2885-5-23", binName="2885 Room 5 Bin 23"},
                    new Lbl_Bin {qty=2, binID="2885-2-48", binName="2885 Room 3 Bin 48"},
                    new Lbl_Bin { qty=2, binID="2885-1-90", binName="2885 Room 1 Bin 90"},
                    new Lbl_Bin { qty=2, binID="2501-4-39", binName="2501 Room 4 Bin 39"},
                    new Lbl_Bin {qty=2, binID="2501-2-22", binName="2501 Room 2 Bin 22"},
                    new Lbl_Bin { qty=2, binID="2501-2-23", binName="2501 Room 2 Bin 23"},
                    new Lbl_Bin { qty=2, binID="2501-4-40", binName="2501 Room 4 Bin 40"},
                    new Lbl_Bin { qty=2, binID="2885-2-90", binName="2885 Room 2 Bin 90"},
                    new Lbl_Bin { qty=2, binID="2885-3-223", binName="2885 Room 3 Bin 223"},
                    new Lbl_Bin { qty=2, binID="2501-1-12", binName="2501 Room 1 Bin 12"},
                    new Lbl_Bin { qty=2, binID="2501-1-23", binName="2501 Room 1 Bin 23"},
                    new Lbl_Bin { qty=2, binID="2885-5-40", binName="2885 Room 5 Bin 40"},
                    new Lbl_Bin { qty=2, binID="2501-2-22", binName="2501 Room 2 Bin 22"},
                    new Lbl_Bin { qty=2, binID="2501-2-29", binName="2501 Room 2 Bin 29"},
                    new Lbl_Bin { qty=2, binID="2885-3-23", binName="2885 Room 3 Bin 23"},
                    new Lbl_Bin { qty=2, binID="2501-5-23", binName="2501 Room 5 Bin 23"},
                    new Lbl_Bin { qty=2, binID="2885-2-334", binName="2885 Room 2 Bin 334"},
                    new Lbl_Bin { qty=2, binID="2501-3-28", binName="2501 Room 3 Bin 28"},
                    new Lbl_Bin { qty=2, binID="2885-3-3", binName="2885 Room 3 Bin 3"},
                    new Lbl_Bin { qty=2, binID="2501-5-66", binName="2501 Room 5 Bin 66"}
                };
                context.AddRange(binLbls);
                /*
                List<UserLbl_Bin> usrBinPrntd = new List<UserLbl_Bin>{
                    new UserLbl_Bin{UserID=1, Lbl_BinID=1},
                    new UserLbl_Bin{UserID=2, Lbl_BinID=2},
                    new UserLbl_Bin{UserID=3, Lbl_BinID=3},
                    new UserLbl_Bin{UserID=4, Lbl_BinID=4},
                    new UserLbl_Bin{UserID=5, Lbl_BinID=5},
                    new UserLbl_Bin{UserID=1, Lbl_BinID=6},
                    new UserLbl_Bin{UserID=2, Lbl_BinID=7},
                    new UserLbl_Bin{UserID=3, Lbl_BinID=8},
                    new UserLbl_Bin{UserID=5, Lbl_BinID=9},
                    new UserLbl_Bin{UserID=4, Lbl_BinID=10},
                    new UserLbl_Bin{UserID=2, Lbl_BinID=11},
                    new UserLbl_Bin{UserID=3, Lbl_BinID=12},
                    new UserLbl_Bin{UserID=5, Lbl_BinID=13},
                    new UserLbl_Bin{UserID=4, Lbl_BinID=14},
                    new UserLbl_Bin{UserID=2, Lbl_BinID=15},
                    new UserLbl_Bin{UserID=3, Lbl_BinID=16},
                    new UserLbl_Bin{UserID=5, Lbl_BinID=17},
                    new UserLbl_Bin{UserID=3, Lbl_BinID=18},
                    new UserLbl_Bin{UserID=4, Lbl_BinID=19},
                    new UserLbl_Bin{UserID=4, Lbl_BinID=20}                    
                };
                context.AddRange(usrBinPrntd);

                List<UserLbl_Item> usrItmPrntd = new List<UserLbl_Item>{
                    new UserLbl_Item{UserID=1, Lbl_ItemID=1},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=2},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=3},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=4},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=5},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=6},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=7},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=8},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=9},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=10},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=11},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=12},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=13},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=14},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=15},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=16},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=17},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=18},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=19},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=20},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=21},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=22},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=23},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=24},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=25},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=26},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=27},
                    new UserLbl_Item{UserID=5, Lbl_ItemID=28},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=29},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=30},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=31},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=32},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=33},
                    new UserLbl_Item{UserID=3, Lbl_ItemID=34},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=35},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=36},
                    new UserLbl_Item{UserID=2, Lbl_ItemID=37},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=38},
                    new UserLbl_Item{UserID=1, Lbl_ItemID=39},
                    new UserLbl_Item{UserID=4, Lbl_ItemID=40}
                };
                context.AddRange(usrItmPrntd);*/
                context.SaveChanges();
            }
        }
    }

}
