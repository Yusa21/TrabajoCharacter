namespace character;
class Axe : Weapon
{
    public string Name;
    public int Damage;

    //Estadisticas por defecto del hacha, se debe usar este creador siempre que se equipe  
    public Axe(){
        this.Name="Axe";
        this.Damage=10;
    }
    //No usar salvo excepciones
    public Axe(String name, int damage){
        this.Name=name;
        this.Damage=damage;
    }
    //Recibe un personaje y le equipa el escudo
    public void Apply(Character character){
        character._invetory.Add(new Axe());

    }
}