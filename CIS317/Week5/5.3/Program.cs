public class AsyncDemo
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 5 Concurrency GP\n");
        BlockingBuffer sharedLocation = new BlockingBuffer();
        Task producer = new Producer(sharedLocation).Run();
        Task consumer = new Consumer(sharedLocation).Run();
        
        await producer;
        await consumer;
    }
}