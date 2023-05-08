namespace LabelPrinter{
    public  class Lbl_Work_Order{
        public int Lbl_Work_OrderID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public Printer Printer{get;set;} = default!;
        public int qty{get;set;}
        public string item{get;set;} = string.Empty;
        public string upc{get;set;} = string.Empty;
        public string description{get;set;} = string.Empty;
        public string woNumber{get;set;} = string.Empty;
        public string soNumber{get;set;} = string.Empty;
        public DateTime dueDate{get;set;}
        public string PrintError{get;set;} = string.Empty;
        
    }
}