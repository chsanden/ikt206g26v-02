using UtilityLibraries;

int row = 0;

do
{
    if (row == 0 || row >= 25)
    {
        ResetConsole();
    }

    string? input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: {input.StartsWithUpper()}");
    Console.WriteLine();
    row += 3;
}
while (true);

return;

void ResetConsole()
{
    if (Console.IsOutputRedirected)
    {
        return;
    }

    Console.Clear();
    Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
    row = 3;
}
