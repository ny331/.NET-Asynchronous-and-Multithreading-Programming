using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndMultithreading.Services
{
    public class CPUboundAsync
    {
        public async static Task HeavyComputationAsync()
        {
            Console.WriteLine($"Computation Start Thread: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(() =>
            {
                Console.WriteLine($"Inside Task.Run Thread: {Thread.CurrentThread.ManagedThreadId}");
                long sum = 0;
                for (int i = 0; i < 5_000_000; i++)
                    sum += i;
                Console.WriteLine($"Computation Finished, sum={sum}");
            });
            Console.WriteLine($"Computation Completed Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
