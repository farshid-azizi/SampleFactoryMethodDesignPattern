// See https://aka.ms/new-console-template for more information
using SampleFactoryMethodDesignPattern;
   
        String cardtype = "";
        Console.WriteLine("Enter your salary :");
        double salary = Convert.ToDouble(Console.ReadLine());
        if ((salary < 1000))
        {
            cardtype = "Silver";
        }
        else if ((salary < 500000 && salary > 10000))
        {
            cardtype = "Gold";
        }
        else
        {
            cardtype = "Platinum";
        }

        CardType mycard = Factory.Getcard(cardtype);
        Console.WriteLine(mycard);
    
