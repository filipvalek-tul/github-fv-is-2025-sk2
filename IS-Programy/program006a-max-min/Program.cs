using System.Runtime.InteropServices.Marshalling;

string? again = "a";

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
    Console.WriteLine("Nahodna cisla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    // hledání maxima, pozice maxima, minima, pozice minima
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;

        }

        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    if (max >= 3)
    {

        Console.WriteLine();
        Console.WriteLine("********************************************");
        Console.WriteLine();
        Console.WriteLine($"Presypaci hodiny o velikost {max}:");
        Console.WriteLine();

        for (int i = 0; i < max; i++) ;
        {
            int spaces, stars;

            if (i < max / 2)
            {
                spaces = i;
                stars = max - 2 * i;
            }
            else
            {
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    stars = 2 * (i - max / 2) + 1;
                }

            }
            Console.ForegroundColor = ConsoleColor
            for (int sp = 0; sp < spaces; sp++) ;
            Console.Write(" ");

            for (int st = 0; st < stars; st++) ;
            Console.Write("*");

            Console.WriteLine();

        }


    }
    else
    {
        Console.WriteLine("Maximum je mensi nez 3 => obrazec se nebude vykreslovat!!!");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
