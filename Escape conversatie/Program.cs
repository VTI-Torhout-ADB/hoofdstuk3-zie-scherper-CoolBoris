﻿namespace Escape_conversatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personage1 = "Alice";
            string personage2 = "Bob";

            string dialoog = $"Alice: \"Hoe gaat het met je?\"\r\n    Bob: \"Goed, dank je! Hoe gaat het met jou?\"\r\nAlice: \"Ook goed, bedankt dat je het vraagt.\"";

            Console.WriteLine(dialoog);
        }
    }
}
