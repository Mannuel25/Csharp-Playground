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

var first_name = "Joe";
var last_name = "Jesse";
// add whitespaces before the word..
Console.WriteLine($"First Name: {first_name,10}");
Console.WriteLine($"Last Name: {last_name,10}");
// add whitespaces after the word..
Console.WriteLine($"{first_name,-20} - 1");
Console.WriteLine($"{last_name,-20} - 2");

Console.WriteLine($"{Math.PI:0.00}"); // round to 2dp

Console.WriteLine($"{42.0:0.00}");
Console.WriteLine($"{42.9276378:002.00}");
Console.WriteLine($"{42.9276378:0011.00}");
Console.WriteLine($"{42.9276378:1.00}");
Console.WriteLine($"{42.9276378:#.0000}");

float currentHealth = 4;
float maxHealth = 9;
Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); // displays "44.4%" 
