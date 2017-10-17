using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRIght = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRIght);
            Console.WriteLine($"Distance is : {distance}");
            Console.WriteLine($"Number of Poin objexts: {Point.ObjectCount()} ");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
