namespace Hilel_ProduserConsumerAsync.Entities;

public class Producer
{
    private readonly Buffer _buffer;

    public Producer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public async Task ProduceData()
    {
        var data = Random.Shared.Next(100);
        await _buffer.Produce(data);
        LogData.Log($"Produce data: {data}");
        await Task.Delay(Random.Shared.Next(1000));
    }
}