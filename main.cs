using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AskAndPrintName();
            FailCodeCheck(1, "'5", 3);
        }

        static void AskAndPrintName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }

        static int Task FailCodeCheck(int customerId, string badCodeCanBeHere, int? maybeInt)
        {
            int a=4;
            
            var requestRoutingRule = $"SELECT * FROM routing.ProcessorRoutingRule where MerchantId={maybeInt}";
            var merchantProcessor = $"SELECT* FROM r3.MerchantProcessor where MerchantId = {maybeInt}" + badCodeCanBeHere;

            int badInt = Convert.ToInt32(badCodeCanBeHere);

            int newInt = Convert.ToInt32(maybeInt) + badInt;

            double dontDothis = 5/Convert.ToInt32(maybeInt);
            dontDothis += badInt + newInt;
            Console.WriteLine("Fail=" + newInt);
            Console.WriteLine("Fail=" + merchantProcessor);

            if (maybeInt > 3){
                return 6;
            }
            else 
                return maybeInt;
        }
    }
}
