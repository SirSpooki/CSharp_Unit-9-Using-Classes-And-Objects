using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{
   static void Main()
   {
        SalesTransaction T1 = new SalesTransaction("Joe", 200.50, .2033);
        Display(T1);
   }
   public static void Display(SalesTransaction s)
   {
        WriteLine("Salesperson name: "+s.Name);
        WriteLine("Sales Amount: "+s.SalesAmount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Salesperson name: "+s.RATE+'%');
        WriteLine("Salesperson name: "+s.Commission.ToString("C", CultureInfo.GetCultureInfo("en-US")));

   }
   public static void DisplayTotal(SalesTransaction s)
   {
        WriteLine("bruh");
   }
}
class SalesTransaction
{
  public string Name;
  public double SalesAmount;
  public double Commission;
  public readonly double RATE;

  public SalesTransaction(string name, double salesAmount, double rate)
  {
    Name = name;
    this.SalesAmount = salesAmount;
    RATE = rate;
    Commission = salesAmount * rate;
  }

  public SalesTransaction(string name, double salesAmount)
  {
    Name = name;
    this.SalesAmount = salesAmount;
    RATE = 0.0;
    Commission = 0.0;
  }

  public SalesTransaction(string name)
  {
    Name = name;
    this.SalesAmount = 0.0;
    RATE = 0.0;
    Commission = 0.0;
  }

  public double getRate()
  {
    return RATE;
  }

   public static SalesTransaction operator +(SalesTransaction one, SalesTransaction two)
    {
        SalesTransaction three = new SalesTransaction(one.Name, 0, one.RATE);
        three.SalesAmount = one.SalesAmount + two.SalesAmount;
        return three;
    }


}
