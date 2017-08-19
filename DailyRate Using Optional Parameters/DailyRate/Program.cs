using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = radInt("Enter the number of days : ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

       
        private double readDouble(string v)
        {
            Console.Write(v );
            string line = Console.ReadLine();
            return double.Parse(line);
        }
        private int radInt(string v)
        {
            Console.Write (v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }
        private double calculateFee(double dailyRate, double noOfDays) => dailyRate * noOfDays;

        private void writeFee(double v)  =>Console.WriteLine($"The cousultant's fee is :{v *1.1}");
      
           
         


    }
}
