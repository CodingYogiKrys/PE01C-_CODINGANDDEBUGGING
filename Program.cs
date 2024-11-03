// 'using' includes an existing code library (namespace).
using System;

// A namespace is a logical grouping of classes.
namespace ConsoleApplication1
{
    // Classes provide logical groupings of data and method routines.
    class Program
    {
        // Methods group instructions to complete a task.
        // C# console applications begin ij the Main() method.
        static void Main(string[] args)
        {
            // Variables refrence data in the program. I like how we actually call out what type of variable it is for example 'string' is called and 
            // the variable name 'output' is declaed as a text string.
            // the variable is initialized with the value 'Hello World'.
            string output = "Hello World!";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}