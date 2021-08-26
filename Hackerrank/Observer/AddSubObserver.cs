namespace Hackerrank.Observer
{
    public class AddSubObserver : ICalculatorObserver
    {
        public void Notify(int result)
        {
            System.Console.WriteLine($"Addition | Substraction {result}");
        }
    }
}