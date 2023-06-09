// See https://aka.ms/new-console-template for more information
//2.Accept length and breadth of a rectangle and find perimeter.

Console.WriteLine("enter the length and breadth of a rectangle");

int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the length of a rectangle");

int breadth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the breadth of a rectangle");

int P = 2 * (length * breadth);

Console.WriteLine(P);