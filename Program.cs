using System;
class Gree
{
    static void Main()
    {
        Greet();
    }
    static void Greet()
    {
        string name;
        Console.WriteLine("enter your name:");
        name = Console.ReadLine();
        Console.WriteLine(name+" you are amazing");
    }
}

