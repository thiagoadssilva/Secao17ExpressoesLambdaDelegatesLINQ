// Ultilizing the Linq

// Specify the data source
int[] numbers = new int[] { 1, 2, 3, 4, 5 };

// Define the query expression
var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

// Exwcute the query
foreach (int x in result)
{
    Console.WriteLine(x);
}