// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string  sv1="nguyen van a";
string sv2="nguyen van b";
string sv3="nguyen van c";
Console.WriteLine(sv1+sv2+sv3);
string[] sv;
sv=new string[5];
sv[0]="A";
sv[1]="B";
sv[2]="C";
for(int i=0;i<3;i++){
    Console.WriteLine(sv[i]);
}
foreach(var a in sv){
    Console.WriteLine(a);
}

int[] number={1,2,3,4,5,8,6,9};
Console.WriteLine($"So phan tu:{number.Length}");
Console.WriteLine($"Phan tu lon nhat:{number.Max()}");
Console.WriteLine($"Phan tu lon nhat:{number.Min()}");
Array.Sort(number);
foreach(var a in number){
    Console.WriteLine(a);
}
double[,] number2=new double [2,3]{{2,3,4},{5,6,7},};
int hang=2;
int cot=3;
for(int i=0;i<hang;i++){
    for(int j=0;j<cot;j++){
        Console.Write(number2[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

