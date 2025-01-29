namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double RAMinMB = Environment.WorkingSet / (1024.0 * 1024.0); 
            double RAMinGB = Environment.WorkingSet / (1024.0 * 1024.0 * 1024.0);
            Console.WriteLine($"Systeeminformatie voor {Environment.UserName} op {Environment.MachineName}:\r\n---------------------------------------------------\r\n    Aantal processors: {Environment.ProcessorCount}\r\n    64-bit besturingssysteem: {Environment.Is64BitOperatingSystem}\r\n    Huidige geheugengebruik: {Math.Round(RAMinMB,2)}MB ({Math.Round(RAMinGB, 2)} GB)\r\n---------------------------------------------------");
        }
    }
}
