public class Consumer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    
    public Consumer(BlockingBuffer sharedLocation)
    {
        SharedLocation = sharedLocation;
    }
    
    public async Task Run()
    {
        int sum = 0;
        for (int count = 1; count <= 10; count++)
        {
            await Task.Delay(Generator.Next(4000));
            sum += SharedLocation.BlockingGet();
        }
        Console.WriteLine(
            "\nConsumer read values totaling {0}\nTerminating Consumer\n",
            sum);
    }
}