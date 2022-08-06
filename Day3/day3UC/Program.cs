namespace day3UC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// Start ////////////
            Console.WriteLine("Welcome to Employee Wage Computation Program !!!");
            Console.WriteLine();

            ////////////////////UC1-Employee present or absent/////////
            UC1 uc1 = new UC1();
           uc1.EmployeepresentAbsent();
            Console.WriteLine();



            ////////////////////UC2-Calculate Daily Employee Wage/////////
            UC2 uc2 = new UC2();
            uc2.DailyWage();
            Console.WriteLine();

            ////////////////////UC3-Add Part time Employee & Wage/////////
            UC3 uc3 = new UC3();
            uc3.PartTimeFullTime();
            Console.WriteLine();

            ////////////////////UC4-Solving using Switch Case Statement ///////////
            UC4 uc4 = new UC4();
            uc4.SwitchCasePartTimeFullTime();
            Console.WriteLine();

            ///////////////////UC5-Calculating Wages for a Month ///////////
            UC5 uc5 = new UC5();
            uc5.MonthlyWage();
            Console.WriteLine();

            ///////////////////UC6 -Calculate Wages till a condition of total working hours or days is reached for a month - Assume 100 hours ///////////
            UC6 uc6 = new UC6();
            uc6.MonthlyWage();
            Console.WriteLine();



        }
    }
}