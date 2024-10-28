public class Producer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    
    private string Name { get; set;  }
    private int SleepTime { get; set; }
    private int StartProducing { get; set; }
    private int StopProducing { get; set; }
    
    public Producer(BlockingBuffer sharedLocation, string name, int sleepTime, int startProducing, int stopProducing)
    {
        SharedLocation = sharedLocation;

        Name = name;
        SleepTime = sleepTime;
        StartProducing = startProducing;
        StopProducing = stopProducing;
    }
    
    public async Task Run()
    {
        for (int start = StartProducing; start <= StopProducing; start++)
        {
            await Task.Delay(Generator.Next(SleepTime * 1000));
            SharedLocation.BlockingPut(Name, start);
        }
        Console.WriteLine($"Producer {Name} done producing\nTerminating Producer\n");
    }
}