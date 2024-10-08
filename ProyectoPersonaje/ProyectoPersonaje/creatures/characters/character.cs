using ProyectoPersonaje.items;
using ProyectoPersonaje.items.protection;
using ProyectoPersonaje.items.weapons;
using ProyectoPersonaje.perks;

namespace ProyectoPersonaje.creatures.characters
{
   class Character: Creature
  {
    public String name { get; set; }
    
    public int maxHitPoints { get; set; }
    public int baseDamage { get; set; }
    public int baseArmor { get; set; }
    public int currentHitPoints {get; set;}
    public List<Item> _invetory = new List<Item>();
    public List<Perk> _perks = new List<Perk>();

    Character(String Name, int MaxHitPoints, int BaseDamage, int BaseArmor){
      this.name=Name;
      this.maxHitPoints=MaxHitPoints;
      this.currentHitPoints=MaxHitPoints;
      this.baseDamage=BaseDamage;
      this.baseArmor=BaseArmor;
    }
    
    Character(){
      this.name="Default";
      this.maxHitPoints=1;
      this.currentHitPoints=1;
      this.baseDamage=1;
      this.baseArmor=0;
    }
    //Calcula y devuelve el daño total del ataque
    public int Attack(){
      int totaldmg=this.baseDamage;
      foreach(Weapon w in _invetory){
        totaldmg =+ w.damage;
      }

      return totaldmg;

    }
    //Calcula la defensa del personaje
    public int Defense(){
      int totalarm=this.baseArmor;
      foreach(Protection w in _invetory){
        totalarm =+ w.armor;
      }

      return totalarm;

    }
    //Recive la cantidad a curar y la suma a la vida actual
    public void Heal(int n){
      this.currentHitPoints=+n;
      if (this.currentHitPoints > maxHitPoints)
      {
        currentHitPoints = maxHitPoints;
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
      if (currentHitPoints < 0)
      {
        currentHitPoints=0;
      }

    }
  }
}
