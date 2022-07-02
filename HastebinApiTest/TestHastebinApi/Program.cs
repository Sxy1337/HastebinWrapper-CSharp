using HastebinApi;

namespace TestHastebinApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Api.CreatePaste("Hello World!"));
        }
    }
}