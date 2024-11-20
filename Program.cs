using Palesz;

List<Palinka> palinkak = new();
string[] gyumolcsok = { "alma", "korte", "szilva", "barack", "cseresznye", "meggy", "dio", "eper", "ribizli", "citrom" };

for (int i = 0; i < 20; i++)
{
    palinkak.Add(new Palinka(
        alkohol: Random.Shared.Next(30, 87),
        gyumolcs: gyumolcsok[Random.Shared.Next(gyumolcsok.Length)],
        mennyiseg: Random.Shared.Next(0, 50),
        keszitesEve: Random.Shared.Next(2000, DateTime.Now.Year),
        ar: Random.Shared.Next(50, 1000)
        ));
}

foreach (var palinka in palinkak)
{
    Console.WriteLine(palinka);
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{palinkak.Sum(p => p.Mennyiseg) / 10} liter pálinkánk van");

int profit = 0;
for (int i = 0; i < 50; i++)
{
    Palinka neo = palinkak[Random.Shared.Next(palinkak.Count)];
    profit += (neo.Mennyiseg / 2) * neo.Ar;
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(profit + " Ft a profit");
Console.ResetColor();