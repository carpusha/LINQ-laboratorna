char C = 'c';
string[] A = { "abc", "dea", "gha" };

try
{
    var result = A.Where(s => s.EndsWith(C)).SingleOrDefault();

    if (A.Count(s => s.EndsWith(C)) == 0)
    {
        Console.WriteLine("");
    }
    else if (A.Count(s => s.EndsWith(C)) == 1)
    {
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Error");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Виникла помилка" + ex.Message);
}

Console.ReadKey();