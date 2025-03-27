namespace APBD_Cwiczenia_3;


class KontenerNaGaz : Kontener {
    public double cisnienie;
    public KontenerNaGaz(double maxPojemnosc, double cisnienie) : base("G", maxPojemnosc) {
        this.cisnienie = cisnienie;
    }

    public override void wyladuj() {
        wagaLadunku = wagaLadunku * 0.05; 
    }
}