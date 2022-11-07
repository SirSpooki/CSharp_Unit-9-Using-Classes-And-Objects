using System;
using static System.Console;
class RelativesList
{
   static void Main()
   {
      Relative[] fam = new Relative[12];
      for(int x = 0; x < fam.Length; ++x)
        {
          fam[x] = new Relative();
          WriteLine("Enter Relative Name: ");
          fam[x].Name = ReadLine();
          WriteLine("Enter Relationship: ");
          fam[x].Relationship = ReadLine();
          WriteLine("Enter Birth Month: ");
          fam[x].Month = Convert.ToInt32(ReadLine());
          WriteLine("Enter Birth Day: ");
          fam[x].Day = Convert.ToInt32(ReadLine());
          WriteLine("Enter Birth Year: ");
          fam[x].Year = Convert.ToInt32(ReadLine());
        }
        Array.Sort(fam, (x,y) => String.Compare(x.Name, y.Name));
      for(int x = 0; x < fam.Length; ++x)
        {
          WriteLine($"{fam[x].Name}\t{fam[x].Relationship}\t{fam[x].Month}/{fam[x].Day}/{fam[x].Year}");
        }
   }
}

class Relative
{
  public string Name {get; set;}
  public string Relationship {get;set;}
  public int Month {get; set;}
  public int Day {get;set;}
  public int Year {get;set;}

   
}
