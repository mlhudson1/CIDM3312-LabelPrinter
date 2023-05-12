using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LabelPrinter.Models{
    public  class Lbl_Item{
        public int Lbl_ItemID{get;set;}
        public DateTime addDate{get;set;}
        public int qty{get;set;}
        public string item{get;set;} = string.Empty;
        public string upc{get;set;} = string.Empty;
        public string description{get;set;} = string.Empty;
        public User user{get;set;}= default!;  
    }
}