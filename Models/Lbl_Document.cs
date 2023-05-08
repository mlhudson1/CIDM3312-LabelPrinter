namespace LabelPrinter{
    public  class Lbl_Document{
        public int Lbl_DocumentID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public Printer Printer{get;set;} = default!;
        public string TransactionID{get;set;} = string.Empty;
        public string TransactionType{get;set;} = string.Empty;
        public string CustomerNumber{get;set;} = string.Empty;
        public string PrintError{get;set;} = string.Empty;
        
    }
}