using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Lab6;

class Car 
{
  public void Start() //Problem 1: Calling a method without parameters
    {
        Console.WriteLine("The car is starting.");
    }
  public void Drive(int miles) //Problem 2: Calling a method with one parameter
    {
       Console.WriteLine("The car drove " + miles + " miles ");
    }
  public string GetDiscription() //Problem 3: Returning values
    {
      return$"{year}{color}{model}";
    }

  public void Repaint(string color) //Problem 4: Updating fields
     {
      Console.WriteLine("The car has been repainted to" + " " + color);
     }
  public string model;
  public string color;
  public int year;
}
    class Program
{
  static void Main()
  {
    Car myCar = new Car();
        myCar.Start();
        myCar.Drive(50);
        myCar.Repaint("red" +  myCar.color);
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;
   string vehicle = myCar.GetDiscription(); 
   Console.WriteLine(vehicle + "  ");  
 }
}