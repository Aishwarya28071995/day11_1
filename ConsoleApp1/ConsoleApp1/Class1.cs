using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class StockAccount
    {

        public class CompanyShares
        {
            public string stockSymbol;
            public int Numberofshares;
            public String dateTime;


            public CompanyShares(String symbol, int numberofShares, String datetime)
            {
                this.stockSymbol = symbol;
                this.Numberofshares = numberofShares;
                this.dateTime = datetime;

            }
        }
        public class Stock
        {
            public String stockNames;
            public int NumberofShares;
            public float shareprice;
            public String symbol;

            public Stock(String stockNames, int NumberOfShares, float sharePrice, String symbol)
            {
                this.stockNames = stockNames;
                this.NumberofShares = NumberofShares;
                this.shareprice = sharePrice;
                this.symbol = symbol;
            }
        }

        public static List<Stock> stocks = null;
        public static List<CompanyShares> companyShares = new List<CompanyShares>()
            {
            new CompanyShares("abc",2,"12062021")
            };


        public StockAccount()
        {
            stocks = new List<Stock>()
            {
                new Stock("reliance",2,100.5f,"abc"),
                new Stock("Dmart",2,105.5f,"xyz"),
            };

            var serialize = JsonConvert.SerializeObject(stocks);
            Console.WriteLine(serialize);

            var deserializeObject = "[{ \"stockNames\":\"reliance\",\"NumberofShares\":0,\"shareprice\":100.5,\"symbol\":\"abc\"},{ \"stockNames\":\"Dmart\",\"NumberofShares\":0,\"shareprice\":105.5,\"symbol\":\"xyz\"}]";
            List<Stock> stocks1 = JsonConvert.DeserializeObject<List<Stock>>(deserializeObject);

            StockAccount account = new StockAccount();
            account.valueOf(stocks1);
        }
        double valueOf(List<Stock> stock)

        {
            double value = 0;
            double totalprice = 0;
            foreach(var item in stock)
            {
                totalprice = item.shareprice * item.NumberofShares;
                value = value + totalprice;
            }
            return value;

        }

        void buy(int amount,String symbol, List<Stock> stock)
        {
            foreach(var item in stock)
            {
                if(item.symbol == symbol)
                {
                    item.shareprice = item.shareprice + amount;
                }
            }


        }

        void sell(int amount, String symbol, List<Stock> stock)
        {
            foreach (var item in stock)
            {
                if(item.symbol == symbol)
                {
                    item.shareprice = item.shareprice - amount;
                }
            }
        } 

        void Save(List<Stock> stocks)
        {
            var serialize = JsonConvert.SerializeObject(stocks);
            Console.WriteLine(serialize);

            var deserializeObject = "[{ \"stockNames\":\"reliance\",\"NumberofShares\":0,\"shareprice\":100.5,\"symbol\":\"abc\"},{ \"stockNames\":\"Dmart\",\"NumberofShares\":0,\"shareprice\":105.5,\"symbol\":\"xyz\"}]";
            List<Stock> stocks1 = JsonConvert.DeserializeObject<List<Stock>>(deserializeObject);

            StockAccount account = new StockAccount();
        }

        void PrintReport(List<Stock> stock)
        {
              foreach(var item in stock)
            {
                Console.WriteLine(item.symbol);
                Console.WriteLine(item.shareprice);
                Console.WriteLine(item.NumberofShares);
            }

        }
    }
}
