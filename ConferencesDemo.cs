using System;
using static System.Console;
class ConferencesDemo
{
   static void Main()
   {
      Conference[] meets = new Conference[5];
      for(int x = 0; x < meets.Length; ++x)
        {
          meets[x] = new Conference();
          WriteLine("Enter Group:");
          meets[x].Group = ReadLine();

          WriteLine("Enter Date:");
          meets[x].Date = ReadLine();

          WriteLine("Enter Attendees:");
          meets[x].Attendees = Convert.ToInt32(ReadLine());
        }
      Array.Sort(meets);
      for(int x = 0; x < meets.Length; ++x)
      {
        WriteLine("{0} Conference starts on {1} and has {2} Attendees",meets[x].Group,meets[x].Date,meets[x].Attendees);
      }
   }
}

class Conference : IComparable
{
  public string Group{get; set;}
  public string Date{get; set;}
  public int Attendees{get; set;}

  int IComparable.CompareTo(Object o)
  {
    int returnVal;
    Conference temp = (Conference)o;
    if(this.Attendees > temp.Attendees)
      {
          returnVal = 1;
      }
    else if (this.Attendees < temp.Attendees)
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
