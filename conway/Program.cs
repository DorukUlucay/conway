using System;

namespace conway
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int speed = 500;
            Conway conway = new Conway(size);

            while (true)
            {
                System.Threading.Thread.Sleep(speed);
                var world = conway.Evolve();
                print(world);
            }
        }

        static void print(int[,] world)
        {
            Console.WriteLine();
            for (int x = 0; x < world.GetLength(0); x++)
            {
                string r = "";

                for (int y = 0; y < world.GetLength(1); y++)
                {
                    r += " " + world[x, y].ToString();
                }
                Console.WriteLine(r);
            }
        }
    }
}
