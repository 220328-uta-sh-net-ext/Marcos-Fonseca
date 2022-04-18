using PokemonDL;

namespace PokemonUI
{
    internal class PokemonOperations
    {
        Repository repository= new Repository();

        public void GetAllPokemons() {
            repository.GetAllPokemons();
    }
        public static void AddDummyPokemon()
        {
            PokemonDL pokemon1 = new Pokemon();    
        }
}
