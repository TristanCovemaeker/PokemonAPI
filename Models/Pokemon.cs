using System;
using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public Guid Id { get; set; }
        public float AgainstBug { get; set; }
        public float AgainstDark { get; set; }
        public float AgainstDragon { get; set; }
        public float AgainstElectric { get; set; }
        public float AgainstFairy { get; set; }
        public float AgainstFight { get; set; }
        public float AgainstFire { get; set; }
        public float AgainstFlying { get; set; }
        public float AgainstGhost { get; set; }
        public float AgainstGrass { get; set; }
        public float AgainstGround { get; set; }
        public float AgainstIce { get; set; }
        public float AgainstNormal { get; set; }
        public float AgainstPoison { get; set; }
        public float AgainstPsychic { get; set; }
        public float AgainstRock { get; set; }
        public float AgainstSteel { get; set; }
        public float AgainstWater { get; set; }
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
        public float WeightKg { get; set; }
        public int Generation { get; set; }
        public bool IsLegendary { get; set; }
        
        public Guid PokeTypeId { get; set; }
        public PokeType PokeType { get; set; }
    }
}
