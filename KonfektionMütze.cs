namespace HausaufgabenV05;

public class KonfektionsMütze : Mütze, IKonfektioniert
{

   public string Konfektionsgröße { get; }

    public KonfektionsMütze(string bez, string konfg):base(bez){
        if(String.IsNullOrEmpty(konfg)  || String.IsNullOrWhiteSpace(konfg))
            throw new Exception("Falsche Werte für Konf");
        
        Konfektionsgröße = konfg;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Konfektionsgröße}";
    }

    public override int GetHashCode()
    {
        return Konfektionsgröße.GetHashCode() + Bezeichnung.GetHashCode();
    }
    public override bool Equals(object obj){
        if(obj.GetHashCode() == GetHashCode()){
            return true;
        }
        return false;
    }

}
