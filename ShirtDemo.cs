using static System.Console;
class ShirtDemo
{
   static void Main()
   {
      Shirt S1 = new Shirt();
      S1.Material = "Cotton";
      S1.Color = "SlayTeam Red";
      S1.Size = "SlayTeam Large";

      Shirt S2 = new Shirt();
      S2.Material = "Cotton";
      S2.Color = "SlayTeam Blue";
      S2.Size = "SlayTeam Medium";

      Display(S1,S2);
   }
   public static void Display(params Shirt[] shirts)
   {
      for(int x = 0; x < shirts.Length; ++x)
        {
          WriteLine("Shirt #"+(x+1)+" Material: "+shirts[x].Material);
          WriteLine("Shirt #"+(x+1)+" Color: "+shirts[x].Color);
          WriteLine("Shirt #"+(x+1)+" Size: "+shirts[x].Size);
          WriteLine("=============================");
        }
   }
}
class Shirt
{
  public string Material {get; set;}
  public string Color{get; set;}
  public string Size{get;set;}
}
