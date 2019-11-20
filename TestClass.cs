using System;

namespace TestNuGetCIDI
{
    public static class TestClass
    {
        public static void PrintHelloWorld() => Console.WriteLine("Hello World!");
        public static void Print(string str = "HelloWorld") => Console.WriteLine(str);
    }
}
