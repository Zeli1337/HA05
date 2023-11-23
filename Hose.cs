namespace HausaufgabenV05;

public class Hose : Kleidungsstück
{
    private string _bezeichnung;
    public override string Bezeichnung { 
        get => _bezeichnung;
        
    }
    public Hose(string bez):base(bez){
        _bezeichnung = string.IsNullOrEmpty(bez) || String.IsNullOrWhiteSpace(bez) ? throw new Exception("Bezeichnung falsch") : bez;
    }

    public override string ToString()
    {
        return $"{Bezeichnung}";
    }

    public override int GetHashCode()
    {
        return _bezeichnung.GetHashCode();
    }

    public override bool Equals(object obj){
        if(obj == null)
            throw new Exception("Objekt ist null");
        if(obj.GetHashCode() == GetHashCode()){
            return true;
        }
        return false;
    }
}
