namespace HausaufgabenV05;

public abstract class Kleidungsstück
{
    
    public abstract string  Bezeichnung {get;}

    public Kleidungsstück(string bezeichnung){
        if(String.IsNullOrEmpty(bezeichnung) || String.IsNullOrWhiteSpace(bezeichnung)){
            throw new Exception("Kleidungsstück bezeichnung falsch");

        }
        
    }
    

}
