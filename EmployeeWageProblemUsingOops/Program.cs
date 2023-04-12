using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            int empHrs = 0;
            int isPresent = 1;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            
            // Welcome message
            Console.WriteLine("Welcome to Employee wage problem");
            // UC-1 EmpAttendance
            Random random = new Random();
            int empAttendance = random.Next(0, 2); // 0 or 1
           if(empAttendance == isPresent)
            {
                Console.WriteLine("employee attendance is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee attendance is absent");
                empHrs = 0;
            }
            // UC-2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:" + empWage);
            Console.ReadLine();
            

        }
    }
}
