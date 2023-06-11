using DMApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

public static class CharacterSeedData
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        // Ability Scores
        modelBuilder.Entity<AbilityScore>().HasData(
            new AbilityScore {
                AbilityScoreId = 1,
                Strength = 10,
                Dexterity = 12,
                Constitution = 14,
                Intelligence = 16,
                Wisdom = 14,
                Charisma = 10
            }
            // Add more ability scores...

        // You can add more ability scores as needed
        );

        // Skill Sets
        modelBuilder.Entity<SkillSet>().HasData(
            new SkillSet {
                SkillSetId = 1,
                Acrobatics = 5,
                AnimalHandling = 3,
                Arcana = 8, Athletics = 4,
                Deception = 2,
                History = 6,
                Insight = 5,
                Intimidation = 4,
                Investigation = 6,
                Medicine = 3,
                Nature = 4,
                Perception = 7,
                Performance = 3,
                Persuasion = 4,
                Religion = 6,
                SleightOfHand = 2,
                Stealth = 5,
                Survival = 3
            }
            // Add more skill sets...

        // You can add more skill sets as needed
        );

        // Saving Throws
        modelBuilder.Entity<SavingThrows>().HasData(
            new SavingThrows { SavingThrowsId = 1, Strength = 5, Dexterity = 4, Constitution = 6, Intelligence = 7, Wisdom = 4, Charisma = 3 }
            // Add more saving throws...

        // You can add more saving throws as needed
        );

        // Background Information
        modelBuilder.Entity<BackgroundInfo>().HasData(
            new BackgroundInfo
            {
                BackgroundInfoId = 1,
                Age = "30",
                Sex = "Male",
                Height = "6 feet",
                Weight = "180 lbs",
                Eyes = "Blue",
                Skin = "Fair",
                Hair = "Brown",
                Background = "Noble",
                Alignment = "Lawful Good"
            }
            // Add more background information...

        // You can add more background information as needed
        );

        // Races
        modelBuilder.Entity<CharacterRace>().HasData(
            new CharacterRace { CharacterRaceId = 1, Name = "Human", Description = "Versatile and adaptable race." },
            new CharacterRace { CharacterRaceId = 2, Name = "Elf", Description = "Graceful and long-lived race." }
            // Add more races...

        // You can add more races as needed
        );

        // Classes
        modelBuilder.Entity<CharacterClass>().HasData(
            new CharacterClass { CharacterClassId = 1, Name = "Wizard", Description = "Masters of arcane magic." },
            new CharacterClass { CharacterClassId = 2, Name = "Fighter", Description = "Skilled warriors." }
            // Add more classes...

        // You can add more classes as needed
        );

        // Features
        var feature1 = new Feature { FeatureId = 1, Name = "Fireball", Description = "Unleash a fiery explosion in a designated area." };
        var feature2 = new Feature { FeatureId = 2, Name = "Second Wind", Description = "Regain hit points during combat." };
        modelBuilder.Entity<Feature>().HasData(
            feature1, feature2
        // You can add more features as needed
        );


        // Items
        var item1 = new Item { ItemId = 1, Name = "Staff of Power", Description = "A legendary staff imbued with immense magical power." };
        var item2 = new Item { ItemId = 2, Name = "Plate Armor", Description = "Heavy armor that provides exceptional protection." };
            // Add more items...
        modelBuilder.Entity<Item>().HasData(
            item1, item2
        // You can add more items as needed
        );

        // Spells
        var spell1 = new Spell { SpellId = 1, Name = "Magic Missile", SpellLevel = 1, Description = "Shoots magical missiles at targets." };
        var spell2 = new Spell { SpellId = 2, Name = "Healing Word", SpellLevel = 1, Description = "Heals a creature's wounds." };
            // Add more spells...
        modelBuilder.Entity<Spell>().HasData(spell1, spell2
        // You can add more spells as needed
        );
        // Characters
        modelBuilder.Entity<Character>().HasData(
            new Character
            {
                CharacterId = 1,
                Name = "Character 1",
                RaceId = 1,
                ClassId = 1,
                AbilityScoreId = 1,
                SkillSetId = 1,
                SavingThrowsId = 1,
                BackgroundInfoId = 1,
                Features = new List<Feature> { feature1 },
                Items = new List<Item> { item1 },
                Spells = new List<Spell> { spell1 }
            },
            new Character
            {
                CharacterId = 2,
                Name = "Character 2",
                RaceId = 2,
                ClassId = 2,
                AbilityScoreId = 2,
                SkillSetId = 2,
                SavingThrowsId = 2,
                BackgroundInfoId = 2,
                Features = new List<Feature> { feature2 },
                Items = new List<Item> { item2 },
                Spells = new List<Spell> { spell2 }
            }

        // You can add more characters as needed
        );
    }
}
