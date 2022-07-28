using System;

namespace PaycheckCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Employee | Base Pay | Hours Worked | Total Pay |");
            Console.WriteLine("| --- | -- | --- | ---| -------------| ---- | ---|");
            Console.WriteLine(FormatEmployee("Employee 1", 7.50, 35));
            Console.WriteLine(FormatEmployee("Employee 2", 8.20, 47));
            Console.WriteLine(FormatEmployee("Employee 3", 10.00, 73));
        }

        static string FormatEmployee(string name, double basePay, int hoursWorked)
        {
            string employeeWage = GetWage(basePay, hoursWorked);

            return $"| {name} | ${basePay} | {hoursWorked} | {employeeWage} |";
        }

        static string GetWage(double basePay, int hoursWorked)
        {
            if (hoursWorked > 60 || basePay < 8) 
            {
                return "error"; 
            }

            const int BasePayMaxHours = 40;
            const double OvertimeMultiplier = 1.5;

            int overtimeHours = 0;
            
            if (hoursWorked > BasePayMaxHours)
            {
                overtimeHours = hoursWorked - BasePayMaxHours;
                hoursWorked -= overtimeHours;
            }

            double wage = (hoursWorked * basePay) + overtimeHours * (basePay * OvertimeMultiplier);

            return $"${Math.Round(wage, 2)}";
        }
    }
}
