using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    
     // [data-type] [identifier] [assignment Operator] [value]
     // Variable Declaration
        
        int age = 42;
        int favoriteNum = 100;
        
        float height = 6.25f;
        double weight = 200.45d;
        
        string firstName = "Gorge";
        string lastName = "Johnson";
        
        char middleInitial = 'M';
        char favoriteLetter = 'Z';
        
        bool alive = true;
        bool tired = false;
       
  
        Console.WriteLine(age);
        Console.WriteLine(favoriteNum);
      
        Console.WriteLine(height);
        Console.WriteLine(weight);
        
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        
        Console.WriteLine(middleInitial);
        Console.WriteLine(favoriteLetter);
      
        Console.WriteLine("Alive?: " + alive);
        Console.WriteLine("Tired?: " + tired);
        
    }
  }
}
