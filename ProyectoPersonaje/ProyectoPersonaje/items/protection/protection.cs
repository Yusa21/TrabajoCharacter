using ProyectoPersonaje.creatures.characters;
using ProyectoPersonaje.perks;

namespace ProyectoPersonaje.items.protection
{

    abstract class Protection : Item
    {
        public String name;
        public int armor;
        public List<Perk> _perks = new List<Perk>();

        public void Apply(Character character)
        {
        }
    }
}