using System.Runtime.InteropServices.Marshalling;

string? again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******* Převod do binarní soustavy *********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Filip Válek ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte desítkové číslo (přirozené): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[1] = zbytek;

        ConsoleWriteLine("Cela cast: {0}; Zbytek: {1}", number10, zbytek);

    }

    Console.WriteLine("Desistkove cislo {0} ve dvojkove soustave", backupNumber10);
    for (uint j = i - 1; j >= 0; j--)
    {
        ConsoleWriteLine("{0}", myArray[j]);
    }

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
