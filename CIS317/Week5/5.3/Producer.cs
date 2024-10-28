public class Producer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    
    public Producer(BlockingBuffer sharedLocation)
    {
        SharedLocation = sharedLocation;
    }
    
    public async Task Run()
    {
        for (int count = 1; count <= 10; count++)
        {
//Sleep for a random time up to 1 second
            await Task.Delay(Generator.Next(1000));
            SharedLocation.BlockingPut(count);
        }
        Console.WriteLine("Producer done producing\nTerminating Producer\n");
    }
}