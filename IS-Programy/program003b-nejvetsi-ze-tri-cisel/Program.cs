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

    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu C: ");
    }

    Console.WriteLine();

    int pom;
    //Chceme seradit cisla vzestupne
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší čislo je A = {a}");
        else
            Console.WriteLine($"Největší čislo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší čislo je B = {b}");
        else
            Console.WriteLine($"Největší čislo je C = {c}");
    }

    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
