using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LabelPrinter.Models{
    public  class Lbl_Bin{
        public int Lbl_BinID{get;set;}
        public DateTime addDate{get;set;}
        public int qty{get;set;}
        public string binID{get;set;} =string.Empty;
        public string binName{get;set;} = string.Empty;
        public User user{get;set;}= default!;     
    }

}