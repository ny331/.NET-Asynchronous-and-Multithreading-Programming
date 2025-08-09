using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndMultithreading.Services
{
    public class AsyncIOService
    {
        public async static Task DownloadDataAsync()
        {
            Console.WriteLine($"Download Start Thread: {Thread.CurrentThread.ManagedThreadId}");
            using var client = new HttpClient();
            string data = await client.GetStringAsync("https://dummyjson.com/test");
            Console.WriteLine($"Download Completed Thread: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Data length: {data.Length}");
        }
    }
}
