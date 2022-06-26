using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Stack
        {
            public string StockNames;
            public int NumberOfShares;
            public double sharePrice;

            public Stack(string StockNames,int NumberOfShares,double shareprice)
            {
                this.StockNames = StockNames;
                this.NumberOfShares = NumberOfShares;
                this.sharePrice = sharePrice;
            }
        }

        public class StockPortfolio
        {
            
            public static double CalculateValue(String stockNames,int NumberOfShares,double shareprice)
            {
                
                double Value = NumberOfShares * shareprice;
                return Value;

            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number of stockes");
            int NumberofStocks = Int32.Parse(Console.ReadLine());
            double totalValue = 0.0;
            double value = 0.0;
            for (int i=1;i<=NumberofStocks;i++)
            {
                Console.WriteLine("Enter the stock name");
                String name = Console.ReadLine();

                Console.WriteLine("emter number of shares");
                int numberOfshares = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter price of each stock");
                float price = float.Parse(Console.ReadLine());

                value = StockPortfolio.CalculateValue(name, numberOfshares, price);
                Console.WriteLine("value is " + value);
                totalValue = totalValue + value;

            }

            
            Console.WriteLine("total value is " + totalValue);
        }
    }
}
