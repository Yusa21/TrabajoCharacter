namespace ProyectoPersonaje.creatures.minions
{
  public abstract class Minion: Creature
  {
    public String name { get; set; }
    
    public int maxHitPoints { get; set; }
    public int baseDamage { get; set; }
    public int baseArmor { get; set; }
    public int currentHitPoints {get; set;}
    //public List<Perk> _perks = new List<Perk>();
  }
}
