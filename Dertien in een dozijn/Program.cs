namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124;

            int aantalDozen = aantalEieren / doosGrootte;
            int rest = aantalEieren % doosGrootte;

            Console.WriteLine($"{aantalEieren} eieren passen in {aantalDozen} dozen van doosgrootte: {doosGrootte}. Daarbij zal je nog {rest} eieren over hebben.");

        }
    }
}
