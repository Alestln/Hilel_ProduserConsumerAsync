namespace Hilel_ProduserConsumerAsync.Entities;

public class Consumer
{
    private readonly Buffer _buffer;

    public Consumer(Buffer buffer)
    {
        _buffer = buffer;
    }

    public async Task ConsumeData()
    {
        while (true)
        {
            if (_buffer.Consume(out var data))
            {
                LogData.Log($"Consume data: {data}");
                await Task.Delay(Random.Shared.Next(1000));
            }
            else
            {
                // Some logic for waiting result
                await Task.Delay(Random.Shared.Next(1000));
                continue;
            }

            break;
        }
    }
}