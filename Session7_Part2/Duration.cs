using System;
using System.Collections.Generic;
using System.Text;

namespace Session7_Part2
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }



        //public override string ToString()
        //{
        //    return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        //}

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";

            if (Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";

            return $"Seconds :{Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration d)
                return Hours == d.Hours &&
                       Minutes == d.Minutes &&
                       Seconds == d.Seconds;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
    }
}
