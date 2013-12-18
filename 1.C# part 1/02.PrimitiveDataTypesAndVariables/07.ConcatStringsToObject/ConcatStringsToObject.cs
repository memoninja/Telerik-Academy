/* 7. Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign 
* it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize 
* it with the value of the object variable (you should perform type casting).
*/

using System;

class ConcatStringsToObject
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        //Declare object and assign it with concatenation of strings
        object concatString = string.Concat(hello, " ", world);

        Console.WriteLine("Concatenated string: {0}", concatString);
        Console.WriteLine(new string('-', 32));

        //Declare string and assign it with object
        string objectToString = (string)concatString;

        Console.WriteLine("Object string: {0}\n", objectToString);
    }
}