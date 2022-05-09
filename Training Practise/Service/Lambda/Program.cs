using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Lambda expression was introduct with the C# 3.0 along with LINQ
//It is a shorter way of representing anonymous method using some special sintax
namespace Lambda
{
    public class Program
    {
        delegate bool IsTeenAger(Student stud);
       
        public static void Main()
        {
            string userInput;
            int intVal;

            Console.Write("Are you a teenager? How old are you?  ");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            
            //Anonymous Method
            /* IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

             Student stud = new Student() { Age = intVal };

             Console.WriteLine(isTeenAger(stud));
             Console.ReadLine(); */
            

            //Lambda Expression
            //The Lambda expression evolves from anonymous method by first removing the delegate keyword and parameter type and adding a lambda operator
            //s is a parameter
            //=> is the lambda operator
            //s.Age > 12 && s.Age < 20 is the body expression

            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

            Student stud = new Student() { Age = intVal };

            Console.WriteLine(isTeenAger(stud));
            Console.ReadLine();
        }
    }
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
