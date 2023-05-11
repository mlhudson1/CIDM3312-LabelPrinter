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
        
    }
}