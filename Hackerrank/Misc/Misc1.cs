namespace Hackerrank.Misc
{
    public class Misc1
    {
        public void Test()
        {
            int b = 0;
            ref int c = ref b;
            C1 c1 = new C1();
            c1.TestWithRef(ref c);
            c1.TestWithOut(out var num);
            c1.AnotherThing();
            
            A1 c2 = new C1();
            c2.Something();
        }
    }

    public class A1
    {
        public void TestWithRef(ref int a)
        {

        }

        public void TestWithOut(out int a)
        {
            a = 10;
        }

        public virtual void Something()
        {
            System.Console.WriteLine("From A1");
        }
    }

    public class B1 : A1
    {
        public override void Something()
        {
            System.Console.WriteLine("From B1");
        }
    }

    public class C1 : B1
    {
        public new void Something()
        {
            System.Console.WriteLine("From C1");
        }

        public void AnotherThing()
        {
            Something();
        }
    }
}