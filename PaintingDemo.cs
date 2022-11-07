using static System.Console;
class PaintintDemo
{
   static void Main()
   {
      Room[] rooms = new Room[8];
      Room R1 = new Room(22, 15, 11);
      WriteLine("area: "+ R1.Area);
      WriteLine("gallons: "+ R1.Gallons);
   }
}
class Room
{
  public readonly int Area;
  public readonly int Gallons;

public Room(int length, int width, int height)
{
  Area = getArea(height, width, length);
  Gallons = numGallons(Area);
}

private int getArea(int h, int w, int l)
  {
      int Area;
      Area = 2*(h*w) + 2*(h*l);
      return Area;
  }
private int numGallons(int a)
{
    int gallons = 0;
    if (a / 350 == 0 || a / 350 < 0)
      {
        gallons = 1;
      }
    if (a / 350 != 0)
      {
        gallons = (a/350) + 1;
      }
    return gallons;
}
}
