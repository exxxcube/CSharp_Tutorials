using System;

namespace Asynchronous_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);            
            Task.Delay(1000).Wait();
            while (!someTask.IsCompleted) 
            {
                
                Console.WriteLine("Not yet!");
                if (someTask.IsCompleted)
                {
                    Console.WriteLine("Done!");
                }
            }
            //if (!someTask.IsCompleted)
            //{
            //    Console.WriteLine("Not yet!");
            //}
            //else
            //{
            //    Console.WriteLine("Done!");
            //}            
        }        
    }
    static class DoAsyncStuff
    {
        public static async Task CalculateSumAsync(int i1, int i2)
        {
            int value = await Task.Run(() => GetSum(i1, i2));
            
            Console.WriteLine("Value: {0}",value);
        }
        private static int GetSum(int i1, int i2) { return  i1 + i2; }
    }
}