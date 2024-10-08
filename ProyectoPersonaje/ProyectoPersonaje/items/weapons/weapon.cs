using ProyectoPersonaje.creatures.characters;
using ProyectoPersonaje.perks;

namespace ProyectoPersonaje.items.weapons
{
    abstract class Weapon : Item
    {
        public String name;
        public int damage;
        public List<Perk> _perks = new List<Perk>();

        public void Apply(Character character)
        {
        }
    }
}