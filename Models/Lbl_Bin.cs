using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LabelPrinter.Models{
    public  class Lbl_Bin{
        public int Lbl_BinID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public int qty{get;set;}
        public string binID{get;set;} =string.Empty;
        public string binName{get;set;} = string.Empty;
        public DateTime dueDate{get;set;}
        public string PrintError{get;set;} = string.Empty;
        public List<UserLbl_Bin> UserLbl_Bins{get;set;} = default!;
        
    }

    public class UserLbl_Bin{
        public int Lbl_BinID {get;set;}
        public int UserID{get;set;}
        public Lbl_Bin Lbl_Bin {get;set;} = default!;
        public User User{get;set;} = default!;
    }
}