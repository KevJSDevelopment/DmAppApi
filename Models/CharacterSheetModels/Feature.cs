using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Hosting;

namespace DMApp.Models
{
    public class Feature
    {
        public Feature()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;

            Immunities = string.Empty;
            Resistances = string.Empty;
            Vulnerabilities = string.Empty;

            Level = 1;

            StrengthModifier = 0;
            DexterityModifier = 0;
            ConstitutionModifier = 0;
            IntelligenceModifier = 0;
            WisdomModifier = 0;
            CharismaModifier = 0;

            //Skills
            IsAcrobaticsProficient = false;
            IsAnimalHandlingProficient = false;
            IsArcanaProficient = false;
            IsAthleticsProficient = false;
            IsDeceptionProficient = false;
            IsHistoryProficient = false;
            IsInsightProficient = false;
            IsIntimidationProficient = false;
            IsInvestigationProficient = false;
            IsMedicineProficient = false;
            IsNatureProficient = false;
            IsPerceptionProficient = false;
            IsPerformanceProficient = false;
            IsPersuasionProficient = false;
            IsReligionProficient = false;
            IsSleightOfHandProficient = false;
            IsStealthProficient = false;
            IsSurvivalProficient = false;

            //SavingThrows
            StrengthSavingThrowModifier = 0;
            DexteritySavingThrowModifier = 0;
            ConstitutionSavingThrowModifier = 0;
            IntelligenceSavingThrowModifier = 0;
            WisdomSavingThrowModifier = 0;
            CharismaSavingThrowModifier = 0;

            // Levels & stats
            ArmorClassModifier = 0;
            HitPointsModifier = 0;
            TemporaryHitPointsModifier = 0;
            SpeedModifier = 0;
            ProficiencyBonusModifier = 0;
        }

        public int FeatureId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? ClassId { get; set; }
        public CharacterClass? Class { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public int? Level { get; set; }

        
        public string Immunities { get; set; }    
        public string Resistances { get; set; }
        public string Vulnerabilities { get; set; }

        //Ability Scores
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int WisdomModifier { get; set; }
        public int CharismaModifier { get; set; }

        //Skills
        public bool IsAcrobaticsProficient { get; set; }
        public bool IsAnimalHandlingProficient { get; set; }
        public bool IsArcanaProficient { get; set; }
        public bool IsAthleticsProficient { get; set; }
        public bool IsDeceptionProficient { get; set; }
        public bool IsHistoryProficient { get; set; }
        public bool IsInsightProficient { get; set; }
        public bool IsIntimidationProficient { get; set; }
        public bool IsInvestigationProficient { get; set; }
        public bool IsMedicineProficient { get; set; }
        public bool IsNatureProficient { get; set; }
        public bool IsPerceptionProficient { get; set; }
        public bool IsPerformanceProficient { get; set; }
        public bool IsPersuasionProficient { get; set; }
        public bool IsReligionProficient { get; set; }
        public bool IsSleightOfHandProficient { get; set; }
        public bool IsStealthProficient { get; set; }
        public bool IsSurvivalProficient { get; set; }

        //SavingThrows
        public int StrengthSavingThrowModifier { get; set; }
        public int DexteritySavingThrowModifier { get; set; }
        public int ConstitutionSavingThrowModifier { get; set; }
        public int IntelligenceSavingThrowModifier { get; set; }
        public int WisdomSavingThrowModifier { get; set; }
        public int CharismaSavingThrowModifier { get; set; }

        // Levels & stats
        public int ArmorClassModifier { get; set; }
        public int HitPointsModifier { get; set; }
        public int TemporaryHitPointsModifier { get; set; }
        public int SpeedModifier { get; set; }
        public int ProficiencyBonusModifier { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
