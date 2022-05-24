using System.Net;
using Newtonsoft.Json;

namespace Currency
{
    class Program
    {
        static void Main()
        {
            
            Rub();
            Console.WriteLine($"------------------------------------------------------------------------------------------------");
            Crypta();

        }

        public static void Rub()
        {
            string url = @"https://cdn.cur.su/api/cbr.json";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);

            WebResponse response = request.GetResponse();
            string respon;
            using(StreamReader read = new StreamReader(response.GetResponseStream()))
            {
                
                 respon = read.ReadToEnd();

                Rates info = JsonConvert.DeserializeObject<Rates>(respon);
                Console.WriteLine($"{info.rates.USD}$ = {info.rates.RUB}.");
                
            }
            response.Close();
        }
        public static void Crypta()
        {
            string url = @"https://api.coingecko.com/api/v3/coins/markets?vs_currency=USD&ids=bitcoin%2Cethereum&per_page=100&page=1&sparkline=false";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            WebResponse response = request.GetResponse();

             string respon;
            using(StreamReader read = new StreamReader(response.GetResponseStream()))
            {
                
                 respon = read.ReadToEnd();

                var obj = JsonConvert.DeserializeObject<List<Welcome>>(respon);
                Console.WriteLine($"{obj[0].Name}: Цена: {obj[0].CurrentPrice}$, Изменения за 24 часа: {obj[0].PriceChange24H}$, Рыночная капитализация: {obj[0].MarketCap}.");
                Console.WriteLine($"{obj[1].Name}: Цена: {obj[1].CurrentPrice}$, Изменения за 24 часа: {obj[1].PriceChange24H}$, Рыночная капитализация: {obj[1].MarketCap}.");
                
            }
            response.Close();

        }
    }
}
