# Welcome to .NET

## What is .NET?
- .NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, games, api, smart phones apps....
- In short, .NET Platform is a collection of **languages**, **libraries**, and **frameworks** to make various applications, developed under one common standard.
- With .Net platform you can build your app, test app, deploy the app and maintain. This is why .Net caters mostly all phases of SDLC.

## Supported Programming Languages
- Dozens of programming languages are supported by .Net provided they are compatible with the platform, [listed.](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/): Features are: 
    - Object oriented, type safe language and is case sensitive
        - object oriented means, that everything is an object. These objects are further organized with classes
        - Type-safe means that once you declare a type of a variable, you can't really change it. 
    - Component-oriented 
    - Lambda Expression, LINQ (Language Integrated Query), asynchronous operations ...
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...

## Technologies we'll be using during this training
- .NET 6 SDK (Runtime, toolkit to devlop apps, .Net CLI) and C#
- SQL (Sql Server)
- ASP.NET Core for creating web applications
- Azure Cloud Service for hosting
- Javascript, Typescript, HTML, CSS, jQuery and Angular for frontend

## [History of .Net](https://docs.microsoft.com/en-us/dotnet/core/porting/versioning-sdk-msbuild-vs)
- Microsoft introduced .Net 1.0 (deprecated) in 2002. It was known as .Net Framework
  
## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 5
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windows Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
- One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
    - CLR stands for *Common Language Runtime* and it's a runtime environment provided by .NET
- A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
- Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
- Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
- CLR Stands for Common Language Runtime, and it's runtime environment. It is also know as main execution Engine and is used to run any .Net application.
- SDK stands for Software Development Kit.
- CLR comes included in SDK

## .NET Standard
- .NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..

### Other Niceties..
- **Nuget**: a package manager for .NET

.NET 5
ASP.NET: ASP.NET Core to match with .NET Core 


# [Basics of C#](https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website) 
- C# is Case-Sensitive, Object-Oriented, Component Oriented language
    - Object-oriented means everythign is based on objects and classes and the relationships between them
- C# has coding syntax resembling other programming languages like C, C++, Java. Not that they wanted to copy them but for ease of developers to adopt this programming language.
- It is a type safe language. Type Safety is because of component of .Net known as **CTS** (Common Type System).
    - Type-safe meaning once you set a datatype you can't change the datatype (unless you use certain techniques to do it)
## Anatomy of C# program
- namespace -> Types -> Type members
- Namespaces are used to organize C#'s many classes and to control scope of class and methods in large programming project
    - Namespace
        - Types
                - Members (Methods, variables, properties)
- Types (Classes, Enums, Structs, Interface, Delegates)
    -   All types in  C# are inherited directly or indirectly **System.Object**
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** 
            - which stores the direct value, 
            - stored in memory Stack,
            - Stack is always faster to retrieve data than heap
            - Every value type has a set of memory set aside for it to occupy (Ex: int can only store 32-bits while a double can store 64-bits) and stack memory is all about structure for efficiency and how data cannot be dynamically changing in size
            - Ex Predefined (int, long, short, byte, DateTime, char)
                - Structs - like a class but gets stored in the stack for memory retrieval efficiency
                - Enums - defines a set of named integral constants
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** 
            - They are datatypes that are stored in the heap and reference variables that are stored in the stack
            - Think of reference variables as having the address of a house since an address only holds the info on where the house is and not the actual house itself
            - When you declare a variable of a reference type and not have it point to anything in the beginning, it will have a null value
                - Null in the coding world means lack of value or there isn't any value at all
            - Reference variables are stored in the stack while the actual object itself is stored in the heap
            - retrieval a value from heap is an expensive process.
            - Why the heap? since memory in the heap can be dynamically changing
            - Ex Predefined -> string, arrays, collections etc, Classes, interface, Delegates.  
## Conversion
- C# is statically typed at compiled time. Meaning after a variable is declared, it cannot be declared again.
- However, it is possible to change the variable type
- **[Type Conversion](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions)** : conversion of 1 type into another 
    - **Implicit type conversion** : 
        - Generally, it is when you can convert the type without any data loss
        - Mostly used with numerical datatypes
        - No special syntax needed to write and compiler will do it for you
        - no need to type cast manually/explicitly. 
        - Ex byte value can be placed in int; converting an int into a double

    - **Explicit type conversion** : 
        - If there is a risk of losing information, you must perform a **Cast**
        - Special syntax is needed to write to tell the compiler to do it anyway
        - Casting is denoted with (datatype)
        - type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
        - The `Parse` method returns the converted number; the `TryParse` method returns a boolean value that indicates whether the conversion succeeded, and returns the converted number in an `out` parameter.
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

 ### [Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- An expression is a sequence of operators and operands.
    - Ex int c = a + b;
    ```
    [(6/2)+2*3-1]
    - 3 + 2 * 3 - 1
    - 3 + 6 - 1
    - 9 - 1
    - 8
    ```
## What is Object-Oriented programming?
- It is a methodology we use to design our programs just using classes and objects
- It makes it a lot easier to develop and maintain your project as it gets bigger

### Classes
- They are templates that are used to create objects and define the object's functions and current state (essentially what information they currently store)

### Objects
- It is any entity that has a state and behavior
- They are made from classes and will copy whatever state and behavior the class has defined

### Overall
- Classes are blueprints and Objects is the actual object from the blueprint
- Ex: A blueprint of a car, tells you how to make a car but it isn't the car itself (The Class) The multiple cars you make from same blueprint (The Objects of that Class)
### Methods
- A method is a member that implements the behaviour or action or computation that can be performed by an object or class. 
    - static methods - they accessed through class 
    - instance methods - they are accessed through instance of the class

### Arrays
- Used to store a datatype and have fixed sizes
- Zero-based index
    - 0 is the starting position of the array
- Other arrays you can make:
    - Multidimensional arrays - int[,] ex = new int[4,2]; would create [ [0, 0], [0, 0], [0, 0], [0, 0] ]
    - Jagged arrays - arrays inside of an array are different sizes [ [0, 0, 0], [0, 0], [0, 0, 0], [0, 0 , 0, 0] ]

### [Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- Similar data can often be handled more efficiently when stored and manipulated as a collection. 
- You can use arrays, non-generic or generics.
- Arrays have fixed size and every element must have a value if no value is provided it contains the default.
- Arrays cannot be grown or shrinked. This where collection solves the problem.
- C# offers 2 categories of Collections:
    - non-generics
    - generics
- **Non-generic** collections store items as Object, require casting. Performance concerns were arised due to this casting and also Garbage Collection.
- **Generic collections** are type-safe at compile time. Because of this, generic collections typically offer better performance. 
    - Generic collections accept a type parameter when they are constructed and do not require that you cast to and from.
    - The "T" you see in documentation is where you put what data type that collection will hold
- All collections provide methods for adding, removing, or finding items in the collection.
- All collections can be **enumerated** by virtue of **Enumerator**.
- An enumerator can be thought of as a movable pointer to any element in the collection.
- Types of Generic Collections:
    - Stack<T>
        - LIFO - It is a Last-in, First-out list
        - Major Operations 
            - Push - Add element into stack
            - Pop - Remove an element from TOP
            - Peek - Retrieve the TOP element 
    - Queue<T>
        - FIFO - A first-in, first-out list
        - Major Operations
            - Enqueue - Add element into Queue
            - Dequeue - Remove element from Queue
            - Peek - Retrieve the TOP element 
    - List<T> 
        - Like any array which can grow and shrink dynamically.
        - Items in the list can be accessed by index.
        - It can accept null as a valid value for reference types and it also allows duplicate elements.
        - List<T> class is not sorted by default and elements are accessed by zero-based index.
        - Properties
            - Capacity - Gets or sets the total number of elements the internal data structure can hold without resizing.
            - Count - Gets the number of elements contained in the List<T>
        - Methods:
            - Add(T) - Adds an object to the end of the List<T>
            - Clear() - Removes all elements from the List<T>
            - Insert(index, T) - Inserts an element into the List<T> at the specified index
            - Remove(T) -	Removes the first occurrence of a specific object from the List<T>
            - RemoveAt(index) - Removes the element at the specified index of the List<T>
            - Reverse() -	Reverses the order of the elements in the List<T> or a portion of it
    - HashSet<T>
        - It is an unordered collection of the unique elements. 
        - It prevent duplicates from being inserted in the collection.
    - Dictionary<Tkey,TValue> 
        - It stores key/value pairs
        - Keys must be Unique
    - SortedList<TKey,TValue>
        - It is a sorted list of key/value pairs 
    - LinkedList<T> 
        - It allows fast inserting and removing of elements. It implements a classic linked list.
        - Each element is separately allocated.
        - Properties:
            - Count -	Gets the number of nodes actually contained in the LinkedList.
            - First -	Gets the first node of the LinkedList.
            - Last - Gets the last node of the LinkedList.
        - Methods:
            - AddFirst - Adds a new node or value at the start of the LinkedList.
            - AddLast -	Adds a new node or value at the end of the LinkedList.
            - Clear() -	Removes all nodes from the LinkedList.
            - Contains(T) -	Determines whether a value is in the LinkedList.
            - Remove(LinkedListNode) - Removes the specified node from the LinkedList.
            - Remove(T) - Removes the first occurrence of the specified value from the LinkedList.
            - RemoveFirst() - Removes the node at the start of the LinkedList.
            - RemoveLast() - Removes the node at the end of the LinkedList.
### Exceptions
- An exception is an event that occurs during the execution of a program that distrupts the normal flow of instructions
    - Horrible to encounter when presenting your program (When it is expected to work perfectly fine)
    - Great when trying to find bugs in your program
- They are not Errors!
#### Errors
- A serious problem that for the most part cannot be handled by the developer
    -They are fatal to the program at runtime
    - Ex: A stack overflow error and that usually occurs when your computer has run out of memory to store information
- 3 types of errors
    - Usage error - error in your program logic and can be solve by modifying/restructuring your code
    - Program Error - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
    - System Failures - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)
#### Exception Handling
- Using a try-catch block and optionally finally block
- If you know the block of code you will run will have a risk of throwing an exception, you should put it in the try block
- The catch block will then "catch" that exception and will run instead its block of code
    - Once an exception occurs in the try block, the flow of control jumps to the first associated exception handler that is present anywhere in the call stack. In C#, the catch keyword is used to define an exception handler.
    - If no exception handler for a given exception is present, the program stops executing with an error message.
    - Don't catch an exception unless you can handle it and leave the application in a known state. 
- Optionally, you can add a finally block that will run regardless if your code throws an exception or not
    - Mostly used to clean up any resources you used in the try blcok
#### Throwing Exception
- You can throw an exception yourself in your code by using the throw keyword
- Useful for enforcing certain rules/logic in your program
#### Exception Heirarchy
- Certain exceptions are more specific than other exceptions
- General rule is the most specific exception should be the very first catch block and the least specific exception is at the very last catch block
    - Why? Well if you made the least specific the first catch block then it will always run if any exception is thrown making your other catch blocks useless
### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)
<<<<<<< HEAD



# Beginner's Guide To Console Input In C#

> _Note: I recommend reading this gist in order because `Examples 1-6` build on each other._
> - [Example 1: Getting Console Input With `Console.ReadLine`](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-1-getting-console-input-with-consolereadline)<br />
    <sub>_How to get console input._</sub>
> - [Example 2: Parsing The Console Input From `String` To `Int32`](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-2-parsing-the-console-input-from-string-to-int32)<br />
    <sub>_How to convert the console input into a numeric value._</sub>
> - [Example 3: Validating Console Input With `Int32.TryParse`](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-3-validating-console-input-with-int32tryparse)<br />
    <sub>_How to validate numeric input to prevent bugs in your code._</sub>
> - [Example 4: Looping Until User Provides Valid Input](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-4-looping-until-user-provides-valid-input)<br />
    <sub>_How to continually ask for input until the user provides valid input._</sub>
> - [Example 5: Additional Validation (0-100)](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-5-additional-validation-0-100)<br />
    <sub>_How to add custom validation logic on the user input._</sub>
> - [Example 6: Optional Code Style Changes Over Example 5](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-6-optional-code-style-changes-over-example-5)<br />
    <sub>_How to clean up your code a bit._</sub>
> - [Example 7: Another Example... Array Of Possible Inputs](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-7-another-example-array-of-possible-inputs)<br />
    <sub>_How to allow input from an array of possible inputs._</sub>
> - [Example 8: Another Example... Multiple Inputs At Once](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-8-another-example-multiple-inputs-at-once)<br />
    <sub>_How to allow users to input multiple values at once._</sub>
> - [Example 9: Watching Individual Key Presses With `Console.ReadKey`](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-9-watching-individual-key-presses-with-consolereadkey)<br />
    <sub>_How to watch each individual key press from the user._</sub>
> - [Example 10: Flushing The Input Buffer](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-10-flushing-the-input-buffer)<br />
    <sub>_How to prevent console input._</sub>
> - [Example 11: Menu-Based Console Input](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-11-menu-based-console-input)<br />
    <sub>_How to easily manage menus in the console._</sub>
> - [Example 12: Generic Console Input Method](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-12-generic-console-input-method)<br />
    <sub>_How to write a generic console input method with delegates and optional parameters._</sub>
> - [Example 13: Using Reflection To Make Example 12's TryParse Optional](https://gist.github.com/ZacharyPatten/798ed612d692a560bdd529367b6a7dbd#example-13-using-reflection-to-make-example-12s-tryparse-optional)<br />
    <sub>_How to simplify the usage of generic code using reflection._</sub>

Make sure you have a `using System;` are the top of your file. Then whenever you want input from the user just use the `Console.ReadLine()` method.

## Example 1: Getting Console Input With `Console.ReadLine`

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Provide input: ");
		string input = Console.ReadLine();
		Console.WriteLine($"Your input: {input}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [Console.Write(...)](https://docs.microsoft.com/en-us/dotnet/api/system.console.write)
> - [string](https://docs.microsoft.com/en-us/dotnet/api/system.string)
> - [= Assignment](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/assignment-operator)
> - [Console.ReadLine()](https://docs.microsoft.com/en-us/dotnet/api/system.console.readline)
> - [Console.WriteLine(...)](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline)
> - [$ String Interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

So in `Example 1`, we are successfully getting input from the user. The input is stored in the `input` variable and is a `string` data type. The `string` data type is **not** a numerical data type, therfore if you wanted to perform math operations on the input such as `int doubleInput = 2 * input;` it will not work. So the next step is to convert the data type from `string` to whatever type you need it to be. For this example we will convert the type from `string` to `int`.

## Example 2: Parsing The Console Input From `String` To `Int32`

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue = int.Parse(input); // <- This is a bug!
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32)
> - [int.Parse(...)](https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse)

_Note: There are numerous C# tutorials that use the `Convert.ToInt32(...)` method, but you should avoid this method. `Convert.ToInt32(...)` is an old method from before NET Framework 2.0, and we now have better methods to use isntead._

`Example 2` shows how you can convert a `string` to an `int` using the `int.Parse(...)` method. It works when the user provides valid input such as `123`, but it will throw an exception at runtime if the user provides invalid input such as `duck`. Thus, this is a bad practice and should be avoided or you may run into bugs in your software. The next step would be to validate the input rather than just trying to directly parse it into an `int`.

## Example 3: Validating Console Input With `Int32.TryParse`

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		if (success)
		{
			Console.WriteLine($"Your input: {inputValue}");
		}
		else
		{
			Console.WriteLine($"Invalid Input.");
		}

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [int.TryParse(...)](https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse)
> - [if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else)

An `out` parameter is a way for methods to pass back more than one value. The `int.TryParse` method is passing back two values to the calling code:
1. The `bool` return value that indicates if the parse was successful. In `Example 3` we are storing this value in the `success` variable.
2. The `int` typed `out` parameter that is the resulting value of the parse. In `Example 3` we are storing this value in the `inputValue` variable.

`Example 3` shows how to validate that the input from the user using the `int.TryParse` method. We just need use branching (in this case an `if` statement) to check if the return value of `int.TryParse` is true (successful) or false (unsuccessful).

Now we have proper input validation for `int` data types, but what if you need a valid input in order to continue? The next step is to loop until the user provides valid input.

## Example 4: Looping Until User Provides Valid Input

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		while (!success)
		{
			Console.WriteLine("Invalid Input. Try again...");
			Console.Write("Please enter an integer: ");
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
		}
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [while](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)

`Example 4` shows how we can continually request input from the user until valid input is provided. When we get past the `while` loop, we are guaranteed that the `inputValue` variable has been populated by a valid user input. However, what if we need to validate that value further? What if we want it to only be condsidered valid input if the value is between 0 and 100? The next step is to add additional validation.

## Example 5: Additional Validation (0-100)

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer (0-100): ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		bool valid = success && 0 <= inputValue && inputValue <= 100;
		while (!valid)
		{
			Console.WriteLine("Invalid Input. Try again...");
			Console.Write("Please enter an integer 0 and 100: ");
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
			valid = success && 0 <= inputValue && inputValue <= 100;
		}
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [! Logical Negation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-negation-operator-)
> - [<= Less Than Or Equal To](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators#less-than-or-equal-operator-)
> - [&& Logical AND](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-and-operator-)

In `Example 5` we added additional validation logic. Now when the loop ends we know that `inputValue` is a valid `int` value proviided by the user and it is in the 0-100 range. That is pretty much all you need to know to accept proper `int` input in your console applications.

Although `Example 5` is fully functional, we can shorten it a bit if we want to, but any changes at this point are code style preferences and are not required. In particular though, it would be nice if we created variables for the `min` and `max` ranges of the valid user input and used a variable for the message to provide input from the user to prevent duplicated hard-coded `string` values.

## Example 6: Optional Code Style Changes Over Example 5

```cs
using System;

class Program
{
	static void Main()
	{
		int min = 0;
		int max = 100;
		int inputValue;
		string prompt = $"Please enter an integer ({min}-{max}): ";
		Console.Write(prompt);
		while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < min || max < inputValue)
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Console.WriteLine($"You input the value: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [|| Logical OR](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-or-operator-)
> - [< Less Than](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators#less-than-operator-)

There are ways to simplify the code even further by making your own methods, but these examples should have given you all you need to get started writing your own interactive console applications in C#. :)

`Examples 1-6` give you all the fundamentals you need to get console input from the user, but if you are struggling to modify the examples to fit your needs, maybe some more examples will help. Here is an example where the user can select a mathematical operation from a set of values inside an array.

## Example 7: Another Example... Array Of Possible Inputs

```cs
using System;
using System.Linq;

class Program
{
	static void Main()
	{
		string[] operators = new[] { "+", "-", "*", "/" };
		string input;
		string prompt = $"Please enter an operator ({string.Join(", ", operators)}): ";
		Console.Write(prompt);
		while (!operators.Contains(input = Console.ReadLine()))
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Operator inputOperator = input switch
		{
			"+" => Operator.Addition,
			"-" => Operator.Subtraction,
			"*" => Operator.Multiplication,
			"/" => Operator.Division,
			_ => throw new NotImplementedException("unexpected operator"),
		};
		Console.WriteLine($"You selected: {inputOperator}");

		Console.WriteLine("Press [enter] To Exit...");
		Console.ReadLine();
	}
}

public enum Operator
{
	Addition,
	Subtraction,
	Multiplication,
	Division,
}
```
> - [enum](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
> - [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
> - [string.Join(...)](https://docs.microsoft.com/en-us/dotnet/api/system.string.join)
> - [Enumerable.Contains(...)](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.contains)
> - [switch (expression)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression)
> - [throw](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw)
> - [NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)

In `Example 7` the user may select one of four operators: Addition (+), Subtraction (-), Multiplcation (*), and Division (/). The program will loop until the user selects a valid operator. After a valid operator is selected, the program uses a `switch` expression to convert the input `string` into an `Operator` value. Although it is not necessary to convert the `string` into an `enum`, it is a good practice that will result in better code.

You might want to make it easier on the user and let them input multiple values at once. You don't need to, but I would probably recommend making helper methods for this. Lets see an example for handling multiple `int` inputs at once.

## Example 8: Another Example... Multiple Inputs At Once

```cs
using System;

class Program
{
	static void Main()
	{
		int[] inputValues;
		string prompt = $"Please enter multiple integers (1, 2, 3): ";
		Console.Write(prompt);
		while (!TryParseIntegerList(Console.ReadLine(), out inputValues))
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Console.WriteLine($"You input the values: {string.Join(", ", inputValues)}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}

	public static bool TryParseIntegerList(string input, out int[] inputValues)
	{
		inputValues = default;
		string[] splits = input.Split(",");
		int[] result = new int[splits.Length];
		for (int i = 0; i < splits.Length; i++)
		{
			if (!int.TryParse(splits[i].Trim(), out result[i]))
			{
				return false;
			}
		}
		inputValues = result;
		return true;
	}
}
```
> - [string.Split(...)](https://docs.microsoft.com/en-us/dotnet/api/system.string.split)
> - [for](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
> - [string.Trim()](https://docs.microsoft.com/en-us/dotnet/api/system.string.trim)

In `Example 8` we take in a line of input from the user that should contain multiple `int` values seperated by commas. If any of the values are not valid `int` values it is considered invalid and the user must try again. Once we have the input from the user, the first step is to divide the string up into each seperate value, which `Example 8` does using the `string.Split(...)` method. There are other ways to parse strings than using the `string.Split(...)` method, but that is one of the easiest ones for beginners. Once each input is seperated, we just need to `int.TryParse` each value to make sure they are all valid, and store them in an array. The `string.Trim()` method just removes any white space on the front or back of a string so the users can add spaces in their input if they want to. All of the following are acceptable inputs for example:
- `1,2,3,4,5`
- `1, 2, 3, 4, 5`
- `1,2, 3, 4,5`

## Example 9: Watching Individual Key Presses With `Console.ReadKey`

```cs
using System;

class Program
{
	static void Main()
	{
		ConsoleKey continueKey = ConsoleKey.C;
		Console.Write($"Press [{continueKey}] to continue...");
		while (Console.ReadKey(true).Key != continueKey)
		{
			// do nothing until they press the correct key
		}
		Console.WriteLine();
		Console.WriteLine($"You pressed {continueKey}.");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
```
> - [ConsoleKey](https://docs.microsoft.com/en-us/dotnet/api/system.consolekey)
> - [Console.ReadKey](https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey)
> - [ConsoleKeyInfo.Key](https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.key)
> - [!= Inequality](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/equality-operators#inequality-operator-)

`Example 9` shows how you can watch individual key presses from the user rather than taking in a full `string` of input. You can do this with the `Console.ReadKey(...)` method. In this case, `Example 9` is requesting that the user press the `C` key before the program will continue. The `Console.ReadKey(...)` method also allows you to _intercept_ the input so that the input is accepted but will not be written to the console. Whether or not you want to _intercept_ the input is determined by the parameter on the `Console.ReadKey(...)` method.

We have discussed most topics regarding getting an handling console input, but what if we want to prevent console input?

## Example 10: Flushing The Input Buffer

```cs
using System;

class Program
{
	static void Main()
	{
		Console.Write("Press [enter] to start (~10 seconds)...");
		Console.ReadLine();

		// Imagine there is a lot of code in here that takes
		// ~10 seconds to complete. For this example I'm
		// just sleeping the thread to simulate this.
		System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));

		// By flushing the console input buffer after the ~10 seconds
		// of processing, we are effectively disabling all input during
		// during that processing. If we don't flush the buffer, then
		// that input would be rendered to the console and would effect
		// the rest of our code.
		while (Console.KeyAvailable)
		{
			Console.ReadKey(true);
		}

		Console.Write("Press [enter] to exit...");
		Console.ReadLine();
	}
}
```
> - [Console.KeyAvailable](https://docs.microsoft.com/en-us/dotnet/api/system.console.keyavailable)

`Example 10` demonstrates how you can prevent console input. It is flushing the input buffer by continually calling `Console.ReadKey` until there are no more keys available. Thus, any key presses that occured prior to the flush are ignored.

## Example 11: Menu-Based Console Input

```cs
using System;

class Program
{
	static void Main()
	{
		ConsoleHelper.Menu(
			("Option 1", Option1),
			("Option 2", Option2),
			("Option 3", Option3));

		Console.WriteLine();

		// or... if want to customize the output
		ConsoleHelper.Menu(
			title: "This is my menu...",
			prompt: "Please choose an option: ",
			invalidMessage: "Wrong...",
			("Option 1", Option1),
			("Option 2", Option2),
			("Option 3", Option3));

		Console.WriteLine("Press [enter] to continue...");
		Console.ReadLine();
	}

	public static void Option1()
	{
		Console.WriteLine("You chose option 1.");
	}

	public static void Option2()
	{
		Console.WriteLine("You chose option 2.");
	}

	public static void Option3()
	{
		Console.WriteLine("You chose option 3.");
	}
}

public static class ConsoleHelper
{
	public static void Menu(params (string DisplayName, Action Action)[] options) =>
		Menu(null, null, null, options);

	public static void Menu(
		string title = null,
		string prompt = null,
		string invalidMessage = null,
		params (string DisplayName, Action Action)[] options)
	{
		// handling parameters
		if (options is null)
		{
			throw new ArgumentNullException(nameof(options));
		}
		if (options.Length <= 0)
		{
			throw new ArgumentException($"{options} is empty", nameof(options));
		}
		title ??= "Menu...";
		prompt ??= $"Choose an option (1-{options.Length}): ";
		invalidMessage ??= "Invalid Input. Try Again...";

		// render menu
		Console.WriteLine(title);
		for (int i = 0; i < options.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {options[i].DisplayName}");
		}

		// get user input
		int inputValue;
		Console.Write(prompt);
		while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < 1 || options.Length < inputValue)
		{
			Console.WriteLine(invalidMessage);
			Console.Write(prompt);
		}

		// invoke the action relative to the user input
		options[inputValue - 1].Action?.Invoke();
	}
}
```
> - [Action](https://docs.microsoft.com/en-us/dotnet/api/system.action)
> - [ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)
> - [ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)
> - [paramter = x Optional Arguments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#optional-arguments)
> - [parameter: x Named Arguemnts](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#named-arguments)
> - [is](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is)
> - [nameof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
> - [?? Null-Coalescing](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)

**There are lots of ways to implement menus in the console**, but `Example 11` has a helper method that takes an array of `string`'s and `Action`'s as a parameter. The `DisplayName` `string` is the `string` as it will appear to the user in the menu and the `Action` is what code will be called when the user selects that option. The code for rendering the menu and getting the user input are dynamic based on the size of the array, so all you need to do is add more parmeters and the helper method takes care of the rest for you.

What if you want to loop the menu and add an "Exit" option to `Example 11`? Here is another snippet of what that can look like:
```cs
bool exit = false;
while (!exit)
{
	ConsoleHelper.Menu(
		("Option 1", Option1),
		("Option 2", Option2),
		("Option 3", Option3),
		("Exit", () => exit = true));
	Console.WriteLine();
}
```
> - [x => y Lambda Expressions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions)

## Console Games Examples

Are you wanting to learn how to code games? Even if you aren't interested in game development, making console games is a great way to learn how to program in C#. I have a GitHub repo with examples of console games if you want to give it a look. Many of the games use simple console input techniques like the examples in this gist:
https://github.com/ZacharyPatten/dotnet-console-games

Good Luck!

_**If you are still relatively new to C# I recommend you stop here. I do not recommend beginners attempt to simplify console input further than the previous examples in this gist. However, the following examples show how we can create helper methods to simplify console input to a single line of code.**_

## Example 12: Generic Console Input Method

```cs
using System;

class Program
{
	static void Main()
	{
		var a = ConsoleHelper.GetInput<int>(
			tryParse: int.TryParse);

		var b = ConsoleHelper.GetInput<double>(
			prompt:         "Give me an double (0-100): ",
			invalidMessage: "Invalid...",
			tryParse:       double.TryParse,
			validation:     v => 0 <= v && v <= 100);

		Console.WriteLine("You input the values:");
		Console.WriteLine($"- {a}");
		Console.WriteLine($"- {b}");

		Console.WriteLine("Press [enter] to exit...");
		Console.ReadLine();
	}
}

public delegate bool TryParse<T>(string @string, out T value);

public static class ConsoleHelper
{
	public static T GetInput<T>(
		TryParse<T> tryParse,
		string prompt = null,
		string invalidMessage = null,
		Predicate<T> validation = null)
	{
		_ = tryParse ?? throw new ArgumentNullException(nameof(tryParse));
	GetInput:
		Console.Write(prompt ?? $"Input a {typeof(T).Name} value: ");
		if (!tryParse(Console.ReadLine(), out T value) || !(validation is null || validation(value)))
		{
			Console.WriteLine(invalidMessage ?? $"Invalid input. Try again...");
			goto GetInput;
		}
		else
		{
			return value;
		}
	}
}
```
> - [typeof](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#typeof-operator)
> - [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
> - [&lt;T&gt; Generics](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)
> - [Predicate&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1)
> - [Type.Name](https://docs.microsoft.com/en-us/dotnet/api/system.type.name)
> - [goto](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/goto)
> - [_ Discards](https://docs.microsoft.com/en-us/dotnet/csharp/discards)

`Example 12` shows how we can make a generic console input method. It uses optional parameters, so you don't need to provide a `prompt`, `invalidMessage`, or `validation` unless you want to customize them, but the `tryParse` parameter is still a required parameter for the method to work. A `delegate` is a fuction pointer in C#. In this example we are requesting the calling code to provide the `TryParse` method for the relative generic type.

## Example 13: Using Reflection To Make Example 12's TryParse Optional

_**Note: This example is dependent on the [Towel](https://github.com/ZacharyPatten/Towel) nuget package. The [Towel](https://github.com/ZacharyPatten/Towel) nuget package must be added as a dependency for the code to build and run.**_

```cs
// Depedent on Towel nuget Package
using System;
using Towel;
using static Towel.Syntax;

class Program
{
	static void Main()
	{
		var a = ConsoleHelper.GetInput<int>();
		var b = ConsoleHelper.GetInput<double>();
		var c = ConsoleHelper.GetInput<string>();
		var d = ConsoleHelper.GetInput<int>(
			prompt: "Insert your favorite integer: ",
			invalidMessage: "Don't be a moron...");
		var e = ConsoleHelper.GetInput<Direction>(
			prompt: "Insert Left or Right: ");
		var f = ConsoleHelper.GetInput<int>(
			prompt: "Insert an integer (0-100): ",
			validation: value => 0 <= value && value <= 100);

		Console.WriteLine("You input the values:");
		Console.WriteLine($"- {a}");
		Console.WriteLine($"- {b}");
		Console.WriteLine($"- {c}");
		Console.WriteLine($"- {d}");
		Console.WriteLine($"- {e}");
		Console.WriteLine($"- {f}");

		Console.WriteLine("Press [enter] to exit...");
		Console.ReadLine();
	}
}
public enum Direction
{
	Left,
	Right
}
public static class ConsoleHelper
{
	public static T GetInput<T>(
		string prompt = null,
		string invalidMessage = null,
		TryParse<T> tryParse = null,
		Predicate<T> validation = null)
	{
		if (tryParse is null && (typeof(T) != typeof(string) && !typeof(T).IsEnum && Meta.GetTryParseMethod<T>() is null))
		{
			throw new InvalidOperationException($"Using {nameof(ConsoleHelper)}.{nameof(GetInput)} without providing a {nameof(tryParse)} delegate for a non-supported type {typeof(T).Name}.");
		}
		tryParse ??= typeof(T) == typeof(string)
			? (string s, out T v) => { v = (T)(object)s; return true; }
			: (TryParse<T>)TryParse;
		validation ??= v => true;
	GetInput:
		Console.Write(prompt ?? $"Input a {typeof(T).Name} value: ");
		if (!tryParse(Console.ReadLine(), out T value) || !validation(value))
		{
			Console.WriteLine(invalidMessage ?? $"Invalid input. Try again...");
			goto GetInput;
		}
		return value;
	}
}
```
> - [Towel.Syntax.TryParse<A>](https://zacharypatten.github.io/Towel/api/Towel.Syntax.html#Towel_Syntax_TryParse__1_System_String___0__)
> - [Towel.Meta.GetTryParseMethod<T>](https://zacharypatten.github.io/Towel/api/Towel.Meta.html#Towel_Meta_GetTryParseMethod__1)
> - [?: Conditional Operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator)
> - [InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)
> - [Type.IsEnum](https://docs.microsoft.com/en-us/dotnet/api/system.type.isenum)


`Example 13` is using a dependency, but what is happening under the hood is we are using reflection to look up the `TryParse` method for the relative generic type so that the `tryParse` parameter can be made optional. This will work with any type that has a static `TryParse` method with the expected signature, `enum` types, or `string`. If your type does not fit those requirements you can always provide you own `tryParse` parameter.

