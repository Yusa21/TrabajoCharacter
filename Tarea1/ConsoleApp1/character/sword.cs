namespace character;

class Sword : Weapon
{
    public String name;
    public int damage;
    //Estadisticas por defecto de la espada, se debe usar este creador siempre que se equipe 
    public Sword()
    {
        this.name = "Sword";
        this.damage = 5;
    }
    //No usar salvo excepciones
    public Sword(String name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    //Recibe un personaje y le equipa el escudo
    public void Apply(Character character)
    {
        character._invetory.Add(new Sword());
    }
}