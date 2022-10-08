// See https://aka.ms/new-console-template for more information
    class dhtm{
        public int luong{get;set;}
        public string cv{get;set;}

        public void getLuong(){
            Console.WriteLine($"Luong {luong}");
        }

    }
    class nv: dhtm{
        public string name;
        public nv(string name,int luong){
            this.name=name;
            this.luong=luong;
        }

        public void showname(){
            Console.WriteLine(name);
        }
        public new void getLuong(){
            Console.WriteLine($"Luong la {luong}");
        }
        public void showLuong(){
            base.getLuong();
            getLuong();
        }

    }
class Program{
    public static void Main(string[] args)
    {
        nv a=new nv("Nguyen van a",112233);
        a.showname();
        a.getLuong();
        a.showLuong();

    }
}
