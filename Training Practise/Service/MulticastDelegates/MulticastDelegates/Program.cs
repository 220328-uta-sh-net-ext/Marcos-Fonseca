using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Multicast point multiple functions
//You can use + or += to add, - or -= to remove a method
//Methods will be called in a first-in-first-ou (FIFO) order
namespace MulticastDelegates
{
    //This multicast delegate can invoke multiple methods when called
    public delegate void DogSound(int repeat);

    public class DogSoundDelegate
    {
        static void Main(string[] args)
        {
            string userInput;
            int intVal;

            Console.Write("Pick a number ");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            //Create a DogSound delegate reference
            DogSound dg = null;


            //Add new delegate objects
            //+ is overloaded for delegates
            //basically produces a list of method references
            dg += new DogSound(Rage);
            dg += new DogSound(Happy);
            dg += new DogSound(Hungry);
            dg += new DogSound(Thirst);


            //Call the DogSound delegate
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
