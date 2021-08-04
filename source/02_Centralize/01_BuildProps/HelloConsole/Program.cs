namespace HelloConsole
{
    using System;
    using HelloLibs;

    class Program
    {
        private Greeting _greeting;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }

        static void Print(Greeting greet){
            Console.WriteLine(greet.Greet);
        }
    }
}
