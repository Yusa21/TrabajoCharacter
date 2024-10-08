using ProyectoPersonaje.perks;

namespace ProyectoPersonaje.creatures
{
    public abstract class Creature
    {
        public String Name { get; set; }

        public int maxHitPoints { get; set; }
        public int baseDamage { get; set; }
        public int baseArmor { get; set; }
        public int currentHitPoints { get; set; }
        public List<Perk> _perks = new List<Perk>();


        public int Attack()
        {
            return 0;
        }

        public int Defense()
        {
            return 0;
        }

        public void Heal(int n)
        {
        }

        public void ReceiveDamage(int n)
        {
        }
    }
}