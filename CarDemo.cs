using static System.Console;
class CarDemo
{
   static void Main()
   {
      Car C1 = new Car("Crown Vick", 38.50);
      Car C2 = new Car("Delorean");

      Display(C1);
      Display(C2);

   }
   public static void Display(Car s)
   {
      WriteLine("------Before ++ Operator-----");
      WriteLine("Model: "+ s.Model);
      WriteLine("MPG: "+ s.Mpg);
      ++s;
      WriteLine("------After ++ Operator------");
      WriteLine("Model: "+ s.Model);
      WriteLine("Updated MPG: "+ s.Mpg);
      WriteLine("-----------------------------");
   }
}

class Car
{
  public string Model;
  public double Mpg;

  public Car(string model, double mpg)
  {
    Model = model;
    Mpg = mpg;
  }

  public Car(string model)
  {
    Model = model;
    Mpg = 20;
  }

  public static Car operator++(Car one)
  {
    one.Mpg = one.Mpg + 1;
    return one;
  }
}
