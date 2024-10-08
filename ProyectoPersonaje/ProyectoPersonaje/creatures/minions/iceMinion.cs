namespace ProyectoPersonaje.creatures.minions;

public class IceMinion: Minion
{
    public String name { get; set; }
    
    public int maxHitPoints { get; set; }
    public int baseDamage { get; set; }
    public int baseArmor { get; set; }
    public int currentHitPoints {get; set;}
    //public List<Perk> _perks = new List<Perk>();

    public IceMinion(){
        this.name="Minion de hielo";
        this.maxHitPoints=10;
        this.currentHitPoints=10;
        this.baseDamage=2;
        this.baseArmor=0;
    }
    //Calcula y devuelve el daño total del ataque
    public int Attack(){
        int totaldmg=this.baseDamage;
        return totaldmg;

    }
    //Calcula la defensa del personaje
    public int Defense(){
        int totalarm=this.baseArmor;
        return totalarm;

    }
    //Recive la cantidad a curar y la suma a la vida actual
    public void Heal(int n){
        this.currentHitPoints=+n;
        if (this.currentHitPoints > this.maxHitPoints)
        {
            currentHitPoints = this.maxHitPoints;
        }
    }
    //Recive el daño, le resta la defesa y le resta la vida
    public void ReceiveDamage(int n){
        n=-Defense();
        if (n < 0)
        {
            n = 0;
        }
        this.currentHitPoints=-n;
        if (this.currentHitPoints < 0)
        {
            this.currentHitPoints=0;
        }

    }
    
}