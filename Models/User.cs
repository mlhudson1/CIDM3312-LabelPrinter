using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace LabelPrinter.Models{
    public class User{
        public int UserID{get;set;}
        public string UserName{get;set;} = string.Empty;
        public string Password{get;set;} = string.Empty;
        public string FirstName{get;set;} = string.Empty;
        public string LastName{get;set;} = string.Empty;
        public string Role{get; set;} = string.Empty;
        public List<UserLbl_Item> UserLbl_Items{get;set;} = default!;

        public List<UserLbl_Bin> UserLbl_Bins{get;set;} = default!;
    }
}