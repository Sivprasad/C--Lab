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
            double dailyRate = readDouble("Enter your daily rate");
            int noOfDays = readInt("Enter the number of days");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        double readDouble(string v)
        {
            Console.WriteLine(v);
            string line = Console.ReadLine();
            return double.Parse(line);

        }

        int readInt(string v)
        {
            Console.WriteLine(v);
            string line = Console.ReadLine();
            return int.Parse(Console.ReadLine());
        }
          double calculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;
       

     

        void writeFee(double calculateFee) => Console.WriteLine($"The consulten fee is {calculateFee * 1.1}");
        
    }
}

 