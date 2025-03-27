namespace APBD_Cwiczenia_3;


class Kontener {
    public string nrSeryjny;
    public double maxPojemnosc;
    public double wagaLadunku;
    static int counter = 1;

    public Kontener(string typ, double maxPojemnosc) {
        this. maxPojemnosc = maxPojemnosc;
        nrSeryjny = "KON-" + typ + "-" + counter++;
        wagaLadunku = 0;
    }

    public virtual void zaladuj(double waga) {
        if (waga > maxPojemnosc) {
            throw new OverfillException("Za duży ładunek do kontenera " + nrSeryjny);
        }
        wagaLadunku = waga;
    }

    public virtual void wyladuj() {
        wagaLadunku = 0;
    }

    public virtual void PrintInfo() {
        Console.WriteLine(nrSeryjny + ": " + wagaLadunku + "/" + maxPojemnosc + " kg");
    }
}
