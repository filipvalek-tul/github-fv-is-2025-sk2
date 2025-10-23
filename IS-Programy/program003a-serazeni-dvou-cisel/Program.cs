using System.Runtime.InteropServices.Marshalling;

string? again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Seřazení dvou čisel *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Filip Válek ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu A: ");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu B: ");
    }

    Console.WriteLine();

    int pom;
    //Chceme seradit cisla vzestupne
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
    }

    Console.WriteLine("********************************************");
    Console.WriteLine($"Seřazená čisla: {a}, {b}");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}