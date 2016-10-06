using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockHandsAngle
{
    class Program
    {
        //given a time find the angle between hands
        static void Main(string[] args)
        {
            //variables
            int total_degrees = 360;
            int minute_per_minute;
            int hour_per_minute;
            int degrees_per_hour;

            minute_per_minute = total_degrees / 60;
            degrees_per_hour = total_degrees / 12;
            hour_per_minute = degrees_per_hour / 60;

            int hour;
            int min;
            string time;
            string repeat = "y";

            

            while (repeat == "y")
            {
                Console.WriteLine("Please enter the time in form hour:min ");
                time = Console.ReadLine();

                string[] newString = time.Split(':');
                Int32.TryParse(newString[0], out hour);
                Int32.TryParse(newString[1], out min);
                if (hour > 12 || min > 59) {
                    repeat = "y";
                    continue;
                }
                
                int angle_min = minute_per_minute * min;
                int angle_hour = (degrees_per_hour * hour) + (hour_per_minute * min);

                Console.WriteLine("The angle between the hour and minute hands are: ");
                if (angle_hour > angle_min)
                {
                    Console.WriteLine(angle_hour - angle_min + " degrees.");
                }
                else {
                    Console.WriteLine(angle_min - angle_hour + " degrees.");
                }
                Console.WriteLine("Would you like to try another time? ");
                repeat = Console.ReadLine();
                
            }
        }
    }
}
