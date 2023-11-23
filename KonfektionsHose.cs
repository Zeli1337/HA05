namespace HausaufgabenV05;

public class KonfektionsHose : Hose, IKonfektioniert
{
    public string Konfektionsgröße { get;}

    public KonfektionsHose(string bez, string konfg):base(bez){
        if(String.IsNullOrEmpty(konfg)  || String.IsNullOrWhiteSpace(konfg))
            throw new Exception("Falsche Werte für Konf");
        Konfektionsgröße = konfg;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Maße {Konfektionsgröße}";
    }

    public override int GetHashCode()
    {
        return Konfektionsgröße.GetHashCode() + this.Bezeichnung.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if(obj == null)
            throw new Exception("Objekt ist null");
        if(obj.GetHashCode() == GetHashCode()){
            return true;
        }
        return false;
    }
}
