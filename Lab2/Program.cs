namespace Lab2;

class Program
{
    static void Main(string[] args)
    { //Part 1 - Assigning random variables
  int figure = 12; 
     Console.WriteLine(figure);
   double extension = 12.8764087457D;
     Console.WriteLine(extension);
   float digit = 12.8764F;
     Console.WriteLine(digit);
   bool statement = true; 
     Console.WriteLine("The weather is nice today" + statement);
   string message = "The weather is sunny tomorrow";
     Console.WriteLine(message);
   char letter = 'X';
     Console.WriteLine(letter); 

   //Part 2 - Creating casting statement          
      double cost = 7.53;
      int result = (int) cost;
      bool remark = false;
    Console.WriteLine(Convert.ToString(cost)); //int to string conversion
    Console.WriteLine(Convert.ToString(remark)); //bool to string conversion

   //Part 3 Name and age conversion with username Rosie
    Console.WriteLine("Rosie is"); 
    Console.WriteLine("45");
    string name = Console.ReadLine();
    int age = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine(name + age);

   //Part 4 - Performing operations part 2
    int num1 = 30;
    int num2 = 58;
    int y = num1 +num2;
    Console.WriteLine(y+ 10);
    Console.WriteLine(y - 2);
    Console.WriteLine(y * 3);
    Console.WriteLine(y / 2);
    Console.WriteLine(y % 2);

   //Part 5 - Float vs. Double results
   float num = 1.123456789F;
   Console.WriteLine(num);

   double value = 1.123456789D;
   Console.WriteLine(value);

  //Part 6 - Performing operations part 2
   int x = 10;
    x++;
    Console.WriteLine(x);

    int r = 10;
    r--; 
    Console.WriteLine(r);
 }
}
