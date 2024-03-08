using System.Collections.Concurrent;

namespace Hilel_ProduserConsumerAsync;

public class Buffer
{
    private readonly ConcurrentQueue<int> _bufferQueue = new();

    public Task Produce(int data)
    {
        _bufferQueue.Enqueue(data);
        
        return Task.CompletedTask;
    }

    public bool Consume(out int data)
    {
        return _bufferQueue.TryDequeue(out data);
    }
}