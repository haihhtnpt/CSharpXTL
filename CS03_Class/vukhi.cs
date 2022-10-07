namespace CS03_Class{
class vukhi{
    int dmg;

    public vukhi(){
        Console.WriteLine("khoi tao");
    }
    public vukhi(string a){
        Console.WriteLine(a);
    }
    public void setDamage(int dmg){
        this.dmg=dmg;
    }
    public int getDamage(){
        return this.dmg;
    }
    
}
}