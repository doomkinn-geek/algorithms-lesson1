using System;

namespace task1
{
    class Program
    {
        public class TestCase
        {
            public ulong X { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestNum(TestCase testCase)
        {
            try
            {
                var actual = IsNumberSimple(testCase.X);

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
                if (testCase.ExpectedException != null)
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

        static string IsNumberSimple(ulong number)
        {
            ulong d = 0;
            ulong i = 2;

            
            while(i < number)
            {
                if(number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if(d == 0)
            {
                return "простое";
            }
            else
            {
                return "не простое";
            }
        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 6,               
                Expected = "не простое",
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 17,
                Expected = "простое",
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                X = 2,
                Expected = "простое",
                ExpectedException = null
            };

            var testCase4 = new TestCase()
            {
                X = 101,
                Expected = "не простое",
                ExpectedException = null
            };

            var testCase5 = new TestCase()
            {
                X = 102,
                Expected = "простое",
                ExpectedException = null
            };

            TestNum(testCase1);
            TestNum(testCase2);
            TestNum(testCase3);
            TestNum(testCase4);
            TestNum(testCase5);
        }
    }
}
