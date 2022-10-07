namespace CS03_Class{
class Program
    {
       static void Main(string[] args)
       {
       vukhi sungluc; // null
        sungluc =new vukhi(); // ten lop
       vukhi sungtruong;
       sungtruong=new vukhi("AK47");
       sungluc.setDamage(20);
       int b=sungluc.getDamage();
       Console.WriteLine(b);
       
    }
    }
}
