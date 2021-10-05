using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitjat.

            Console.WriteLine("Arvuti viskab:");
            int cpuScore = 0;
            for(int i = 0; i < 3; i++)
            {
                
                //arvuti vise
                Random rnd = new Random();
                int cpuRandom = rnd.Next(1, 7);

                Console.WriteLine(cpuRandom);
                int Total = cpuRandom;
                cpuScore = cpuScore + Total;
            }
            //Console.WriteLine($"Arvuti visked {cpuScore}.");
            Console.WriteLine("Kasutaja viskab:");
            int userScore = 0;
            for (int i = 0; i < 3; i++)
            {
                
                Random rnd = new Random();
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine(userRandom);
                int Total = userRandom;
                userScore = userScore + Total;
                
            }
            //Console.WriteLine($"Kasutaja viskas {userScore}.");

            Console.WriteLine($"Arvuti viskas {cpuScore}. Kasutaja viskas {userScore}.");

            if (cpuScore < userScore)
            {
            Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            userScore = cpuScore + 1;
            }
            else if (cpuScore > userScore)
            {
            Console.WriteLine("Arvuti on mängu võitnud.");
            cpuScore = userScore + 1;
            }
            else
            {
            Console.WriteLine("Viik!");
            }




        }
    }
}

