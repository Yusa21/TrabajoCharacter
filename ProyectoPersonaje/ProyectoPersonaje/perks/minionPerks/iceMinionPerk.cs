using ProyectoPersonaje.creatures;
using ProyectoPersonaje.creatures.minions;
using ProyectoPersonaje.perks.minionPerks;

namespace ProyectoPersonaje.minionPerks{

public class IceMinionPerk: MinionPerk
{
    public String name;
    public List<Minion> _minions = new List<Minion>();
        
    public IceMinionPerk()
    {   
        name = "Llamada de hielo";
        _minions.Add(new IceMinion());
    }
    
    public void Apply(Creature creature)
    {
        creature._perks.Add(new IceMinionPerk());
    }
}
}