/*Problem 6.	Strings and Objects
Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

using System;

class Strings_And_Objects
{
    static void Main()
    {
        string strHello = "Hello";
        string strWorld = "World";
        object helloWorld = strHello + " " + strWorld;
        string strThird = (string)helloWorld;

        Console.WriteLine("Strings and objects variables:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("First string variable --> {0,7} ({1})\nSecond string variable --> {2,6} ({3})", strHello, strHello.GetType().Name, strWorld, strWorld.GetType().Name);
        Console.WriteLine("Object variable --> {0,19}! ({1})\nThird string variable --> {2,13}! ({3})", helloWorld, helloWorld.GetType().Name, strThird, strThird.GetType().Name);
        Console.WriteLine(new string('-', 40));
    }
}