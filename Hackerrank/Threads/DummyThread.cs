using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hackerrank.Threads
{
    public class DummyThread
    {
        private TaskCompletionSource<string> _taskCompletionSource;
        public async void Start()
        {
            var tcs = new CancellationTokenSource();
            _taskCompletionSource = new TaskCompletionSource<string>();
            
            var thread = new Thread(new ThreadStart(SomeWork));

            var task1 = Task.Run(() =>
            {
                Console.WriteLine("Run in Task");
            });

            var task2 = Run(tcs.Token);

            await Task.WhenAll(new [] { task1, task2 });   

            //System.Console.WriteLine(task2?.Exception?.Message);
            
            //thread.Start();

            Thread.Sleep(1000);
            //tcs.Cancel();
            Console.WriteLine("Started");

            Console.WriteLine("Successfully completed");
        }

        private Task Run(CancellationToken token)
        {
            Task task = null;

            try
            {
                task = new Task(() => RunSomeTask(), token);
                task.Start();
                task.Wait();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Got exception");
            }
            finally
            {
                System.Console.WriteLine(task.Status);
            }

            return new Task(() => {});
        }

        private Task<string> RunSomeTask()
        {
            Thread.Sleep(3000);

            throw new Exception("Custom Exception thrown from runsometask");

            Console.WriteLine("Run some task executed");
            _taskCompletionSource.SetResult("updated");
            return _taskCompletionSource.Task;
        }

        private void SomeWork()
        {
            Console.WriteLine("Work going on");
        }
    }
}