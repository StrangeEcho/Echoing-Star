using System.Collections.Concurrent;

public class BlockingBuffer
{
    private BlockingCollection<int> BColl;
    
    public BlockingBuffer(int bufferSize)
    {
        BColl = new BlockingCollection<int>(bufferSize);
    }
    
    public void BlockingPut(string name, int value)
    {
        BColl.Add(value);
        Console.WriteLine("Producer {0} writes {1}\tBuffer cells occupied: {2}",
            name, value, BColl.Count);
    }

    public int BlockingGet(string name)
    {
        int readValue = BColl.Take();
        Console.WriteLine("Consumer {0} reads {1}\tBuffer cells occupied: {2}",
            name, readValue, BColl.Count);
        return readValue;
    }
}