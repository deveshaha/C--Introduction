internal class Program
{
    private static void Main(string[] args)
    {
        int n1;
        int n2;

        Console.WriteLine("Please enter the first number");
        //Es como el Integer.parseInt en Java
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
        n2 = Convert.ToInt32(Console.ReadLine());

        int result = n1 * n2;

        Console.WriteLine("The result is: " + result);


    }
}