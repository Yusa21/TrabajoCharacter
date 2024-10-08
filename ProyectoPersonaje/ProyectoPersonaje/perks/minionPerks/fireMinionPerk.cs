using ProyectoPersonaje.creatures;
using ProyectoPersonaje.creatures.minions;
using ProyectoPersonaje.perks.minionPerks;

namespace ProyectoPersonaje.minionPerks
{

    public class FireMinionPerk : MinionPerk
    {
        public String name;
        public List<Minion> _minions = new List<Minion>();

        public FireMinionPerk()
        {
            name = "Llamada de fuego";
            _minions.Add(new FireMinion());
        }

        public void Apply(Creature creature)
        {
            creature._perks.Add(new FireMinionPerk());
        }
    }
}