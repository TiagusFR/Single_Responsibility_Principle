namespace Single_Responsibility_Principle
{
    internal class PokeBank : IPokeBank
    {
        public int PokemonId { get; set; }
        public string PokemonName { get; set; }
    }
}