using SLVP_Uge4_SimpelKlasse2;

List<Beer> beerList = new List<Beer>();

Boolean oneMore;
do
{
    Console.WriteLine("Indtast type øl: ");
    string beerType = Console.ReadLine();
    while (beerType == "")
    {
        Console.WriteLine("Du skal indtaste noget tekst. Prøv igen.");
        beerType = Console.ReadLine();
    }
    Console.WriteLine("Indtast et heltal for størrelse i cL: ");
    int beerSize;
    while (!int.TryParse(Console.ReadLine(), out beerSize) || beerSize < 0)
    {
        Console.WriteLine("Ugyldig værdi. Prøv igen.");
    }
    Console.WriteLine("Indtast et heltal for prisen i kr: ");
    int beerPrice;
    while (!int.TryParse(Console.ReadLine(), out beerPrice) || beerPrice < 0)
    {
        Console.WriteLine("Ugyldig værdi. Prøv igen.");
    }
    Console.WriteLine("Indeholder den alkohol? - Ja eller nej: ");
    Boolean beerAlcohol;
    string svar = Console.ReadLine();
    while (svar.ToLower() != "ja" && svar.ToLower() != "nej")
    {
        Console.WriteLine("Prøv igen - Ja eller nej:");
        svar = Console.ReadLine();
    }
    if (svar == "ja")
    {
        beerAlcohol = true;
    }
    else
    {
        beerAlcohol = false;
    }
    double beerProcent;
    if (beerAlcohol) 
    { 
        Console.WriteLine("Indtast dens procent: ");
        while (!double.TryParse(Console.ReadLine(), out beerProcent) || beerProcent < 0 || beerProcent > 100)
        {
            Console.WriteLine("Ugyldig værdi. Prøv igen.");
        }
    }
    else
    {
        beerProcent = 0;
    }
    Console.WriteLine("Skal du have mere? - Ja eller nej: ");
    svar = Console.ReadLine();
    while (svar.ToLower() != "ja" && svar.ToLower() != "nej")
    {
        Console.WriteLine("Prøv igen - Ja eller nej:");
        svar = Console.ReadLine();
    }
    if (svar == "ja")
    {
        oneMore = true;
    }
    else
    {
        oneMore = false;
    }
    Beer beer = new Beer(beerType, beerSize, beerPrice, beerAlcohol, beerProcent);
    if (beer is not null) beerList.Add(beer);
} while (oneMore);

foreach (Beer b in beerList)
{
    Console.Write(b.ToString());
    Console.WriteLine(" Prisen er: " + b.GetPrice() + "kr.");
}