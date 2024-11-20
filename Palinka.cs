
namespace Palesz
{
    internal class Palinka
    {
        public int Alkohol { get; set; }
        public string Gyumolcs { get; set; }
        public int Mennyiseg { get; set; }
        public int KeszitesEve { get; set; }
        public int Ar { get; set; }

        public Palinka(int alkohol, string gyumolcs, int mennyiseg, int keszitesEve, int ar)
        {
            Alkohol = alkohol;
            Gyumolcs = gyumolcs;
            Mennyiseg = mennyiseg;
            KeszitesEve = keszitesEve;
            Ar = ar;
        }

        public override string ToString()
        {
            return $"{Alkohol}% - {Gyumolcs} - Menny.:{Mennyiseg} - {KeszitesEve} - Ár:{Ar}";
        }
    }
}
