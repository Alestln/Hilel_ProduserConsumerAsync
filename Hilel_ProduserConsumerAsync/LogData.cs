namespace Hilel_ProduserConsumerAsync;

public class LogData
{
    private const string FilePath = "log.txt";
    private static readonly object Locker = new();

    public static void Log (string message)
    {
        lock (Locker)
        {
            using var fileStream = new FileStream(FilePath, FileMode.Append);
            using var streamWriter = new StreamWriter(fileStream);
        
            streamWriter.WriteLine(message);
        }
    }
}