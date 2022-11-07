using static System.Console;
class FractionDemo2
{
   static void Main()
   {
      Fraction f1 = new Fraction(2, 3);
      Fraction f2 = new Fraction(4, 5);
      Fraction f3 = new Fraction();
      f3 = f1 * f2;
      WriteLine("{0} * {1} = {2}",
       f1.FracString(), f2.FracString(), f3.FracString());
      f1.WholeNum = 1;
      f3 = f1 * f2;
      WriteLine("{0} * {1} = {2}",
         f1.FracString(), f2.FracString(), f3.FracString());
      f2.Numerator = 8;
      f2.Reduce();
      f3 = f1 * f2;
      WriteLine("{0} * {1} = {2}",
         f1.FracString(), f2.FracString(), f3.FracString());
   }
}   
class Fraction
{
   private int wholeNum;
   private int numerator;
   private int denominator;
   
   public Fraction(int w, int n, int d)
   {
      WholeNum = w;
      Numerator = n;
      Denominator = d;
   }
   public Fraction(int n, int d) : this(0, n, d)
   {
   }
   public Fraction() : this(0, 0, 1)
   {
   }
   public int WholeNum
   {
      get
      {
         return wholeNum;
      }
      set
      {
         wholeNum = value;
      }
   }
   public int Numerator
   {
      get
      {
         return numerator;
      }
      set
      {
         numerator = value;
      }
    }
    public int Denominator
    {
       get
       {
          return denominator;
       }
       set
       {
          if(value != 0)
             denominator = value;
          else
             denominator = 1;
       }
    }
    public static Fraction operator+(Fraction f1, Fraction f2)
    {
       int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator) *
           f2.Denominator;
       int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator) *
           f1.Denominator;
       int num = num1 + num2;
       int denom = f1.Denominator * f2.Denominator;
       Fraction newFrac = new Fraction(num, denom);
       newFrac.Reduce();
       return newFrac;
    }
    public static Fraction operator*(Fraction f1, Fraction f2)
    {
       int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator);
       int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator);
       int num = num1 * num2;
       int denom = f1.Denominator * f2.Denominator;
       Fraction newFrac = new Fraction(num, denom);
       newFrac.Reduce();
       return newFrac;
    }
    public void Reduce()
    {
       int gcd;
       int y;
       if(numerator >= denominator)
       {
    	  wholeNum += numerator / denominator;
	  numerator = numerator % denominator;
       }
       gcd = 1;
       for(y = numerator; y > 0; --y)
       {
	  if(numerator % y == 0 && denominator % y == 0)
          {
             gcd = y;
             y = 0;
          }
       }
       numerator /= gcd;
       denominator /= gcd;
     }
     public string FracString()
     {
        string fracString;
        if(WholeNum == 0 && Numerator == 0)
             fracString = "0";
        else
          if(WholeNum == 0)
             fracString = Numerator + "/" + Denominator;
        else
          if(Numerator == 0)
             fracString = "" + WholeNum;
          else
             fracString = WholeNum + " " + Numerator +
                "/" + Denominator;
        return fracString;
     }    
    
   
}
