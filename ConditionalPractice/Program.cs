using System;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isGoldCustomer = true;

            if (isGoldCustomer)
                Console.WriteLine("the price is 19.95");
            else
                Console.WriteLine("the price is 29.95");

            int hour = 10;

            if (hour >= 6 && hour < 12)
                Console.WriteLine("good morning");
            else if (hour >= 12 && hour < 16)
                Console.WriteLine("good afternoon");
            else
                Console.WriteLine("good evening");


            Seasons season = Seasons.Autumn;

            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("it is Autumn");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("it is Spring");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("it is Summer");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("it is Winter");
                    break;

            }
        }
    }
}
