namespace APBD_Cwiczenia_3;

class Statek {
    public string nazwa;
    public int maxKontenery;
    public double maxWaga; 
    public List<Kontener> kontenery = new List<Kontener>();

    public Statek(string nazwa, int maxKontenery, double maxWaga) {
        this.nazwa = nazwa;
        this.maxKontenery = maxKontenery;
        this.maxWaga = maxWaga;
    }

    public void AddContainer(Kontener c) {
        if (kontenery.Count >= maxKontenery) {
            Console.WriteLine("Za dużo kontenerów na statku");
            return;
        }

        double wagaTotal = 0;
        foreach (var kont in kontenery) {
            wagaTotal += kont.wagaLadunku;
        }

        if (wagaTotal + c.wagaLadunku > maxWaga * 1000) {
            Console.WriteLine("Przekroczona maksymalna waga statku");
            return;
        }

        kontenery.Add(c);
    }

    public void PrintInfo() {
        Console.WriteLine("Statek: " + nazwa);
        foreach (var c in kontenery) {
            c.PrintInfo();
        }
    }
}
