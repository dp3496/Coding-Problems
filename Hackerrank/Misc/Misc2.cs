namespace Hackerrank.Misc
{
    public class Misc2
    {
        public void Test()
        {
            var c = new C();
        }
    }
    public class A
    {
        public A()
        {
            System.Console.WriteLine("Root Parent");
        }

        public void Something()
        {
            System.Console.WriteLine("Base something");
        }
    }

    public class B : A
    {
        public B()
        {
            System.Console.WriteLine($"Middle Parent");
            Something();
        }

        public new void Something()
        {
            System.Console.WriteLine("Derived something");
        }
    }

    public class C : B
    {
        public C()
        {
            System.Console.WriteLine("Leaf Child");
        }
    }
}