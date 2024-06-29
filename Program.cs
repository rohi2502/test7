// See https://aka.ms/new-console-template for more information
using System;
 

public class Addition 
{ 
int a, b; 
public Addition()
 { 
a = 100; 
b = 175; 
} 
public static void Main() 
{ 
Addition obj = new Addition();
Console.WriteLine(obj.a); 
Console.WriteLine(obj.b); 
Console.Read(); 
} 
} 



/*namespace Constructor
{
    class paraconstrctor
    {
         int a, b;
        public paraconstrctor(int x, int y)   
        {
            a = x;
           b = y;
        }
    }
    class Mainclass
    {
        public static void Main(string[] args)
        {
            paraconstrctor v = new paraconstrctor(100, 175);  
            Console.WriteLine("-----------parameterized constructor example by vithal wadje---------------");
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + v.a);
            Console.WriteLine("value of b=" + v.b);
            Console.Read();
        }
    }
}*/

/*public class Example
{
    public static int StaticField;
    static Example()
    {
        StaticField = 42;
        Console.WriteLine("Static constructor called.");
    }
    public Example()
    {
        Console.WriteLine("Instance constructor called.");
    }
    public static void StaticMethod()
    {
        Console.WriteLine("Static method called.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"StaticField: {Example.StaticField}");
        Example.StaticMethod();
        Example instance = new Example();
    }
}*/
/*
namespace defaultConstractor
{
    public class Counter
    {
        private Counter() 
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
    class viewCountedetails
    {
        static void Main()
        {
            Console.WriteLine("-------Private constructor example by vithal wadje----------");
            Console.WriteLine();
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();
        }
    }
}
*/

