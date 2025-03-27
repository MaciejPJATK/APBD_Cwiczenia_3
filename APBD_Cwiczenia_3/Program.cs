namespace APBD_Cwiczenia_3;

class Program {
    static void Main() {
        try {
            var mleko = new KontenerNaPlyny(1000, false);
            mleko.zaladuj(800);

            var hel = new KontenerNaGaz(500, 10);
            hel.zaladuj(400);

            var banany = new KontenerChłodniczy(800, "banany", 5);
            banany.zaladuj(700);
            
            // var banany1 = new KontenerChłodniczy(100000, "banany", 5); testowe sprawdzenie Exception
            // banany.zaladuj(70000);

            var statek = new Statek("Kontenerowiec", 10, 50);
            statek.AddContainer(mleko);
            statek.AddContainer(hel);
            statek.AddContainer(banany);
            statek.PrintInfo();
        }
        catch (OverfillException exception) {
            Console.WriteLine("Błąd załadunku: " + exception.Message);
        }
    }

}