using Hilel_ProduserConsumerAsync.Entities;

namespace Hilel_ProduserConsumerAsync;

class Program
{
    static async Task Main(string[] args)
    {
        var buffer = new Buffer();
        var producer = new Producer(buffer);
        var consumer = new Consumer(buffer);

        var producerTasks = new List<Task>();
        var consumerTasks = new List<Task>();
        
        for (var i = 0; i < 100; i++)
        {
            producerTasks.Add(producer.ProduceData());
            consumerTasks.Add(consumer.ConsumeData());
        }

        await Task.WhenAll(producerTasks);
        await Task.WhenAll(consumerTasks);
    }
}