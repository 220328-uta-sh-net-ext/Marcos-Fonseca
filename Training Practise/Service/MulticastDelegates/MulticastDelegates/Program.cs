using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void DogSound(int repeat);

    public class DogSoundDelegate
    {
        static void Main(string[] args)
        {
            string userInput;
            int intVal;

            Console.Write("Pick a number and let the MultiCast begin...");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            DogSound dg = null;

            dg += new DogSound(Rage);
            dg += new DogSound(Happy);
            dg += new DogSound(Hungry);
            dg += new DogSound(Thirst);

            if (args.Length == 1) dg(Int32.Parse(args[0]));
            else dg(intVal);
        }

        static void Rage(int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Console.WriteLine("Grrrrrrrrrrrrrrrrrrrrrrr");
        }
        static void Happy(int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Console.WriteLine("Au Au Au Au Au Au Au Au!!!");
        }
        static void Hungry(int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Console.WriteLine("Auuuuuuuuuuuuuuuuuuuuuuu");
        }
        static void Thirst(int repeat)
        {
            for (int i = 0; i < repeat; i++)
                Console.WriteLine("Hmmmm Hmmmm Hmmmm");
            Console.WriteLine("Who let the dogs out?");
            Console.WriteLine("Who, who, who, who, who?");
            Console.ReadLine();
        }
    }
}