using System.IO;
using System;

class BoatLicense
{
public const int HPCUTOFF = 50;
public const double LOWFEE = 25.00;
public const double HIGHFEE = 38.00;
private string licenseNum;
private string state;
private int motorSizeInHP;
private double price;
public string LicenseNum{
get{
return licenseNum;
}
set{
licenseNum = value;
}
}
public string State{
get{
return state;
}
set{
state = value;
}
}
public int MotorSizeInHP{
get{
return motorSizeInHP;
}
set{
motorSizeInHP = value;
if(MotorSizeInHP <= HPCUTOFF)
price = LOWFEE;
else
price = HIGHFEE;
}
}
public double Price{
get{
return price;
}
}
}


class Program
{
public static void Display(BoatLicense license){
Console.WriteLine("Boat #{0} from {1} has a {2} HP motor.",
license.LicenseNum, license.State,license.MotorSizeInHP);
Console.WriteLine(" The price for the license is {0}\n",license.Price.ToString("C2"));

}
static void Main()
{
const int STARTING_NUM = 201601;
BoatLicense[] license = new BoatLicense[3];
int x;
for(x = 0; x < license.Length; ++x){
license[x] = new BoatLicense();
license[x].LicenseNum = x+STARTING_NUM.ToString();
}
license[0].State = "WI";
license[1].State = "MI";
license[2].State = "MN";
license[0].MotorSizeInHP = 30;
license[1].MotorSizeInHP = 50;
license[2].MotorSizeInHP = 100;
for(x = 0; x < license.Length; ++x){
Display(license[x]);
}

}
}

