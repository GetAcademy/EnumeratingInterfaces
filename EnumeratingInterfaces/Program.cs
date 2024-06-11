using EnumeratingInterfaces;

var text = "Terje";
//var newText = StringExtensions.Repeat(text, 5);
var newText = text.Repeat(5);

// text.Repeat(5)
Console.WriteLine(newText);

var text2 = new Drawing(10, 10)
    .AddStar(1, 5)
    .AddStar(2, 5)
    .AddT(5, 1)
    .AddT(5, 2)
    .Build();
Console.WriteLine(text2);

//var drawing = new Drawing(10, 10);
//drawing.AddStar(1,5);
//drawing.AddStar(2,5);
//drawing.AddT(5, 1);
//drawing.AddT(5, 2);

var result = new DecreasingNumbers(10000)
        .Where(n => n % 2 == 0)
        .Select(n => $"<li>{n}</li>")
        .OrderBy(n => n)
        .Skip(2)
        .Take(2)
        .ToList();

/* 
 * JavaScript  LINQ           SQL
 *  - filter    - Where        - Where
 *  - map       - Select       - Select
 *  - find      - First        - Where
 *                FirstOrDefault
 *                Single
 *                SingleOrDefault
 *
 *              - .ToArray()
 *              - .ToList()
 *
 * Kjede sammen filtere, mappe, sortere, skippe, ToArray eller ToList
 */

/*

Eksempel 6: kjede sammen

var result =
   new DecreasingNumbers(10000)
   .Where(n => n % 2 == 0)
   .Select(n => $"<li>{n}</li>")
   .OrderBy(n => n)
   .Skip(2)
   .Take(2)
   .ToList();
   
   foreach (var text in result)
   {
   Console.WriteLine(text);
   }

Eksempel 5: Mappe uten LINQ

var dots = numbers.Select(number => new string('*', number) + " (" + number + ")");

Eksempel 4: Mappe uten LINQ

var dots = new List<string>();
foreach (var number in numbers)
{
   dots.Add(new string('*', number) + " (" + number + ")");
}

Eksempel 3: Filtrere ut partall med LINQ

var evenNumbers = numbers.Where(n => n % 2 == 0);

Eksempel 2: Filtrere ut partall uten LINQ

var evenNumbers = new List<int>();
foreach (var number in numbers)
{
   if (number % 2 == 0)
   {
       evenNumbers.Add(number);
   }
}

Eksempel 1: bruke foreach på noe annet enn array og List 
  - en klasse som implementerer IEnumerable og IEnumerator

var numbers = new DecreasingNumbers(102);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
*/