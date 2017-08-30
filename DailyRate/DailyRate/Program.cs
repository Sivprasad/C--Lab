using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRateV2
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            //  double fee = calculateFee();
            //double fee = calculateFee(650.0);
            //double fee = calculateFee(500.0,3);
          //  double fee = calculateFee(dailyRate : 370.50);
            double fee = calculateFee(theDailyRate : 375);
            Console.WriteLine($"Fee is {fee}");
            //double fee = calculateFee()

        }


        double calculateFee(double theDailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("Calculate using two optional parameters");
            return theDailyRate * noOfDays;
        }

        double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("Calculate using one optional parameters");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        double calculateFee()
        {
            Console.WriteLine("Calculate using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }


    }


}

 