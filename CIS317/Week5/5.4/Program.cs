public class MainProgram
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 5 PA: Multiple Producers & Consumers\n");
        BlockingBuffer sharedLocation = new BlockingBuffer(5);

        Task p1 = new Producer(sharedLocation, "P1", 2, 10, 16).Run();
        Task p2 = new Producer(sharedLocation, "P2", 3, 25, 29).Run();
        Task p3 = new Producer(sharedLocation, "P3", 1, 30, 39).Run();

        Task c1 = new Consumer(sharedLocation, "C1", 3, 1, 9).Run();
        Task c2 = new Consumer(sharedLocation, "C2", 2, 1, 13).Run();

        await p1;
        await p2;
        await p3;

        await c1;
        await c2;


    }
}