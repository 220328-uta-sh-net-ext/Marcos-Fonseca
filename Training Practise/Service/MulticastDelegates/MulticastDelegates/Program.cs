using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    //This multicast delegate can invoke multiple methods when called
    public delegate void DogSound(int repeat);
<<<<<<< HEAD

=======
    //This multicast delegate can invoke multiple methods when called
    
>>>>>>> e1d79fdefce78d4c0a52449fe524e2035433811d
    public class DogSoundDelegate
    {
        static void Main(string[] args)
        {
            string userInput;
            int intVal;

            Console.Write("Pick a number and let the MultiCast begin...");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            //Create a DogSound delegate reference
            DogSound dg = null;
            //Create a DogSound delegate reference

            //Add new delegate objects
            //+ is overloaded for delegates
            //basically produces a list of method references
            dg += new DogSound(Rage);
            dg += new DogSound(Happy);
            dg += new DogSound(Hungry);
            dg += new DogSound(Thirst);
            //Add new delegate objects
            //+ is overloaded for delegates
            //basically produces a list of method references

            //Call the DogSound delegate
            if (args.Length == 1) dg(Int32.Parse(args[0]));
<<<<<<< HEAD
            else dg(intVal);
=======
            else dg(10);
            //Call the DogSound delegate
>>>>>>> e1d79fdefce78d4c0a52449fe524e2035433811d
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
