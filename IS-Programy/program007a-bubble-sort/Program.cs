using System.Diagnostics;



string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čisel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Filip Válek ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte počet generovaných čisel(celé číslo) ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu A: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo) ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu ");
    }

    Console.Write("Zadejte horní mez (celé číslo) ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu ");
    }

    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čisel: {0},Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("********************************************");
    Console.WriteLine();

    //deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // připrava pro využití třidy Random
    Random myRandNumb = new Random(15);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0;
    int change = 0;

    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        //tento cyklus musi zajistit porovnavani dvou sousednich hodnot
        //musi dale zajistit abz se zmensoval poct porovnavanych hodnot
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] > myRandNumbs[j + 1])
            {
                int tpm = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }

    }
    myStopwatch.Stop();

    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("Serazene pole");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Pocet porovnani: {compare}");
    Console.WriteLine($"Pocet zmen: {change}");
    Console.WriteLine();
    Console.WriteLine("cas serazeni cisel pomoci BS: {0}", myStopwatch.Elapsed);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}