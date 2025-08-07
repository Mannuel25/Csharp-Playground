// See https://aka.ms/new-console-template for more information

//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.ForegroundColor = ConsoleColor.Black;


//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to C# Class!");

///* A multi-
// * line comment */

////string name, message;
//Console.WriteLine("What's your name?:");
//string name = Console.ReadLine();
//string message = "Hello " + name;
//Console.WriteLine(message);

//string number = "3";
//Console.WriteLine(Convert.ToInt32(number));
//int converted_number = int.Parse(number);
//Console.WriteLine("The converted number is : " +  converted_number);

//float area, base_, height;
//Console.WriteLine("Enter the base of the triangle:");
//base_ = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter the height of the triangle:");
//height = float.Parse(Console.ReadLine());
//area = (0.5f * (base_ * height));
//Console.WriteLine("The area of the triangle is " + Convert.ToString(area));

//Console.Write("Who are you?: ");
//string username = Console.ReadLine();
//Console.WriteLine("Hey " + username + "!");

//Console.WriteLine("Press any key to continue");
//Console.ReadKey(true);

//Console.Title = "New Coonsole";
//Console.Beep();

//Console.WriteLine("C\\Users\\Docs");
//Console.WriteLine(@"C\Users\Docs");
//var favorite_number = 8;
//Console.WriteLine($"My Favorite number is {favorite_number}");

//var first_name = "Joe";
//var last_name = "Jesse";
//// add whitespaces before the word..
//Console.WriteLine($"First Name: {first_name,10}");
//Console.WriteLine($"Last Name: {last_name,10}");
//// add whitespaces after the word..
//Console.WriteLine($"{first_name,-20} - 1");
//Console.WriteLine($"{last_name,-20} - 2");

//Console.WriteLine($"{Math.PI:0.00}"); // round to 2dp

//Console.WriteLine($"{42.0:0.00}");
//Console.WriteLine($"{42.9276378:002.00}");
//Console.WriteLine($"{42.9276378:0011.00}");
//Console.WriteLine($"{42.9276378:1.00}");
//Console.WriteLine($"{42.9276378:#.0000}");

//float currentHealth = 4;
//float maxHealth = 9;
//Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); // displays "44.4%" 

// conditional statements

//Console.WriteLine("Enter your score: ");
//var input = Console.ReadLine();
//int score = Convert.ToInt32(input);
//if (score <= 100 && score >= 70)
//{
//    Console.WriteLine("Your grade is A");
//}
//else if (score <= 69 && score >= 60)
//{
//    Console.WriteLine("Your grade is B");
//}
//else
//{
//    Console.WriteLine("Your grade is ZZ");
//}

//if (maxHealth != 9)
//{
//    Console.WriteLine("ZZZZ");
//}
//else if (maxHealth > 2 || maxHealth > 90)
//{
//    Console.WriteLine("YYYY");
//}

//// ternary operator
//string text = score > 70 ? "You've an A!" : "You didn't have an A :(";
//Console.WriteLine(text);

// switch-case

//var user_input = Console.ReadLine();
//var menu_number = Convert.ToInt32(user_input);
//switch (menu_number)
//{
//    case 1:
//        Console.WriteLine("Rope costs 10 gold");
//        break;
//    case 2:
//        Console.WriteLine("Torches cost 16 gold");
//        break;
//    default:
//        Console.WriteLine("Invalid selection");
//        break;
//}

//int number = 6;
//while (number >= 0){
//    Console.WriteLine(number);
//    number--;
//}

//do
//{
//    Console.WriteLine(number);
//    number--;
//}
//while (number >= 0);

//for (int i = 1; i <= 10; i++)
////for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//int[] scores = new int[11];
//scores[0] = 9;
//Console.WriteLine(scores[0]);

//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//    scores[i] = i;
//    Console.WriteLine(scores[i]);

//}
//foreach (int score in scores)
//{
//    Console.WriteLine("Score: " + score);
//}
// accessing last item
//Console.WriteLine(scores[^1]);

//int[] firstThreeScores = scores[0..3];
//Console.WriteLine(firstThreeScores);

//int[] nums = new int[3] { 1, 2, 3 };
//int[] nums = new int[] { 1, 2, 3 };
//int[] nums = new[] { 1, 2, 3 };

//List<int> new_scores = new List<int>();
//new_scores.Add(90);
//new_scores.Add(85);

//Console.WriteLine(new_scores);


// working with methods

//int GetNumber()
//{
//    Console.WriteLine("Enter a number: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    return number;

//}

//void CountNumber(int start, int end)
//{
//    //int number = Convert.ToInt32(Console.ReadLine());
//    for (int i=start; i <= end; i++)
//    {
//        Console.WriteLine(i);
//    }
//}

//CountNumber(20, 30);

//void MultiplicationTable()
//{ 
//    // get number from user
//    int number = GetNumber();

//    for (int i=0; i <= number; i++)
//    {
//        Console.WriteLine($"{number} * {i} = {number * i}");
//    }
//}


//MultiplicationTable();


//int DoubleAndAddOne(int value) => value * 2 + 1;

//int number = DoubleAndAddOne(45);
//Console.Write(number);


//int Factorial(int number)
//{
//    //int number = 5;
//    if (number == 0 || number == 1)
//    {
//        return 1;
//    }
//    return number * Factorial(number - 1);
//}

//int fact = Factorial(5);
//Console.Write(fact);

// Enumerations

using System;

enum Season { Winter, Spring, Summer, Fall } // 0, 1,2,3
enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
enum TrafficLight { Red, Yellow, Green }


class Program
{
    static void Main()
    {
        //Season current = Season.Summer;
        //Console.WriteLine((int)Season.Summer);  // Outputs 2
        //Console.WriteLine(current);
        //if (current == Season.Spring){
        //    Console.Write("It's Spring!");
        //}
        //else
        //{
        //    Console.Write("It's not Spring!");
        //}
        //Day weekday = Day.Thursday;
        //if (weekday == Day.Saturday || weekday == Day.Sunday)
        //{
        //    Console.WriteLine("It's the weekend!");
        //}
        //else
        //{
        //    Console.WriteLine("It's the weekday");
        //}
        TrafficLight color = TrafficLight.Green;
        switch (color)
        {
            case TrafficLight.Red:
                Console.WriteLine("Stop");
                break;
            case TrafficLight.Yellow:
                Console.WriteLine("Slow down");
                break;
            case TrafficLight.Green:
                Console.WriteLine("Go");
                break;
        }
    }
}

