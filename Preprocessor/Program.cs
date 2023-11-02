#define aaa
using System;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (aaa)
            Console.WriteLine("sample");
            #endif            
        }
    }
}
