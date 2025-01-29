namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je naam? ");
            string naam = Console.ReadLine();
            Console.Write("Kies een zelfstandig naamwoord: ");
            string naamwoord = Console.ReadLine();
            Console.Write("Kies een adjectief: ");
            string adjectief = Console.ReadLine();
            Console.Write("Kies een werkwoord: ");
            string werkwoord = Console.ReadLine();

            Console.WriteLine($"\nOp een dag ging {naam} naar de AP Hogeschool. Hij zag daar een {adjectief} {naamwoord} en vond dat zo grappig dat hij begon te {werkwoord}.");
        }
    }
}
