using System;

class FixedDebugNine3

{

public static void Main()

{
//create objects of class Car
Car myCar = new Car(32000, "red");

Car yourCar = new Car(14000);

Car theirCar = new Car();
//display values
Console.WriteLine("My {0} car cost {1}", myCar.Color,myCar.Price.ToString("c2"));

Console.WriteLine("Your {0} car cost {1}",yourCar.Color, yourCar.Price.ToString("c2"));

Console.WriteLine("Their {0} car cost {1}",theirCar.Color, theirCar.Price.ToString("c2"));

}

}

class Car

{
//declare variables
private string color;

private int price;
//default constructor to set values
public Car()

{

color = "black";

price = 10000;

}
//parameterized constructor to set values
public Car(int prc)

{

color = "black";

price = prc;

}
//parameterized constructor to set values
public Car(int prc, string clr)

{

price = prc;

color = clr;

}
//getter and setter methods for Color
public string Color

{

get

{

return color;

}

set

{

color = value;

}

}

//getter and setter methods for Price
public int Price

{

get

{

return price;

}

set

{

price = value;

}

}

}
