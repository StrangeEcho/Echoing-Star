using System.Collections.Concurrent;

public class BlockingBuffer
{
    private BlockingCollection<int> BColl;
    
    public BlockingBuffer()
    {
        BColl = new BlockingCollection<int>(10);
    }
    
    public void BlockingPut(int value)
    {
        BColl.Add(value);
        Console.WriteLine("Producer writes {0}\tBuffer cells occupied: {1}",
            value, BColl.Count);
    }

    public int BlockingGet()
    {
        int readValue = BColl.Take();
        Console.WriteLine("Consumer reads {0}\tBuffer cells occupied: {1}",
            readValue, BColl.Count);
        return readValue;
    }
}