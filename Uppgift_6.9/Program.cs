using System;
namespace Uppgift_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "3")
            {
                Console.WriteLine("1: är n ett primtal?");
                Console.WriteLine("2: antal primtal mindre än n");
                Console.WriteLine("3: avsluta programmet");
                svar = Console.ReadLine();
                
                switch (svar)
                {
                    case "1":
                        MenyÄrPrim();
                        break;

                    case "2":
                        MenyNrPrimtalUnder();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Ogiltigt alternativ, försök igen");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void MenyÄrPrim()
        {
            Console.WriteLine("Skriv in ett tal att primkollas");
            int tal = ReadInt();

            Console.WriteLine($"{tal} är{(ÄrPrimt(tal) ? " " : " inte ")}primt.");
        }
        static void MenyNrPrimtalUnder()
        {
            Console.WriteLine("Skriv in ett heltal för att veta hur många primtal som finns under det");
            int tal = ReadInt();

            Console.WriteLine($"Det finns {NrPrimtalUnder(tal)} primtal under {tal}.");
        }
        /// <summary>
        /// Returnerar antalet primtal under talet n
        /// </summary>
        /// <param name="n">Talet n</param>
        /// <returns>Hur många primtal som finns under n</returns>
        static int NrPrimtalUnder(int n)
        {
            int summa = 0;
            for (int i = 2; i < n; i++)
            {
                if (ÄrPrimt(i))
                {
                    summa++;
                }
            }
            return summa;
        }
        /// <summary>
        /// Kollar om ett tal är primt
        /// </summary>
        /// <param name="tal">Talet som ska kollas</param>
        /// <returns>Om talet är primt eller ej</returns>
        static bool ÄrPrimt(int tal)
        {
            if (tal == 1 || tal == 0)
            {
                return false;
            }

            for (int i = 2; i <= tal / 2; i++)
            {
                if (tal % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Läser in ett int-tal från användaren
        /// </summary>
        /// <returns>Talet användaren skrev</returns>
        static int ReadInt()
        {
            int tal;
            while (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Ogiltigt svar. Försök igen");
            }
            return tal;
        }
    }
}