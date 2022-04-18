using PokemonModels;
using System.Collections.Generic;
using System.IO;
namespace PokemonDL
{
    public class Repository : IRepository
    {
        private string filePath = "../PokemonDL/Database";
        private string jsonString;

        public Pokemon addPokemon(Pokemon poke)
        {
            throw new NotImplementedException();
        }

        public void GetAllPokemon()
        {
            jsonString = File.ReadAllText(filePath+"Pokemon.json");
        }

        List<Pokemon> IRepository.GetAllPokemon()
        {
            throw new NotImplementedException();
        }
    }
}