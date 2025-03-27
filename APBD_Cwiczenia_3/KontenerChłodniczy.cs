namespace APBD_Cwiczenia_3;


class KontenerChłodniczy : Kontener {
    public string rodzajProduktu;
    public double temperatura;

    public KontenerChłodniczy(double maxPojemnosc, string rodzajProduktu, double temperatura) : base("C", maxPojemnosc) {
        this.rodzajProduktu = rodzajProduktu; 
        this.temperatura = temperatura;
    }
}
