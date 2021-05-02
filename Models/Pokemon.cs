using System;
using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public Guid PokemonId { get; set; }
        public List<string> Abilities { get; set; }
        public Against Against { get; set; }
        public int Attack { get; set; }
        public int BaseEggSteps { get; set; }
        public int BaseHappiness { get; set; }
        public int BaseTotal { get; set; }
        public int CaptureRate { get; set; }
        public string Classification { get; set; }
        public int Defense { get; set; }
        public int ExperienceGrowth { get; set; }
        public float HeightM { get; set; }
        public int Hp { get; set; }
        public string JapaneseName { get; set; }
        public string Name { get; set; }
        public float PercentageMale { get; set; }
        public int PokedexNumber { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        public Type Type { get; set; }
        public float WeightKg { get; set; }
        public int Generation { get; set; }
        public bool IsLegendary { get; set; }
    }
}
