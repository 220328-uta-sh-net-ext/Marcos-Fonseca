﻿global using System;
    class Program
    {
        static void Main(string[] args)
        {
            // The two ways to declare a variable"

            string characterName = "John";

            int characterAge;
            characterAge = 25;    

            // Ways to insert a variable"
            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine($"But didn't \nlike being {characterAge}");
            Console.WriteLine( characterName.Length );
            Console.WriteLine( characterName.ToUpper() );
            Console.WriteLine( characterName.Contains("J") );
            Console.WriteLine( characterName.Contains("Y") );
            Console.WriteLine( characterName[2] );
            Console.WriteLine( characterName.IndexOf('o') );

            //Data Types
            string phrase = "Regular Text";     //Text
            char grade = 'A';                   //Single character
            int age = 30;                       //whole numbers
            double gpa = 3.0;                   //Numbers with decimals
            bool isMale = true;                  //True or False only

            


            
            //Console.ReadLine();
        }
    }