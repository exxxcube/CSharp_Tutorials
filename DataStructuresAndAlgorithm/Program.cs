using System;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        private static int AnnivYear = DateTime.Now.Year;
        private static int AnnivMonth = 10;
        private static int AnnivDay = 12;
        private static int hours = DateTime.Now.Hour;
        private static int minutes = DateTime.Now.Minute;
        private static int seconds = DateTime.Now.Second;

        static void Main(string[] args)
        {

            DateTime OfficialAnnivDate = new DateTime(AnnivYear, AnnivMonth, AnnivDay, hours, minutes, seconds);

            TimeSpan remaining =  OfficialAnnivDate - DateTime.Now;
            Console.WriteLine(remaining.TotalHours.ToString());

            //SortCommands sortcmd = new SortCommands();
            //int[] arr = { 12, 34, 56, 2, 1, 5, 5, 3, 2 };
            //Console.Write("{ ");
            //foreach (var item in sortcmd.BubbleShort(arr))
            //{
            //    Console.Write(item.ToString() +" ");
            //}
            //Console.Write("}");
            //Console.WriteLine("");
        }
    }
}
