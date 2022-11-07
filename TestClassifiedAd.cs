using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
   public static void Main()
   {
      ClassifiedAd myClassifiedAd = new ClassifiedAd();
      ClassifiedAd yourClassifiedAd = new ClassifiedAd();
      myClassifiedAd.Category = "Used cars";
      myClassifiedAd.Words = 100;
      yourClassifiedAd.Category = "Help wanted";
      yourClassifiedAd.Words = 60;

      myClassifiedAd.outputMessage();
      yourClassifiedAd.outputMessage();
   }
}
class ClassifiedAd
{
    private double price;

    public string Category {get; set;}
    public int Words {get; set;}
    public double Price
    {
      get
      {
        price = Words * .09;
        return price;
      }
    }

    public void outputMessage()
    {
      WriteLine("The classified ad with {0} words in category {1} costs {2}",Words, Category,Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}
