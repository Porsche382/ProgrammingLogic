namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
    //Part 1 -Operators
    int a = 10;
    int b = 5; 
    int c = 15;
    Console.WriteLine(a > b);
    Console.WriteLine(a < c);
    Console.WriteLine(a > c && a > b);
    Console.WriteLine(a > b || a < c);

    //Part 2 -Booleans
    bool isRaining = true;
    if (isRaining) 
    {
        Console.WriteLine("Take an umbrella!");
    }

    bool haveUmbrella = false;
    if (haveUmbrella) 
    {
        Console.WriteLine("You're good to go!");
    }
    
    //Part 3 - Conditional Logic
    //User Rosie wants to watch a movie. Her age will dictate ticket price.
      int age = 45;
      if (age < 5)
      {
        Console.WriteLine(Convert.ToInt32(age));
        Console.WriteLine("Ticket is free!");
      } 
      else if (age < 12) 
      {
        Console.WriteLine("Child ticket:$5");
      } 
      else if (age > 38)
      {
        Console.WriteLine("Standard ticket:$10");
      }
      else if (age < 65)
      {
       Console.WriteLine("Senior ticket:$6");
      }
      else
      {
       Console.WriteLine("No movie!");
      }
     
     //Part 4 -Switch Program
      int day = 10;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
        case 8:
        default:
          Console.WriteLine("Invalid Day!");
          break;
      }    
    }
}
