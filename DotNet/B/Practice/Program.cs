using System;

namespace Training
{ 
    class program
    { 
        static void Main(string[] args)
        { 
string aFriend = "Mark";     
Console.WriteLine(aFriend);

aFriend = "Tati";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}"); //String interpolation.

string firstFriend = "Tati";
string secondFriend = "Leo";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters."); //Find the length of a string
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart(); //To trim the spaces from the strings. Use the Trim method, TrimStart, and TrimEnd.
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Burn"); //Replace Method searches for a substring and replaces it with different text.
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper()); //make a string ALL CAPS 
Console.WriteLine(sayHello.ToLower()); //make a string all lower case

string songLyrics = "You say goodbye, and I say hello"; //Search string using Contains Method

var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);

var startResult = songLyrics.StartsWith("goodbye");
Console.WriteLine(startResult);

var endResult = songLyrics.EndsWith("hello");
Console.WriteLine(endResult);

Console.WriteLine(songLyrics.Contains("greetings"));

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(f);

double aaa = 5;
double bbb = 4;
double ccc = 2;
double ddd = (aaa + bbb) / ccc;
Console.WriteLine(ddd);

int aa = 7;
int bb= 4;
int cc = 3;
int dd = (aa + bb) / cc;
int ee = (aa + bb) % cc;
Console.WriteLine($"quotient: {dd}");
Console.WriteLine($"remainder: {ee}");

int maxI = int.MaxValue;
int minI = int.MinValue;
Console.WriteLine($"The range of integers is {minI} to {maxI}");

int what = maxI + 3;
Console.WriteLine($"An example of overflow: {what}");

double maxD = double.MaxValue;
double minD = double.MinValue;
Console.WriteLine($"The range of double is {minD} to {maxD}");

decimal minDe = decimal.MinValue;
decimal maxDe = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDe} to {maxDe}");

long minL = long.MinValue;
long maxL = long.MaxValue;
Console.WriteLine($"The range of the long type is {minL} to {maxL}");

short minS = short.MinValue;
short maxS = short.MaxValue;
Console.WriteLine($"The range of the short type is {minS} to {maxS}");

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);

int ab = 5;
int ba = 6;

bool something = ab + ba > 10;

if (something)   // if (ab + ba > 10)
    Console.WriteLine("The answer is greater than 10.");
else
    Console.WriteLine("The answer is not greater than 10.");


        }
    }
}