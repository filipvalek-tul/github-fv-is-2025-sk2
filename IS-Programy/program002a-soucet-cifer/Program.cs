string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Filip Válek ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit; //zbytek

    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10 //
        number = (number - digit) / 10;
        Console.WriteLine("Hodnota zbytku = {0}", digit)
        suma = suma + digit;
    }
    //
    Console.WriteLine