using System;
using System.Linq;
using Hackerrank.Interface;

namespace Hackerrank
{
    class Program
    {
        private static MyIoc IOC = new MyIoc();

        static Program()
        {
            RegisterProblems();   
        }
        static void RegisterProblems()
        {
            IOC.RegisterObject<IRunnable, FibonacciModified>();
            IOC.RegisterObject<IRunnable, ArraySum>();
            IOC.RegisterObject<IRunnable, StringReduction>();
            IOC.RegisterObject<IRunnable, CodilityTest1>();
            IOC.RegisterObject<IRunnable, CodilityTest2>();
            IOC.RegisterObject<IRunnable, CodilityTest3>();
            IOC.RegisterObject<IRunnable, Questions>();
            IOC.RegisterObject<IRunnable, LinkedListTest>();
            IOC.RegisterObject<IRunnable, MergeSortTest>();
            IOC.RegisterObject<IRunnable, ArrayDS>();
            IOC.RegisterObject<IRunnable, MaxSubArrayValue>();
            IOC.RegisterObject<IRunnable, HotelConstruction>();
            IOC.RegisterObject<IRunnable, StringGroup>();
            IOC.RegisterObject<IRunnable, CompanyNameResolver>();
            IOC.RegisterObject<IRunnable, NonDivisibleSubset>();
            IOC.RegisterObject<IRunnable, BetweenTwoSets>();
            IOC.RegisterObject<IRunnable, UniqueSum>();
            IOC.RegisterObject<IRunnable, StringVowelFinder>();
            IOC.RegisterObject<IRunnable, TeamMatchesFinder>();
            IOC.RegisterObject<IRunnable, MatrixSpecialPosCounter>();
            IOC.RegisterObject<IRunnable, Palindrome>();
            IOC.RegisterObject<IRunnable, SortTheArray>();
            IOC.RegisterObject<IRunnable, ArrayManipulation>();
            IOC.RegisterObject<IRunnable, MaximiseBitwise>();
            IOC.RegisterObject<IRunnable, ArrayChallenge>();
            IOC.RegisterObject<IRunnable, SpecialNumber>();
            IOC.RegisterObject<IRunnable, MinCostDeletion>();
            IOC.RegisterObject<IRunnable, Miscellaneous>();
            
            using (var db = new HackerrankContext())
            {
                db.Add<Problem>(new Problem{Id = 1, Name = nameof(FibonacciModified)});
                db.Add<Problem>(new Problem{Id = 2, Name = nameof(ArraySum)});
                db.Add<Problem>(new Problem{Id = 3, Name = nameof(StringReduction)});
                db.Add<Problem>(new Problem{Id = 4, Name = nameof(CodilityTest1)});
                db.Add<Problem>(new Problem{Id = 5, Name = nameof(CodilityTest2)});
                db.Add<Problem>(new Problem{Id = 6, Name = nameof(CodilityTest3)});
                db.Add<Problem>(new Problem{Id = 7, Name = nameof(Questions)});
                db.Add<Problem>(new Problem{Id = 8, Name = nameof(LinkedListTest)});
                db.Add<Problem>(new Problem{Id = 9, Name = nameof(MergeSortTest)});
                db.Add<Problem>(new Problem{Id = 10, Name = nameof(ArrayDS)});
                db.Add<Problem>(new Problem{Id = 11, Name = nameof(MaxSubArrayValue)});
                db.Add<Problem>(new Problem{Id = 12, Name = nameof(HotelConstruction)});
                db.Add<Problem>(new Problem{Id = 13, Name = nameof(StringGroup)});
                db.Add<Problem>(new Problem{Id = 14, Name = nameof(CompanyNameResolver)});
                db.Add<Problem>(new Problem{Id = 15, Name = nameof(NonDivisibleSubset)});
                db.Add<Problem>(new Problem{Id = 16, Name = nameof(BetweenTwoSets)});
                db.Add<Problem>(new Problem{Id = 17, Name = nameof(UniqueSum)});
                db.Add<Problem>(new Problem{Id = 18, Name = nameof(StringVowelFinder)});
                db.Add<Problem>(new Problem{Id = 19, Name = nameof(TeamMatchesFinder)});
                db.Add<Problem>(new Problem{Id = 20, Name = nameof(MatrixSpecialPosCounter)});
                db.Add<Problem>(new Problem{Id = 21, Name = nameof(Palindrome)});
                db.Add<Problem>(new Problem{Id = 22, Name = nameof(SortTheArray)});
                db.Add<Problem>(new Problem{Id = 23, Name = nameof(ArrayManipulation)});
                db.Add<Problem>(new Problem{Id = 24, Name = nameof(MaximiseBitwise)});
                db.Add<Problem>(new Problem{Id = 25, Name = nameof(ArrayChallenge)});
                db.Add<Problem>(new Problem{Id = 26, Name = nameof(SpecialNumber)});
                db.Add<Problem>(new Problem{Id = 27, Name = nameof(MinCostDeletion)});
                db.Add<Problem>(new Problem{Id = 28, Name = nameof(Miscellaneous)});
                db.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            string problemName = string.Empty;

            using (var db = new HackerrankContext())
            {
                System.Console.WriteLine("Available Problems");
                var problems = db.Problems;

                foreach (var problem in problems)
                {
                    System.Console.WriteLine($"{problem.Id} : {problem.Name}");
                }

                System.Console.WriteLine("Select problem to run with Id");
                var inputId = Console.ReadLine();
                int.TryParse(inputId, out var problemId);
                problemName = problems.First(x => x.Id == problemId).Name;
            }
            var runnable = IOC.GetObject<IRunnable>(problemName);

            var programDetails = Console.ReadLine().Split();
            var result = runnable.Run(programDetails);
            System.Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
