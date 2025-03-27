namespace APBD_Cwiczenia_3;


class KontenerNaPlyny : Kontener {
    public bool czyNiebezpieczny;
    public KontenerNaPlyny(double maxPojemnosc, bool czyNiebezpieczny) : base("L", maxPojemnosc) {
        this.czyNiebezpieczny = czyNiebezpieczny;
    }

    public override void zaladuj(double waga) {
        double limit;
        if (czyNiebezpieczny) {
            limit = maxPojemnosc * 0.5;
        }
        else {
            limit = maxPojemnosc * 0.9;
        }

        if (waga > limit) {
            Console.WriteLine("Niebezpieczne załadowanie kontenera " + nrSeryjny);
            return;
        }
        wagaLadunku = waga;
    }
}
