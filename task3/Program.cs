using System;

namespace task3
{
    class Program
    {
        public class TestCase
        {
            public int X { get; set; }
            public ulong Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestFiboR(TestCase testCase)
        {
            try
            {
                var actual = fiboRec(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != ex)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestFiboCicle(TestCase testCase)
        {
            try
            {
                var actual = fiboCicle(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != ex)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static ulong fiboRec(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;

            return fiboRec(n - 1) + fiboRec(n - 2);
        }

        static ulong fiboCicle(int n)
        {
            ulong i, f1, f2, fSum;

            fSum = 0;
            f1 = 1;
            f2 = 1;

            if (n == 1) return 1;
            if (n == 2) return 1;
            i = 2;
            while (i < (ulong)n)
            {
                fSum = f2 + f1;
                f1 = f2;
                f2 = fSum;
                i += 1;
            }
            return fSum;            
        }
    static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 3,
                Expected = 1,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 7,
                Expected = 8,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                X = 2,
                Expected = 1,
                ExpectedException = null
            };

            var testCase4 = new TestCase()
            {
                X = 0,
                Expected = 0,
                ExpectedException = null
            };

            var testCase5 = new TestCase()
            {
                X = 35,
                Expected = 9227465,
                ExpectedException = null
            };

            /*Console.WriteLine(fiboRec(35));
            Console.WriteLine(fiboCicle(35));*/

            Console.WriteLine("Тест рекурсивной функции:");            
            TestFiboR(testCase1);
            TestFiboR(testCase2);
            TestFiboR(testCase3);
            TestFiboR(testCase4);
            TestFiboR(testCase5);

            Console.WriteLine("Тест циклической функции:");
            TestFiboCicle(testCase1);
            TestFiboCicle(testCase2);
            TestFiboCicle(testCase3);
            TestFiboCicle(testCase4);
            TestFiboCicle(testCase5);
        }
    }
}
