bool result = true;

Console.WriteLine("Enter IP Address for Validation:");
var input = Console.ReadLine();

if (input == null)
{
    result = false;
}

var strings = input.Split('.', StringSplitOptions.RemoveEmptyEntries);

if (strings.Length != 4)
{
    result = false;
}

foreach (var s in strings)
{
    if (s.Substring(0, 1) == "0" || Int32.Parse(s) > 255 || Int32.Parse(s) < 0)
    {
        result = false;
    }  
}

Console.WriteLine("Is IP Address Valid?");
Console.WriteLine(result);




