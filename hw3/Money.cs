public class Money
{
   private double ratio;
    public Money(double ratio){
        this.ratio = ratio;
    }
    public void covertmoney(){
        Console.WriteLine("input money:");
            string input = Console.ReadLine();
            double money = Convert.ToInt32(input);
            double change;
            double thousand;
            double fiveHundred;
            double hundred;
            double fifty;
            double twenty;
            double ten;
            double one;
            double zeropointfive;
            double zerotwofive;

            thousand = money / 1000;
            change = money % 1000;

            fiveHundred = change / 500;
            change = change % 500;

            hundred = change / 100;
            change = change % 100;

            fifty = change / 50;
            change = change % 50;

            twenty = change / 20;
            change = change % 20;

            ten = change / 10;
            change = change % 10;

            one = change / 1;

            zeropointfive = change / 0.5;
            change = change % 0.5;

            zerotwofive = change / 0.25;
            change = change % 0.25;


            Console.WriteLine("1000 Baht :{0}", thousand);
            Console.WriteLine("500 Baht :{0}", fiveHundred);
            Console.WriteLine("100 Baht :{0}", hundred);
            Console.WriteLine("50 Baht :{0}", fifty);
            Console.WriteLine("20 Baht :{0}", twenty);
            Console.WriteLine("10 Baht :{0}", ten);
            Console.WriteLine("1 Baht :{0}", one);
            Console.WriteLine("0.5 Baht :{0}", zeropointfive);
            Console.WriteLine("0.25 Baht :{0}",zerotwofive);

    }
}


