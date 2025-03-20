namespace OddEven;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Let's see if your number is even or odd.");
        Console.Write("Write a number: ");

        string inputNumber = Console.ReadLine();

        int numbers = int.Parse(inputNumber);


        if (numbers % 2 == 0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }


    }
}
