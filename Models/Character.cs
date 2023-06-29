using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DMApp.Models
{
    public class Character
    {
        public Character()
        {
            Guilds = new List<DiscordGuild>();
            Allies = new List<Character>();
            Enemies = new List<Character>();
            Organizations = new List<Organization>();

            Features = new List<Feature>();
            Traits = new List<Trait>();
            Items = new List<Item>();
            Spells = new List<Spell>();

            // ability scores
            Strength = 10;
            Dexterity = 10;
            Constitution = 10;
            Intelligence = 10;
            Wisdom = 10;
            Charisma = 10;

            // Skills
            Acrobatics = 0;
            IsAcrobaticsProficient = false;
            AnimalHandling = 0;
            IsAnimalHandlingProficient = false;
            Arcana = 0;
            IsArcanaProficient = false;
            Athletics = 0;
            IsAthleticsProficient = false;
            Deception = 0;
            IsDeceptionProficient = false;
            History = 0;
            IsHistoryProficient = false;
            Insight = 0;
            IsInsightProficient = false;
            Intimidation = 0;
            IsIntimidationProficient = false;
            Investigation = 0;
            IsInvestigationProficient = false;
            Medicine = 0;
            IsMedicineProficient = false;
            Nature = 0;
            IsNatureProficient = false;
            Perception = 0;
            IsPerceptionProficient = false;
            Performance = 0;
            IsPerformanceProficient = false;
            Persuasion = 0;
            IsPersuasionProficient = false;
            Religion = 0;
            IsReligionProficient = false;
            SleightOfHand = 0;
            IsSleightOfHandProficient = false;
            Stealth = 0;
            IsStealthProficient = false;
            Survival = 0;
            IsSurvivalProficient = false;

            // saving throws
            StrengthSavingThrow = 0;
            DexteritySavingThrow = 0;
            ConstitutionSavingThrow = 0;
            IntelligenceSavingThrow = 0;
            WisdomSavingThrow = 0;
            CharismaSavingThrow = 0;

            // background info
            Age = string.Empty;
            Sex = string.Empty;
            Height = string.Empty;
            Weight = string.Empty;
            Eyes = string.Empty;
            Skin = string.Empty;
            Hair = string.Empty;
            Background = string.Empty;
            Alignment = string.Empty;

            // levels & stats
            Level = 1;
            ExperiencePoints = 0;
            ArmorClass = 10;
            CurrentHitPoints = 10;
            MaxHitPoints = 10;
            TemporaryHitPoints = 0; 
            Speed = 15;
            ProficiencyBonus = 0;

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int? CharacterId { get; set; }
        public string? Name { get; set; }

        public int? RaceId { get; set; }
        public CharacterRace? Race { get; set; }

        public int? ClassId { get; set; }
        public CharacterClass? Class { get; set; }

        public int? TokenId { get; set; }
        public CharacterToken? Token { get; set; }

        public int? VoiceId { get; set; }
        public Voice? CharacterVoice { get; set; }

        // Discord Server information
        public IList<DiscordGuild> Guilds { get; set; } 

        // Relationships & Organizations
        public IList<Character> Allies { get; set; } 
        public IList<Character> Enemies { get; set; }
        public IList<Organization> Organizations { get; set; }

        //Ability Scores
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Skills
        public int Acrobatics { get; set; } // Dexterity-based
        public bool IsAcrobaticsProficient { get; set; }

        public int AnimalHandling { get; set; } // Wisdom-based
        public bool IsAnimalHandlingProficient { get; set; }

        public int Arcana { get; set; } // Intelligence-based
        public bool IsArcanaProficient { get; set; }

        public int Athletics { get; set; } // Strength-based
        public bool IsAthleticsProficient { get; set; }

        public int Deception { get; set; } // Charisma-based
        public bool IsDeceptionProficient { get; set; }

        public int History { get; set; } // Intelligence-based
        public bool IsHistoryProficient { get; set; }

        public int Insight { get; set; } // Wisdom-based
        public bool IsInsightProficient { get; set; }

        public int Intimidation { get; set; } // Charisma-based
        public bool IsIntimidationProficient { get; set; }

        public int Investigation { get; set; } // Intelligence-based
        public bool IsInvestigationProficient { get; set; }

        public int Medicine { get; set; } // Wisdom-based
        public bool IsMedicineProficient { get; set; }

        public int Nature { get; set; } // Intelligence-based
        public bool IsNatureProficient { get; set; }

        public int Perception { get; set; } // Wisdom-based
        public bool IsPerceptionProficient { get; set; }

        public int Performance { get; set; } // Charisma-based
        public bool IsPerformanceProficient { get; set; }

        public int Persuasion { get; set; } // Charisma-based
        public bool IsPersuasionProficient { get; set; }

        public int Religion { get; set; } // Intelligence-based
        public bool IsReligionProficient { get; set; }

        public int SleightOfHand { get; set; } // Dexterity-based
        public bool IsSleightOfHandProficient { get; set; }

        public int Stealth { get; set; } // Dexterity-based
        public bool IsStealthProficient { get; set; }

        public int Survival { get; set; } // Wisdom-based
        public bool IsSurvivalProficient { get; set; }

        //SavingThrows
        public int StrengthSavingThrow { get; set; } 
        public int DexteritySavingThrow { get; set; } 
        public int ConstitutionSavingThrow { get; set; } 
        public int IntelligenceSavingThrow { get; set; } 
        public int WisdomSavingThrow { get; set; } 
        public int CharismaSavingThrow { get; set; } 

        // Levels & stats
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int ArmorClass { get; set; } 
        public int CurrentHitPoints { get; set; } 
        public int MaxHitPoints { get; set; } 
        public int TemporaryHitPoints { get; set; } 
        public int Speed { get; set; }
        public int ProficiencyBonus { get; set; }

        //Background Info
        public string? Age { get; set; }  
        public string? Sex { get; set; }  
        public string? Height { get; set; }  
        public string? Weight { get; set; }  
        public string? Eyes { get; set; }  
        public string? Skin { get; set; }  
        public string? Hair { get; set; }  
        public string? Background { get; set; }  
        public string? Alignment { get; set; }  

        public IList<Feature> Features { get; set; }
        public IList<Trait> Traits { get; set; } 

        public IList<Item> Items { get; set; }
        public IList<Spell> Spells { get; set; } 

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
