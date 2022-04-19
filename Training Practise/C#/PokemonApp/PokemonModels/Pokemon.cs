namespace PokemonModels
{
    public class Pokemon
    {
        public string Name { get; set; }

        public int Level { get; set; }  

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int health { get; set; }

        //Abilities -> Name, Power, Accuracy
        private List<Ability> _abilities;

        public List<Ability> Abilities { 
            get { return _abilities; }
            //cannot have more than 4 abilities
            set
            {
                if (value.Count < 4)
                    _abilities = value;
                else
                    throw new Exception("Pokemon cannot hold more than 4 abilities");
            }
        }

        //Default Constructor to add default values to the properties
        public Pokemon()
        {
            Name = "Ditto";
            Level = 1;
            Attack = 55;
            Defense = 55;
            health = 55;
            _abilities = new List<Ability>();
            {
                new Ability();
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Level}\nAttack: {Attack}\nDefense: {Defense}\nHealth: {health}";
        }

    }
}