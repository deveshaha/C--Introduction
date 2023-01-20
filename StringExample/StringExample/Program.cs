internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        Console.WriteLine("Please write your name");

        // Var detecta el tipo de dato automaticamente (Como en javascript)
        //var fullUserName = Console.ReadLine();
        string fullUserName = Console.ReadLine();

        Console.WriteLine("Hello " + fullUserName + " welcome to platzi");
    }
}