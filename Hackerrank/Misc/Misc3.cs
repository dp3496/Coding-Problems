namespace Hackerrank.Misc
{
    public class Misc3
    {
        public void Test()
        {
            var t = new TestStruct(10);
            var t1 = new TestStruct(20);
            System.Console.WriteLine(t.Name);
            System.Console.WriteLine(t1.Id);
        }
    }
    
    public interface ITest
    {

    }

    public struct Test
    {
        public int Id { get; set; }
    }

    public struct TestStruct : ITest
    {
        static TestStruct()
        {
            System.Console.WriteLine("Static Constructor");
        }

        public TestStruct(int a)
        {
            Name = "Something";
            Id = a;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public void Something()
        {

        }

        public void Something(int a)
        {

        }
    }
}