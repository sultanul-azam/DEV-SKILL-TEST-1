using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5Test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int year = 0;
            int month = 0;
            int day = 0;
            int inputYear, inputMonth, inputDay = 0;           

            bool validYear = false;   
            while (validYear == false)
            {
                Console.Write("Enter your year : ");
                inputYear = Convert.ToInt32(Console.ReadLine());
                validYear = CheckValidYear(inputYear);
                if (validYear == false)
                {
                    Console.WriteLine("Sorry, you provide an invalid year. Try again.");
                }
                else
                {
                    year = inputYear;                   
                    break;
                }   
            }

            bool validMonth = false;
            while (validMonth == false)
            {
                Console.Write("Enter your month : ");
                inputMonth = Convert.ToInt32(Console.ReadLine());
                validMonth = CheckValidMonth(inputMonth);
                if (validMonth == false)
                {
                    Console.WriteLine("Sorry, you provide an invalid month. Try again.");
                }
                else
                {
                    month = inputMonth;
                    break;
                }
            }

            bool validDay = false;
            while (validDay == false)
            {                
                Console.Write("Enter your day : ");
                inputDay = Convert.ToInt32(Console.ReadLine());
                validDay = CheckValidDay(inputDay, month);
                if (validDay == false)
                {
                    Console.WriteLine("Sorry, you provide an invalid day. Try again.");
                }
                else
                {
                    day = inputDay;
                    break;
                }
            }

            
            if (month == 1)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "JAN-" + year);
            }
            else if(month == 2)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "FEB-" + year);
            }
            else if (month == 3)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "MAR-" + year);
            }
            else if (month == 4)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "APR-" + year);
            }
            else if (month == 5)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "MAY-" + year);
            }
            else if (month == 6)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "JUN-" + year);
            }
            else if (month == 7)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "JUL-" + year);
            }
            else if (month == 8)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "AUG-" + year);
            }
            else if (month == 9)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "SEP-" + year);
            }
            else if (month == 10)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "OCT-" + year);
            }
            else if (month == 11)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "NOV-" + year);
            }
            else if (month == 12)
            {
                Console.WriteLine("Your Date is : " + day + "-" + "DEC-" + year);
            }         

            Console.ReadKey();
        }

        public static bool CheckValidYear(int? year)
        {            
            if (year != null && year > 1971 && year <= 2019)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckValidMonth(int? month)
        {           
            if (month != null && month >= 1 && month <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckValidDay(int? day, int month)
        {
            bool result = false; ;
            int[] firstMonthRange = { 4, 6, 9, 11 };
            int[] secondMonthRange = { 1, 3, 5, 7, 8, 10, 12 };

            if (day != null && day >= 1 && day <= 31)
            {
                if ((month == 2 && day <= 28) || (firstMonthRange.Contains(month) && day <= 30) || (secondMonthRange.Contains(month) && day <= 31))
                {
                    result = true;                    
                }   
            }
            else
            {
                result = false;               
            }
            return result;
        }
    }
}
