// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to C# Class!");

/* A multi-
 * line comment */

//string name, message;
Console.WriteLine("What's your name?:");
string name = Console.ReadLine();
string message = "Hello " + name;
Console.WriteLine(message);

string number = "3";
Console.WriteLine(Convert.ToInt32(number));
int converted_number = int.Parse(number);
Console.WriteLine("The converted number is : " +  converted_number);
