namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
    //Problem 1
    //Using foreach with seasons string array
    string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
    foreach (string i in seasons) 
      {
        Console.WriteLine(i);
      }  
    
    //Problem 2
    //User input of weekdays using a string array
    string[] days =  {"Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday"};
    int weekday;
 
     // User input weekday number
     Console.Write("Enter weekday number (1-7):");
     weekday = Convert.ToInt32(Console.ReadLine()); 
     switch (weekday) 
      {
        case 1:
          Console.WriteLine("Today is Monday");
          break;
        case 2:
          Console.WriteLine("Today is Tuesday");
          break;
        case 3:
          Console.WriteLine("Today is Wednesday");
          break;
        case 4:
          Console.WriteLine("Today is Thursday");
          break;
        case 5:
          Console.WriteLine("Today is Friday");
          break;
        case 6:
          Console.WriteLine("Today is Saturday");
          break;
        case 7:
          Console.WriteLine("Today is Sunday");
          break;
        case 8:
        default:
          Console.WriteLine("Invalid day!");
          break;
      }    


    //Problem 3: Books with corresponding authors using for loop with 2 strings
      string[] book = new string[3];
        book[0] = "Dracula";
        book[1] = "The Vampire Chronicles";
        book[2] = "Carrie";

        string[] author = new string[3];
        author[0] = "Bram Stroker";
        author[1] = "Anne Rice";
        author[2] = "Stephen King";
     
     for (int i = 0; i < 3; i++) 
     {Console.WriteLine("Book " + (i+1) + ": " + book[i] + " by " + author[i]);}

    //Problem 4-1
    // Sort a set of given temperatures in ascending order
      int[] temperatures = {65, 72, 78, 70, 68};
      Array.Sort(temperatures);
      foreach (int i in temperatures)
      {
        Console.WriteLine(i);
      }
    
    //Problem 4-2 
    //Determining max & min values of temperature set
    {
      int[] temperature = {65, 72, 78, 70, 68 };
      Console.WriteLine("Highest temp:" + temperature.Max());  // largest value
      Console.WriteLine("Lowest temp:" + temperature.Min());  // smallest value
    }

    //Problem 5 
    //Sort a number set into descending order and reversing it. 
    int[] countdown = { 5, 4, 3, 2, 1 };
    Array.Reverse(countdown);
    for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }  
    }
}
