using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Kyle Fogarty-Anderson
//Student ID:30029389
//Date:25/09/2019

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the staff payroll system\nEnter 1. to display Salary\nEnter 2. to display Wages");//Display Options
            int option = int.Parse(Console.ReadLine());//input option

            if (option == 1)//option is = to 1 display salary
            {
                salary salaryone = new salary(); //Create new object of salary call it salaryone
                Console.WriteLine(salaryone.DisplaySalary());
                Console.ReadLine();
            }
            else//option is not = 1 display wages
            {
                wages wageone = new wages(); //Create new object of wages call it wageone
                Console.WriteLine("Enter the number of hours worked:"); //Ask user to input hours
                wageone.NumHours = int.Parse(Console.ReadLine()); //Take users input and set Numhours = to it
                Console.WriteLine(wageone.DisplayWages()); //Display weekly wage
                Console.ReadLine(); //Pause
            }
            
            
            
        }
    }

    class salary
    {
        double annualSalary = 8000;//Define variable and set value to 8000
        double weeklySalary;//Define variable

        public string DisplaySalary()//Method to display salary
        {
            weeklySalary = Math.Round((annualSalary / 52), 2);//divide 52 from annualsalary and round it 
            return $"Your salary per week is ${weeklySalary}"; //Display salary
        }

        public salary()//Constructor
        {
            Console.WriteLine($"Your Salary is set at: ${annualSalary} a year");//Display Yearly salary
        }
    }

    class wages
    {
        double hourlyRate = 33.72;//Define variables and set value to 33.72
        int numHours;//define variables
        double weeklyWages;//define variables

        public int NumHours//define getters and setters
        {
            get { return numHours; }
            set { numHours = value; }
        }

        public string DisplayWages()//Method that calculates weekly wage and returns value
        {
            weeklyWages = Math.Round((hourlyRate * numHours),2);
            return $"Your Wages per week are ${weeklyWages}";
        }

        public wages()//constructor
        {
            Console.WriteLine("I Will Calculate Your Wages");//display message
        }
    }
}
