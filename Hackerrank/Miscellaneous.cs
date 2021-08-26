using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using Hackerrank.Interface;
using Hackerrank.Misc;
using Hackerrank.Threads;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class Miscellaneous : IRunnable
    {
        public event RunDel RunEvent1;

        public delegate void RunDel();

        public virtual int MyProperty { get; set; }

        public virtual int this[int index]
        {
            get => MyProperty;
            set => MyProperty = value;
        }

        public event RunDel RunEvent
        {
            add => RunEvent1 += value;
            remove => RunEvent1 -= value;
        }
        public string Run(string[] args)
        {
            //RunEvent += () => { System.Console.WriteLine("Executed in Event"); };

            //BenchmarkRunner.Run<Miscellaneous>();
            // var hex = new HexaDecimal();
            // var number = int.Parse(args[0]);
            // var result = hex.ConvertToHex(number);

            // try
            // {
            //     var thread = new DummyThread();
            //     thread.Start();
            //     RunEvent1();
            // }
            // catch (System.Exception e)
            // {
            // }

            var obj = new Test();

            System.Console.WriteLine(obj.Func(30));
            System.Console.WriteLine(obj.Func(3.4f));
            
            
            return string.Empty;
        }

        [Benchmark]
        public void TestWithBenchMark()
        {
            Misc5 m1 = new();
            m1.Test();
        }
    }

    public partial class Test
    {
        public int Func(int number)
        {
            (int, bool) []arr = new (int, bool)[10];
            int []a = {1};
            int tmp = number + 20;
            return tmp;
        }

        public Single Func(float number)
        {
            Single tmp = number + 2.5f;
            return tmp;
        }
    }
}