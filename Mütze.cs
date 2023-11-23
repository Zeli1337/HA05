namespace HausaufgabenV05;

public class Mütze : Kleidungsstück
{
    private string _bezeichnung;
    public override string Bezeichnung { 
        get => _bezeichnung;
    }
        
    public Mütze(string bez):base(bez){
         _bezeichnung= bez;
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
