using ProyectoPersonaje.creatures;
using ProyectoPersonaje.creatures.minions;

namespace ProyectoPersonaje.perks.minionPerks
{

    public class MinionPerk : Perk
    {
        public String name { get; set; }
        public List<Minion> _minions = new List<Minion>();

        public void Apply(Creature creature)
        {
        }
    }
}