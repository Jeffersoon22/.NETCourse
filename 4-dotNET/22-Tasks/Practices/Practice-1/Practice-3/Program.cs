using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int final = Processing().Result;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Total bytes returned: {final}");
            Console.ReadKey();
        }

        private static async Task<int> ProcessApiAsync(string url)
        {
            HttpClient client = new HttpClient();

            Task<byte[]> bites = client.GetByteArrayAsync(url);
            byte[] bite = await bites;
            int lenght = bite.Length;

            return lenght;
        }

        private static async Task<int> Processing()
        {
            int firstUrlLenght = await ProcessApiAsync("http://get-simple.info/api/start/");
            int secondUrlLenght = await ProcessApiAsync("http://get-simple.info/api/security/");
            int thirdUrlLenght = await ProcessApiAsync("http://get-simple.info/api/extend/?id=33");

            Console.WriteLine("http://get-simple.info/api/security/ \t\t" + firstUrlLenght);
            Console.WriteLine("http://get-simple.info/api/extend/ \t\t" + secondUrlLenght);
            Console.WriteLine("http://get-simple.info/api/extend/?id=33 \t" + thirdUrlLenght);

            int sum = firstUrlLenght + secondUrlLenght + thirdUrlLenght;

            return sum;

        }
    }
}
