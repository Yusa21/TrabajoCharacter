namespace character;
class Shield : Protection 
{
    public String name;
    public int armor;
    //Estadisticas por defecto del escudo, se debe usar este creador siempre que se equipe 
     public Shield(){
        this.name="Shield";
        this.armor=5;
    }
    //No usar salvo excepciones
    public Shield(String name, int armor){
        this.name=name;
        this.armor=armor;
    }
    //Recibe un personaje y le equipa el escudo
    public void Apply(Character character){
        character._invetory.Add(new Shield());
    }
}