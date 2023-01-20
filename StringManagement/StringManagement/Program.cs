internal class Program
{
    private static void Main(string[] args)
    {
        int height = 170;
        int age = 20;
        string name = "Alejandro García";

        string info = "The information you reqauested is:\nUsername: " + name 
            + "\nUser age: " + age + "\nUser height: " + height;

        Console.WriteLine(info);
    }
}