
List<string> cities = new List<string>();
        bool t = false;
int i = 0;
while (true)
{
    Console.Write("Skriv in en stad eller skriv 'exit' för att stänga ner programmet\n");
    string pepe = Console.ReadLine();

    if (pepe.ToLower() == "exit")
    {
        break;
    }
    else
    {
        cities.Add(pepe);
    }

    Console.WriteLine("Tillagda stad:");
    Console.WriteLine("-------------------");
    Console.WriteLine(cities.Last());
    Console.WriteLine("-------------------");
i++;
Console.WriteLine(cities.Count());
}
Console.ReadLine();
int nrcity = cities.Count();
for(int k = 0; k<nrcity; k++){
Console.WriteLine(cities[k]);
}
Console.ReadLine();