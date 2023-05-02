using ASCIIPaint.Paint;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Canvas canvas = new Canvas();
        canvas.SetHelloWorld();
        canvas.Draw();

        
        Console.ReadKey();
    }
}