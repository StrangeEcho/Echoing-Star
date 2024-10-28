public class Consumer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    
    private string Name { get; set; }
    private int SleepTime { get; set; }
    private int StartProducing { get; set; }
    private int StopProducing { get; set; }
    
    public Consumer(BlockingBuffer sharedLocation, string name, int sleepTime, int startProducing, int stopProducing)
    {
        SharedLocation = sharedLocation;

        Name = name;
        SleepTime = sleepTime;
        StartProducing = startProducing;
        StopProducing = stopProducing;
    }
    
    public async Task Run()
    {
        int sum = 0;
        for (int count = StartProducing; count <= 10; count++)
        {
            await Task.Delay(Generator.Next(SleepTime * 1000));
            sum += SharedLocation.BlockingGet(Name);
        }
        Console.WriteLine(
            "\nConsumer {0} read values totaling {1}\nTerminating Consumer\n",
            Name, sum);
    }
}