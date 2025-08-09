using AsyncAndMultithreading.Services;

Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");

await AsyncIOService.DownloadDataAsync();

await CPUboundAsync.HeavyComputationAsync();

Console.WriteLine("Done!");