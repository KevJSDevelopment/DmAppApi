using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class SkillSet
    {
        [Key]
        public int SkillSetId { get; set; }
        [Required]
        public int CharacterId { get; set; }
        [Required]
        public Character Character { get; set; }

        public int Acrobatics { get; set; } = 0; // Dexterity-based
        public bool IsAcrobaticsProficient { get; set; } = false;

        public int AnimalHandling { get; set; } = 0; // Wisdom-based
        public bool IsAnimalHandlingProficient { get; set; } = false;

        public int Arcana { get; set; } = 0; // Intelligence-based
        public bool IsArcanaProficient { get; set; } = false;

        public int Athletics { get; set; } = 0; // Strength-based
        public bool IsAthleticsProficient { get; set; } = false;

        public int Deception { get; set; } = 0; // Charisma-based
        public bool IsDeceptionProficient { get; set; } = false;

        public int History { get; set; } = 0; // Intelligence-based
        public bool IsHistoryProficient { get; set; } = false;

        public int Insight { get; set; } = 0; // Wisdom-based
        public bool IsInsightProficient { get; set; } = false;

        public int Intimidation { get; set; } = 0; // Charisma-based
        public bool IsIntimidationProficient { get; set; } = false;

        public int Investigation { get; set; } = 0; // Intelligence-based
        public bool IsInvestigationProficient { get; set; } = false;

        public int Medicine { get; set; } = 0; // Wisdom-based
        public bool IsMedicineProficient { get; set; } = false;

        public int Nature { get; set; } = 0; // Intelligence-based
        public bool IsNatureProficient { get; set; } = false;

        public int Perception { get; set; } = 0; // Wisdom-based
        public bool IsPerceptionProficient { get; set; } = false;

        public int Performance { get; set; } = 0; // Charisma-based
        public bool IsPerformanceProficient { get; set; } = false;

        public int Persuasion { get; set; } = 0; // Charisma-based
        public bool IsPersuasionProficient { get; set; } = false;

        public int Religion { get; set; } = 0; // Intelligence-based
        public bool IsReligionProficient { get; set; } = false;

        public int SleightOfHand { get; set; } = 0; // Dexterity-based
        public bool IsSleightOfHandProficient { get; set; } = false;

        public int Stealth { get; set; } = 0; // Dexterity-based
        public bool IsStealthProficient { get; set; } = false;

        public int Survival { get; set; } = 0; // Wisdom-based
        public bool IsSurvivalProficient { get; set; } = false;

    }

}

