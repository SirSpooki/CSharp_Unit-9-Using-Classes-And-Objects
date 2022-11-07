using System;
using static System.Console;
using System.Globalization;
class DemoJobs
{
   static void Main()
   {
      WriteLine("-----Original Jobs-----");
      Job J1 = new Job();
      J1.Description = "powerwashing";
      J1.Time = 3.5;
      J1.Hourly = 25.00;
      Display(J1);
    
      Job J2 = new Job();
      J2.Description = "Painting";
      J2.Time = 2;
      J2.Hourly = 18.50;
      Display(J2);

      WriteLine("-----Added Jobs------");
      Job J3 = J1+J2;
      Display(J3);
   }

   public static void Display(Job j)
   {
     WriteLine("Job Description: "+ j.Description);
     WriteLine("Time: "+ j.Time);
     WriteLine("Hourly Rate: "+ j.Hourly.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     WriteLine("Total: "+ j.Total);
   }
}

class Job
{
  public string Description {get; set;}
  private double time;
  private double hourly;
  public double Total{get; private set;}

  public double Time
  {
    get
    {
      return time;
    }

    set
    {
      time = value;
      Total = time*hourly;
    }
  }
   public double Hourly
   {
    get
    {
      return hourly;
    }

    set
    {
      hourly = value;
      Total = time*hourly;
    }
  }

  public static Job operator+(Job one, Job two)
  {
    string newDesc = one.Description +" and "+ two.Description;
    double newHour = one.Time + two.Time;
    double newRate = (one.Hourly+two.Hourly)/(double)2;
    Job J3 = new Job();
    J3.Description = newDesc;
    J3.Time = newHour;
    J3.Hourly = newRate;
    J3.Total = newRate * newHour+.005;

    return J3;

  }

  
}
