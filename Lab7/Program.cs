namespace Lab7;
class Book
{ //Problem 1 Constructor without Parameters
  private string title;
  public Book()
  {
    title = "Unknown title"; 
  }

  public string GetTitle()
  {
    return this.title;
  }
  
  public void SetTitle(string newTitle)
  {
    this.title = newTitle;
  }
  // End Problem 1 ---------------------------------

  //Problem 2 Constructor with parameters
  
  public Book(string title)
  {
    this.title = title;
  }

  //End Problem 2 -----------------------------------

  //Problem 3 Constructor Overloading
  private string author;
  public Book(string title, string author)
  {
    this.title = title;
    this.author = author;
  }

  public string GetAuthor()
  {
    return this.author;
  }
  
  public void SetAuthor(string newAuthor)
  {
    this.author = newAuthor;
  }

  //End Problem 3 ---------------------------------

  static void Main(string[] args)
  {
    //Problem 1 Output 
    Book novel = new Book(); 
    Console.WriteLine(novel.title);  
    
    novel.SetTitle("C# Fundamentals");
    Console.WriteLine(novel.GetTitle());

    //Problem 2 Output
    Book book2 = new Book("Advanced C#");
    Console.WriteLine(book2.GetTitle());

    //Problem 3 Output
    Book book3 = new Book();
    book3.SetTitle("Advanced C#");
    book3.SetAuthor("John Doe");
    Console.WriteLine("Title:" + book3.GetTitle());
    Console.WriteLine("Author:" + book3.GetAuthor());

    //Problem 4 ??
    Book book4 = new Book();
    book4.SetTitle("Mastering C#");
    Console.WriteLine("Title:" + book4.GetTitle());
    
    book4.SetAuthor("Jane Smith");
    Console.WriteLine("Author:" + book4.GetAuthor());

  }
}


