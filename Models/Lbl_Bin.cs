namespace LabelPrinter{
    public  class Lbl_Bin{
        public int Lbl_BinID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public Printer Printer{get;set;} = default!;
        public int qty{get;set;}
        public string binID{get;set;} =string.Empty;
        public string binName{get;set;} = string.Empty;
        public DateTime dueDate{get;set;}
        public string PrintError{get;set;} = string.Empty;
        
    }
}