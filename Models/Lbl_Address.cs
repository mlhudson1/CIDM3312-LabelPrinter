namespace LabelPrinter{
    public  class Lbl_Address{
        public int Lbl_AddressID{get;set;}
        public User addUser{get;set;} = default!;
        public DateTime addDate{get;set;}
        public bool printed{get;set;} = false;
        public DateTime printDate{get;set;}
        public Printer Printer{get;set;} = default!;
        public int qty{get;set;}
        public string stAddressee{get;set;} = string.Empty;
        public string stAddressLn1{get;set;} = string.Empty;
        public string stAddressLn2{get;set;} =string.Empty;
        public string stCity{get;set;} = string.Empty;
        public string stState{get;set;} = string.Empty;
        public string stZip{get;set;} =string.Empty;
        public string ShipVia{get;set;} =string.Empty;
        public string Tracking{get;set;} = string.Empty;
        public string poNumber{get;set;} = string.Empty;        
        public string PrintError{get;set;} = string.Empty;
        
    }
}