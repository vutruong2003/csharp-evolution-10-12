namespace C_10_Demo.Pieces;
public class ConstantsInterpolatedStrings
{
    public static void Execute()
    {

        const string EmailSubject = $"This is template. Please place {{{{{Email}}}}} and {{{{{Password}}}}} with your content";

        Console.WriteLine(EmailSubject);
    }
}