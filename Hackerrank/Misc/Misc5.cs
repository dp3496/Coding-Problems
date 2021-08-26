using System.Threading;
using System.Threading.Tasks;

namespace Hackerrank.Misc
{
    public class Misc5
    {
        public void Test()
        {
            ISomething<string> something = new Something<string>();
            something.GetSomething("Hello");
        }

        public class InnerClass
        {

        }
    }

    public interface ISomething<in T>
    {
        string GetSomething(T input);
    }

    public class Something<T> : ISomething<T>
    {
        public string GetSomething(T input)
        {
            Misc5.InnerClass innerClass = new Misc5.InnerClass();
            Parallel.For(0, 1000, new ParallelOptions{ MaxDegreeOfParallelism = -1 },
                         async x => await GetSomethingAsyncInternal(x));

            return input.ToString();

            async Task<string> GetSomethingAsyncInternal(int x)
            {
                return await GetSomethingAsync(x);
            }
        }

        public Task<string> GetSomethingAsync(int x)
        {
            //System.Console.WriteLine($"Started Running {x} {Thread.CurrentThread.ManagedThreadId}");
            var tcs = new TaskCompletionSource<string>();
            tcs.TrySetResult("Result Set");
            return tcs.Task;
        }
    }
}