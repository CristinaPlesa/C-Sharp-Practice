// using System;

// class DoubleIt
// {
//   static void Main()
//   {
//     Console.WriteLine("Give me a number, and I will double it for you!");
//     string stringNumber = Console.ReadLine();  // <-- New code
//     int yourNumber = int.Parse(stringNumber);  // <-- New code
//     int yourDoubledNumber = yourNumber * 2;
//     string stringDoubledNumber = yourDoubledNumber.ToString();  // <-- New code
//     Console.WriteLine("I doubled your number for you: " + stringDoubledNumber);
//   }
// }
// class DoubleIt
// {
//   static void Main()
//   {
//     Console.WriteLine("How old are you?");
//     string stringUserAge = Console.ReadLine();
//     int intUserAge = int.Parse(stringUserAge);
    
//     if (intUserAge >= 17)
//       {
//         Console.WriteLine("You can see the movie!");
//       }
//       else
//       {
//         Console.WriteLine("I'm sorry, you are too young to see the movie.");
//     }
//   }
// }
//   static void Main()
//   {
//     Console.WriteLine("What is your name?");
//     string userName = Console.ReadLine();
//     if (userName.StartsWith("Z"))
//     {
//       Console.WriteLine("Your name starts with a Z!");
//     }
//     else
//     {
//       Console.WriteLine("Your name doesn't start with a Z :(");
//     }
//   }
// }

using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
//  same as (!summer && !weekend)
    else if (!(summer || weekend)) // triggers when neither is true
    {
      Console.WriteLine("Your stay might be expensive, but it could be worse!");
    }
    else // therefore this triggers when either is true
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
  }
}

// myDictionary {
//   {"A": "apple"};
//   {"B": "bear"}
// }

// myDictionary["A"];
// myDictionary.A;