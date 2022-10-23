// See https://aka.ms/new-console-template for more information
namespace SaleTicket{
    class inforTicket{
        string name;
        string address;
        string id;
        DateTime date;
        string typeClass;
        public inforTicket(string name,string address,string id,DateTime date,string typeClass){
            this.name=name;
            this.address=address;
            this.id=id;
            this.date=date;
            this.typeClass=typeClass;
        }

        public string Name{
            set{name=value;}
            get{return name;}
            
        }
        public string Address{
            set{address=value;}
            get{return address;}

        }
        public string Id{
            set{id=value;}
            get{return id;}
        }
        public string TypeClass{
            set{typeClass=value;}
            get{return typeClass;}
        }
        public DateTime Date{
            set{date=value;}
            get{return date;}
        }
}
class Program{
    public static void Main(string[] args)
{
    inforTicket a=new inforTicket("Nguyen Ngoc Haai","PT","1234567",new DateTime(11,10,2002),"Thuong gia");
    Console.WriteLine(a.Address+a.Date);
}
}

}
    


