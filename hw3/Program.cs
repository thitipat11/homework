public class program
{
    public static void Main(string[] args){
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Number: ");
    double number = double.Parse(Console.ReadLine());
    Console.Write("Ownner Name: ");
    string owner = Console.ReadLine();
    Console.Write("Regitered value: ");
    double value = double.Parse(Console.ReadLine());
 
        Console.WriteLine("----------Shop information----------");
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine("Number: {0}",number);
        Console.WriteLine("Owner name: {0}",owner);
        Console.WriteLine("Regitered value: {0}",value);
        Console.WriteLine("------------------------------------");



     double money = 0;
    Money Convertmoney = new Money(money);
    Convertmoney.covertmoney();
    }
    

}