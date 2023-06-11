using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DMApp.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int RaceId { get; set; }
        [Required]
        public CharacterRace Race { get; set; } = new CharacterRace();
        [Required]
        public int ClassId { get; set; }
        [Required]
        public CharacterClass Class { get; set; } = new CharacterClass();

        public int? TokenId { get; set; }
        public CharacterToken? Token { get; set; }

        // Discord Server information
        [Required]
        public IList<DiscordGuild> Guilds { get; set; } = new List<DiscordGuild>();

        // Relationships & Organizations
        [Required]
        public IList<Character> Allies { get; set; } = new List<Character>();
        [Required]
        public IList<Character> Enemies { get; set; } = new List<Character>();
        [Required]
        public IList<Organization> Organizations { get; set; } = new List<Organization>();

        //Ability Scores
        [Required]
        public int AbilityScoreId { get; set; }
        [Required]
        public AbilityScore AbilityScores { get; set; } = new AbilityScore();

        //Skills
        [Required]
        public int? SkillSetId { get; set; }
        [Required]
        public SkillSet SkillsList { get; set; } = new SkillSet();

        //SavingThrows
        [Required]
        public int? SavingThrowsId { get; set; }
        [Required]
        public SavingThrows SavingThrows { get; set; } = new SavingThrows();

        // Background Information
        [Required]
        public int BackgroundInfoId { get; set; }
        [Required]
        public BackgroundInfo Background { get; set; } = new BackgroundInfo();

        // Levels & stats
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;
        public int ArmorClass { get; set; } = 10;
        public int CurrentHitPoints { get; set; } = 10;
        public int MaxHitPoints { get; set; } = 10;
        public int TemporaryHitPoints { get; set; } = 0;
        public int Speed { get; set; } = 15;
        public int ProficiencyBonus { get; set; } = 0;

        public IList<Feature> Features { get; set; } = new List<Feature>();
        public IList<Trait> Traits { get; set; } = new List<Trait>();

        public IList<Item> Items { get; set; } = new List<Item>();
        public IList<Spell> Spells { get; set; } = new List<Spell>();


        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
