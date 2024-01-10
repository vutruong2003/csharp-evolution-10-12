namespace C_10_Demo.Pieces;

public class AssignmentDeclarationInDeconstruction
{
    public static void Execute()
    {
        decimal x = 0;

        (x, var y) = GetCenterPoint(0, 0, 10, 10);

        Console.WriteLine($"Center: {x}:{y}");
    }

    public static (decimal X, decimal Y) GetCenterPoint(decimal X1, decimal Y1, decimal X2, decimal Y2)
    {
        return ((X2 + X1) / 2, (Y2 + Y1) / 2); 
    }
}
