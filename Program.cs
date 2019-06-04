using System;
using Newtonsoft.Json;

namespace TryDotNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "HelloWorld":
                    HelloWorld();
                    break;
                case "Addition":
                    Addition();
                    break;
                case "Json":
                    Json();
                    break;
            }
        }

        static void HelloWorld()
        {
            #region HelloWorld
            Console.WriteLine("Hello World!");
            #endregion HelloWorld
        }

        static void Addition()
        {
            #region Addition
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
            #endregion Addition
        }

        static void Json()
        {
            #region Json
            var x = new { name = "Try .NET", status = "Awesome" };
            var json = JsonConvert.SerializeObject(x);
            Console.WriteLine(json);
            #endregion Json
        }
    }
}
