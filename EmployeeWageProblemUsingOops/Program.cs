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
            int isPresent = 1;
            // Welcome message
            Console.WriteLine("Welcome to Employee wage problem");
            // UC-1 EmpAttendance
            Random random = new Random();
            int empAttendance = random.Next(0, 2); // 0 or 1
           if(empAttendance == isPresent)
            {
                Console.WriteLine("employee attendance is present");
            }
            else
            {
                Console.WriteLine("employee attendance is absent");
            }
            Console.ReadLine();
            

        }
    }
}
