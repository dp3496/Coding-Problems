namespace Hackerrank.Composites
{
    public class CompositeTest
    {
        public void Test()
        {
            IComponent component = new Component();
            IComposite composite = new Composite();

            IComponent component1 = new Component();
            IComposite composite1 = new Composite();

            composite1.Add(component1);

            composite.Add(component);
            composite.Add(composite1);

            System.Console.WriteLine(composite.GetSize());
        }
    }
}