// See https://aka.ms/new-console-template for more information
class Program {

    public class product{
       public int price;
       public string name;
       public string getInfo(){
        return $"ten san pham {name}, gia: {price}";
       }
       public string info{
        get{
            return $"{name},{price}";
        }
       }
       public product(string name,int price){
        this.name = name;
        this.price=price;
       }
    }

    public static void Main(string[] args)
{
    product sp1=new product("",0);
    sp1.name = "may tinh";
    sp1.price=100002;
    product sp2=new product("laptop",12345);
    sp2=sp1;
    sp2.name="iphone 13";
    Console.WriteLine(sp1.getInfo());
    Console.WriteLine(sp2.getInfo());
    Console.WriteLine(sp2.info);

}
}
