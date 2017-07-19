using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _401K_Calculator
{
    class compound_interest
    {
         [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        public static void compound()
        {
            double k_amount = 0;
            //account balance each paycheck

            double interest;
            //rate of return of account

            int years;
            //number of years until retirement

            double balance = 0;
            //starting amount in 401K

            double rate;
            //Hourly rate

            double percent;
            //401K contribution percent

            double contribution;
            //401K contribution amount each check

            double retirement = 0;
            //401K ending balance

            double yearly_cont = 0;

            int installments = 26;
            //contributions each year 

            int hours_worked = 0;
            //weekly hours worked


            AllocConsole();

            Console.WriteLine("Enter hourly rate");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter weekly hours worked");
            hours_worked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 401K contribution percent");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter account starting value");
            balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter estimated rate of return for 401K account");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Enter number of Years until retirement");
            years = Convert.ToInt32(Console.ReadLine());



            contribution = (percent / 100) * (rate * hours_worked);
            k_amount = balance + (contribution * installments);
            yearly_cont = contribution * installments;
            decimal yearly_cont_mon = 0;
            yearly_cont_mon = Convert.ToDecimal(yearly_cont);


            Console.WriteLine("Estimated  yearly 401K contribution : {0}", yearly_cont_mon.ToString("C"));
            //Console.WriteLine(yearly_cont_mon.ToString("C"));


            for (double i = 0; i <= years; i++)
            {
                retirement = (k_amount * Math.Pow((1 + interest), years) + (yearly_cont * (Math.Pow((1 + interest), years) - 1)/interest));
            }

            Console.WriteLine("Estimated 401K balance at retirement : {0}", retirement);
                  
            Console.ReadLine();
        }
    }
}

