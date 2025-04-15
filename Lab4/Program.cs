namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
      //Problem 1: Output of 1 to 10 on a new line 
      for (int y = 1; y <= 10; y++) 
      {
        Console.WriteLine(y); 
      } 

      //Problem 2 
       for (int f= 1; f<= 20; f++) //interval of 1 to 20
        {
            if (f% 2 == 0) // modulus operator to output even numbers only
            {
                Console.WriteLine(f); 
            }
        }
      
      //Problem 3 : interval of 1 to 5 in descending order in a loop
      int i = 5; // interval of 1 to 5
      while (i > 0) 
      {
        Console.WriteLine(i); 
        i--;
      }
     
     //Problem 4 : user input for a range of values 
     //Requesting from user to input a value that is greater than 100 in a loop. 
     int num;
      do
      {
        Console.WriteLine("Enter value greater than 100"); //request for user input
        num = int.Parse(Console.ReadLine()); //converts to numerical value
        if (num <= 50 || num >= 120) // set condition
        {
          Console.WriteLine("Error"); //output if condition is not met
        }
      } while (num < 50 || num > 120); //condition loop
      Console.WriteLine("Valid Entry"); //output if condition is met
      
      //Problem 5 : using while loop to output multiples of 10 
      int x = 10;
      while (x <= 1000) 
      {
        Console.WriteLine(x);
        x+=10;
      }
      
      //Problem 6 : triangle formation 
      for(int t=1; t<=10; t++)  //Outer loop that creates rows
      {
       for(int s=1; s<=t; s++) //Inner loop that controls asterisks after setting to t value 
        {
         Console.Write("*");  
        }
       Console.WriteLine();
      } 
    } 
  }
