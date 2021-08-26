namespace Hackerrank.Observer
{
    public class MulDivObserver : ICalculatorObserver
    {
        public void Notify(int result)
        {
            System.Console.WriteLine($"Multiplication | Division {result}");
        }
    }
}