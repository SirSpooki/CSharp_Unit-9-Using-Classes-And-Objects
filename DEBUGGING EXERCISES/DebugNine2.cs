using System;
using static System.Console;
using System.Globalization;
class DebugNine2{
   static void Main(){
      Breakfast special = new Breakfast("French toast", 4.99);//missed ending "
      //Display the info about breakfast
      WriteLine(Breakfast.INFO); // we should access INFO using special
      // then display today's special
      WriteLine("Today we are having {0} for {1}",
     special.Name, special.Price.ToString("C2", CultureInfo.GetCultureInfo("en-US")));

  }
}
class Breakfast{
   public static string INFO ="Breakfast is the most important meal of the day.";
   private string name;
   private double price; // should start with lowercase
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   public Breakfast(string name, double price){
       this.name = name;
       this.price = price;
   }
   public string Name{
   get 
     {
        return name;
     }
   set 
    {
       name = value;
    }   
   }
   public double Price {
        get 
     {
        return price;
     }
   set 
    {
       price = value;
    }   
   } // missed ;
   
}
