using System;

namespace Conway
{
    class Program
    {
        static void Main(string[] args)
        {
            Conway world = new Conway(20);

            for (int i = 0; i < 3; i++)
            {
                world.Evolve();
                Console.WriteLine();
                world.PrintToConsole();
            }

            Console.ReadKey();
        }
    }
}
