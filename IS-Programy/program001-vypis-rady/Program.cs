string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("******* Výpis čiselné řady ********");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Filip Válek *************");
    Console.WriteLine("***********************************");
    Console.WriteLine();



    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první čislo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup do hodnoty programu, řešený lépe
    Console.WriteLine("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) ;
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte ho znovu");
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
