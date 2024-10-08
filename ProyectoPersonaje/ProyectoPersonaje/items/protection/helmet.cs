using ProyectoPersonaje.creatures.characters;
using ProyectoPersonaje.perks;

namespace ProyectoPersonaje.items.protection
{
    class Helmet : Protection
    {
        public String name;
        public int armor;

        public List<Perk> _perks = new List<Perk>();

        //Estadisticas por defecto del casco, se debe usar este creador siempre que se equipe    
        public Helmet()
        {
            this.name = "Helmet";
            this.armor = 10;
        }

        //No usar salvo excepciones
        public Helmet(String name, int armor)
        {
            this.name = name;
            this.armor = armor;
        }

        //Recibe un personaje y le equipa el casco
        public void Apply(Character character)
        {
            character._invetory.Add(new Helmet());
        }
    }
}