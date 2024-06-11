// See https://aka.ms/new-console-template for more information

using EnumeratingInterfaces;

Console.WriteLine("Hello, World!");


var numbers = new List<int>{1, 2, 3};
//var numbers = new int[] { 1, 2, 3, 4, 5 };
//var numbers = new DecreasingNumbers(102);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}