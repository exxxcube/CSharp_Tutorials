using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorials.Class
{
    class LeapYearDateTime
    {
        //This will check if the year is a leap year or not
        public void LeapYear()
        {            
            DateTime thisYear = new DateTime(2011, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year); //check if the year is a leap year using IsLeapYear
            Console.WriteLine(isLeapYear); // print the result
        }
        public void DateTimeFunc()
        {
            #region DateTime Examples
            //DateTime thisMoment = DateTime.Now; //This will return the current Date and Time
            //Console.WriteLine("Current Date and Time: " + thisMoment); //print the current date and time
            //DateTime anHourFromNow = thisMoment.AddHours(1); //This will add 1 hour of the current time
            //Console.WriteLine("Current Date and Time added an hour: " + anHourFromNow); //print the current date and time plus 1 hour
            #endregion

            #region Extracting specific parts of a DateTime
            ////Extracting specific parts of a DateTime
            //int year = DateTime.Now.Year; //Get the Year of the current date
            //Console.WriteLine(year); // print the year of the current date
            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek; //Get the Day of the week of the current date
            //Console.WriteLine(dayOfWeek);// print the current day of the week            
            #endregion

            #region Manipulating date and time 
            //DateTime date = DateTime.Today; // Get just the date part.
            //Console.WriteLine("Date Today: " + date);
            //TimeSpan time = thisMoment.TimeOfDay; // Get just the time part.
            //Console.WriteLine("Time: " + time);
            //TimeSpan duration = new TimeSpan(3, 0, 0, 0); // Specify duration in days.            
            //DateTime threeDaysFromNow = thisMoment.Add(duration); // add the duration for 3 days
            //Console.WriteLine(threeDaysFromNow);//print the result
            #endregion

            #region Subtracting DateTime from Another DateTime
            TimeSpan duration1 = new TimeSpan(1, 0, 0); // One hour later.
                                                        // Since Today gives 12:00:00 AM (midnight), the following gives 1:00:00 AM:
            DateTime anHourAfterMidnight = DateTime.Today.Add(duration1);
            Console.WriteLine("An hour from midnight will be {0}", anHourAfterMidnight);
            DateTime midnight = anHourAfterMidnight.Subtract(duration1); //Subtracting the date using the TimeSpan duration
            Console.WriteLine("An hour before 1 AM is {0}", midnight);
            #endregion
        }
    }
}
