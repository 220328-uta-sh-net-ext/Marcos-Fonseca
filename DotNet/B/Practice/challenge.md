global using System;
public class Exercise9
{
  public static void Main()
  {
      /* Write a C# Sharp program that takes four numbers as input to 
      calculate and print the average. */
    
    double num1, num2, num3, num4;
    num1 = 0;
    num2 = 0;
    num3 = 0;
    num4 = 0;
    
    n1:
    Console.WriteLine("Type a number");
    
     try
    {
        num1 = Convert.ToDouble(Console.ReadLine());
        goto n1;
    }
    catch(System.FormatException ex)
    {
        Console.WriteLine(ex.Message);  
    }
    n2:
    Console.WriteLine("Type a number");

         try
    {
        num2 = Convert.ToDouble(Console.ReadLine());
        goto n2;
    }
    catch(System.FormatException ex)
    {
        Console.WriteLine(ex.Message);  
    }
    n3:
    Console.WriteLine("Type a number");

     try
    {
        num3 = Convert.ToDouble(Console.ReadLine());
        goto n3;
    }
    catch(System.FormatException ex)
    {
        Console.WriteLine(ex.Message);  
    }
    n4:
    Console.WriteLine("Type a number");
         try
    {
        num4 = Convert.ToDouble(Console.ReadLine());
        goto n4;
    }
    catch(System.FormatException ex)
    {
        Console.WriteLine(ex.Message);  
    }
   
    // Console.WriteLine("Type a number");
    // num1 = Convert.ToDouble(Console.ReadLine());

    // Console.WriteLine("Type a number");
    // num2 = Convert.ToDouble(Console.ReadLine());
    
    // Console.WriteLine("Type a number");
    // num3 = Convert.ToDouble(Console.ReadLine());

    // Console.WriteLine("Type a number");
    // num4 = Convert.ToDouble(Console.ReadLine());

    double result = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine($"{result}");
   
   }
}



 {
      /* Write a C# Sharp program that takes four numbers as input to 
      calculate and print the average. */
    
    double num1, num2, num3, num4;
  
    try
    {

        Console.WriteLine("Type a number");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Type a number");
    num2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Type a number");
    num3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Type a number");
    num4 = Convert.ToDouble(Console.ReadLine());

    double result = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine($"{result}");

    //num1 = Convert.ToDouble(Console.ReadLine());
    }
    catch(System.FormatException ex)
    {
        Console.WriteLine(ex.Message);  
    }
   }
}