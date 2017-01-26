using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int takenPictures = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimeInSeconds = int.Parse(Console.ReadLine());

            long amountOfFilteredPictures = (long)Math.Ceiling(takenPictures * (filterFactor / 100.0));
            long uploadTime = amountOfFilteredPictures * uploadTimeInSeconds;
            long totalTime = uploadTime + ((long)takenPictures * filterTimeInSeconds);

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
        }
    }
}
