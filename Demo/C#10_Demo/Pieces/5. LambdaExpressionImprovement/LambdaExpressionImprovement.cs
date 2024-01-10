namespace C_10_Demo.Pieces;
public class LambdaExpressionImprovement
{
    public static void Execute()
    {
        // function
        var checkOdd = (int number) => number % 2 != 0;

        // action
        var printOdd = (int number) =>
        {
            Console.WriteLine($"{number} is {(checkOdd(number) ? "odd" : "even")}");
        };

        Console.Write("Enter a number: ");

        var numberStr = Console.ReadLine();
        int.TryParse(numberStr, out var number);

        printOdd(number);
    }
}
