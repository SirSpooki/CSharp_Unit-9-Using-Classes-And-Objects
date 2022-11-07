using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo2
{
   static void Main()
   {
      Sale[] sales = new Sale[10];

      for(int x=0; x < sales.Length; ++x)
      {
        sales[x] = new Sale();
        Write("Enter inventory number #"+ (x+1) +" >> ");
        sales[x].InventoryNumber = ReadLine();
        Write("Enter amount of sale >> ");
        sales[x].Amount = Convert.ToDouble(ReadLine());
      }

      for(int x = 0; x < sales.Length; ++x)
      {
        int temp = x + 1;
        WriteLine("Sale # {0} Amount: {1} Sale {2}", temp, sales[x].InventoryNumber,sales[x].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("     Tax is {0}",sales[x].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      }

      Array.Sort(sales);

    WriteLine("-----After Sort-----");

     for(int x = 0; x < sales.Length; ++x)
      {
        int temp = x + 1;
        WriteLine("Sale # {0} Amount: {1} Sale {2}", temp, sales[x].InventoryNumber,sales[x].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("     Tax is {0}",sales[x].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      }

   }
}

class Sale : IComparable
{    
   public string InventoryNumber {get; set;}
   public double Tax {get; private set;}
   private double amount;
   
    public double Amount
    {
     get
     {
       return amount;
     }
     set
     {
       amount = value;
       CalculateTax();
     }
   }
   private void CalculateTax()
   {
     double temp = 0.0;
     double taxMon;

     if(Amount <= 100)
        {
             Tax = Amount * .08;
        }
     else
      {
      temp = 100 * .08;
      taxMon = (Amount - 100) * .06;
      Tax = taxMon+temp;
      }
   }
   int IComparable.CompareTo(Object o)
   {
     int returnVal;
     Sale temp = (Sale)o;
     if(this.Tax > temp.Tax)
        {
          returnVal = 1;
        }
     else if(this.Tax < temp.Tax)
        {
          returnVal = -1;
        }
    else
        {
          returnVal = 0;
        }
    return returnVal;
   }
   
}
