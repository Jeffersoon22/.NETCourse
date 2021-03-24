using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tutorial01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsyncStuffInMain().ConfigureAwait(false).GetAwaiter().GetResult();
            Task.Run(() => RunAsyncStuffInMain());
        }
        static async Task RunAsyncStuffInMain()
        {
            string result1 = await ProcessApiAsync("http://get-simple.info/api/start/ ");
            Task<string> downloadString2 = ProcessApiAsync("http://get-simple.info/api/extend/?id=1 ");
            string result2 = await downloadString2;
            System.Console.WriteLine($"http://get-simple.info/api/start/         {result1}");
            System.Console.WriteLine($"http://get-simple.info/api/extend/?id=1   {result2}");
        }
        static async Task<string> ProcessApiAsync(string url)
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetStringAsync(url);
            return res;
        }
    }
}
