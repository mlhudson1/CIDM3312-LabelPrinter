namespace LabelPrinter{
    public  class Lbl_Item{
        public int Lbl_ItemID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public int qty{get;set;}
        public string item{get;set;} = string.Empty;
        public string upc{get;set;} = string.Empty;
        public string description{get;set;} = string.Empty;
        public string PrintError{get;set;} = string.Empty;
        public List<UserLbl_Item> UserLbl_Items{get;set;} = default!;
    }

    public class UserLbl_Item{
        public int Lbl_ItemID {get;set;}
        public int UserID{get;set;}
        public Lbl_Item Lbl_Item {get;set;} = default!;
        public User User{get;set;} = default!;
    }
}