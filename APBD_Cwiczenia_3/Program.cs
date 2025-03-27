namespace APBD_Cwiczenia_3;

class Program {
    static void Main() {
        //Dodawanie obiektów i testowanie działania kodu
        var mleko = new KontenerNaPlyny(1000, false);
        mleko.zaladuj(800);
        
        var hel = new KontenerNaGaz(500, 10);
        hel.zaladuj(400);
        
        var banany = new KontenerChłodniczy(800, "banany", 5);
        banany.zaladuj(700);
        
        var statek = new Statek("Kontenerowiec", 10, 50); 
        statek.AddContainer(mleko);
        statek.AddContainer(hel);
        statek.AddContainer(banany);
        statek.PrintInfo();
    }
}