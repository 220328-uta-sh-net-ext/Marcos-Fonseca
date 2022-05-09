using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void DogSound(int repeat);
    //This multicast delegate can invoke multiple methods when called
    
    public class DogSoundDelegate
    {
        static void Main(string[] args)
        {
            DogSound dg = null;
            //Create a DogSound delegate reference


            dg += new DogSound(Rage);
            dg += new DogSound(Happy);
            dg += new DogSound(Hungry);
            dg += new DogSound(Thirst);
            //Add new delegate objects
            //+ is overloaded for delegates
            //basically produces a list of method references

            if (args.Length == 1) dg(Int32.Parse(args[0]));
            else dg(10);
            //Call the DogSound delegate
        }

        static void Rage (int repeat)
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
                Console.ReadLine();
        }
    }
}
