﻿class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    public const int MAX_HRS_IN_MONTH = 10;

    public static int computeEmpWage;
    {
        int EmpHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = Random.Next(0, 3);   
            switch (empCheck)
    
            {
                case IS_PART_TIME;
                    EmpHrs = 4;
                    break;
                case IS_FULL_TIME;
                     EmpHrs = 8;
                     break;
                default:
                     EmpHrs = 0;
                     break;
           }
           totalEmpHrs = emphrs; 
           Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + EmpHrs); 
       }
       int totalEmpWage = totalEmpHrs + EMP_RATE_PER_HOUR;
       Console.WriteLine("total Emp Wage: " + totalEmpWage);
       return totalEmpWage;
  }
  static void Main(string[] args)
  {
    computeEmpWage();

  }
}





