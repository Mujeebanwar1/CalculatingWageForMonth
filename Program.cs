namespace CalculatingWageForMonth
{
    class MonthWage20WorkingDays
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[]args)
        {
            int empHur = 0, empWage = 0, totalEmpWage = 0;


                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHur = 4;
                        break;
                    case IS_FULL_TIME:
                        empHur = 8;
                        break;
                    default:
                        empHur = 0;
                        break;
                }
                empWage = empHur * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }

            Console.WriteLine("Total Emp Wage :" + totalEmpWage);

        }
        
    }
}