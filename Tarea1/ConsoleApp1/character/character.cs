using System;
using System.Runtime.CompilerServices;

namespace character
{
   class Character
  {
    public String Name { get; set; }
    
    public int MaxHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    public int CurrentHitPoints {get; set;}
    public List<Item> _invetory = new List<Item>();
    //public List<Perk> _perks = new List<Perk>();

    Character(String Name, int MaxHitPoints, int BaseDamage, int BaseArmor){
      this.Name=Name;
      this.MaxHitPoints=MaxHitPoints;
      this.CurrentHitPoints=MaxHitPoints;
      this.BaseDamage=BaseDamage;
      this.BaseArmor=BaseArmor;
    }

    Character(){
      this.Name="Default";
      this.MaxHitPoints=1;
      this.CurrentHitPoints=1;
      this.BaseDamage=1;
      this.BaseArmor=0;
    }
    //Calcula y devuelve el daño total del ataque
    public int Attack(){
      int totaldmg=this.BaseDamage;
      foreach(Weapon w in _invetory){
        totaldmg =+ w.damage;
      }

      return totaldmg;

    }
    //Calcula la defensa del personaje
    public int Defense(){
      int totalarm=this.BaseArmor;
      foreach(Protection w in _invetory){
        totalarm =+ w.armor;
      }

      return totalarm;

    }
    //Recive la cantidad a curar y la suma a la vida actual
    public void Heal(int n){
      this.CurrentHitPoints=+n;
      if (this.CurrentHitPoints > MaxHitPoints)
      {
        CurrentHitPoints = MaxHitPoints;
      }
    }
    //Recive el daño, le resta la defesa y le resta la vida
    public void ReceiveDamage(int n){
      n=-Defense();
      if (n < 0)
      {
        n = 0;
      }
      this.CurrentHitPoints=-n;
      if (CurrentHitPoints < 0)
      {
        CurrentHitPoints=0;
      }

    }
  }
}
