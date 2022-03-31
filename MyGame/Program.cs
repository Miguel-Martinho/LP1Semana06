using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int nEnemies;
            nEnemies = Convert.ToInt32(Console.ReadLine());

            Enemy[] array = new Enemy[nEnemies];

            for (int i = 0; i < nEnemies; i++)
            {
                Console.WriteLine("Give this Enemy a name");
                string name = Console.ReadLine();
                array[i] = new Enemy(name);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].GetName());
            }
        }
    }
}
