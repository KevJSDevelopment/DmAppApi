using System;
using System.Diagnostics;
using DMApp.Models;
using Microsoft.EntityFrameworkCore;

public static class CharacterSeedData
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CharacterClass>().HasData(
            new CharacterClass { CharacterClassId = 1, Name = "Barbarian", Description = "A fierce warrior of primitive background who taps into their rage to unleash devastating attacks." },
            new CharacterClass { CharacterClassId = 2, Name = "Bard", Description = "A spellcaster who uses their performances to weave magic and inspire allies or hinder foes." },
            new CharacterClass { CharacterClassId = 3, Name = "Cleric", Description = "A holy warrior who channels divine power to heal allies, smite enemies, and protect the faith."  },
            new CharacterClass { CharacterClassId = 4, Name = "Druid", Description = "A spellcaster who draws power from nature and can transform into animals, commanding natural forces."  },
            new CharacterClass { CharacterClassId = 5, Name = "Fighter", Description = "A versatile warrior skilled in combat maneuvers and capable of taking on a variety of roles."  },
            new CharacterClass { CharacterClassId = 6, Name = "Monk", Description = "A disciplined warrior who has honed their body into a deadly weapon and gained mastery over ki."  },
            new CharacterClass { CharacterClassId = 7, Name = "Paladin", Description = "A holy knight dedicated to upholding justice and righteousness, channeling divine power in combat."  },
            new CharacterClass { CharacterClassId = 8, Name = "Ranger", Description = "A skilled hunter and tracker who excels at ranged combat and navigating the wilderness."  },
            new CharacterClass { CharacterClassId = 9, Name = "Rogue", Description = "A stealthy scoundrel who specializes in deception, agility, and exploiting their foes' weaknesses." },
            new CharacterClass { CharacterClassId = 10, Name = "Sorcerer", Description = "A spellcaster with innate magical abilities, able to shape and cast spells through force of personality." },
            new CharacterClass { CharacterClassId = 11, Name = "Warlock", Description = "A spellcaster who makes a pact with a powerful entity, gaining magical abilities in exchange for service." },
            new CharacterClass { CharacterClassId = 12, Name = "Wizard", Description = "A scholarly magic-user who studies arcane knowledge and casts spells through careful study and preparation." }
            // Add more classes as needed
        );

        modelBuilder.Entity<CharacterRace>().HasData(
            new CharacterRace { CharacterRaceId = 1, Name = "Dragonborn", Description = "A humanoid creature with draconic ancestry, possessing dragon-like features and abilities." },
            new CharacterRace { CharacterRaceId = 2, Name = "Dwarf", Description = "A stout and tough humanoid known for their resilience, craftsmanship, and strong sense of tradition." },
            new CharacterRace { CharacterRaceId = 3, Name = "Elf", Description = "A graceful and long-lived humanoid race with a deep connection to magic and the natural world." },
            new CharacterRace { CharacterRaceId = 4, Name = "Gnome", Description = "A small and inventive humanoid known for their curiosity, ingenuity, and love of tinkering." },
            new CharacterRace { CharacterRaceId = 5, Name = "Half-Elf", Description = "A mixed heritage humanoid with both human and elven ancestry, combining the best traits of both races." },
            new CharacterRace { CharacterRaceId = 6, Name = "Half-Orc", Description = "A powerful and intimidating humanoid born from the union of orc and human parents, known for their strength and resilience." },
            new CharacterRace { CharacterRaceId = 7, Name = "Halfling", Description = "A small and nimble humanoid known for their luck, agility, and ability to avoid danger." },
            new CharacterRace { CharacterRaceId = 8, Name = "Human", Description = "A versatile and adaptable humanoid race, known for their ambition, diversity, and capacity for greatness." },
            new CharacterRace { CharacterRaceId = 9, Name = "Tiefling", Description = "A humanoid with infernal bloodline, often bearing demonic traits and possessing a connection to the Fiend." }
        // Add more races as needed
        );

        modelBuilder.Entity<DiscordGuild>().HasData(new DiscordGuild { GuildId = 1077311704985239684 });

        modelBuilder.Entity<Organization>().HasData(
            new Organization { OrganizationId = 1, Name = "Harper's Guild", Description = "A secret organization dedicated to preserving knowledge, maintaining balance, and fighting evil in all its forms." },
            new Organization { OrganizationId = 2, Name = "Order of the Gauntlet", Description = "A militant order that seeks to protect the innocent, enforce justice, and eradicate evil from the world." },
            new Organization { OrganizationId = 3, Name = "Emerald Enclave", Description = "A society of druids and other nature-focused individuals who strive to protect the natural world and maintain the balance of nature." },
            new Organization { OrganizationId = 4, Name = "Lords' Alliance", Description = "A political alliance of powerful city-states and influential leaders who work together to maintain stability and ensure the safety of their respective regions." },
            new Organization { OrganizationId = 5, Name = "Zhentarim", Description = "A secretive and powerful mercenary organization that operates in the shadows, pursuing wealth, power, and influence through any means necessary." },
            new Organization { OrganizationId = 6, Name = "Harpers", Description = "A scattered network of spies and informants who work to promote good, gather information, and thwart the plans of evil organizations." },
            new Organization { OrganizationId = 7, Name = "Cult of the Dragon", Description = "A fanatical cult that seeks to raise and control dragons, believing that they are the key to ultimate power and world domination." }
            // Add more organizations as needed
        );

        modelBuilder.Entity<Feature>().HasData(
            // Barbarian features
            new Feature { FeatureId = 1, Name = "Rage", Description = "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action.", ClassId = 1 },
            new Feature { FeatureId = 2, Name = "Unarmored Defense", Description = "While you are not wearing any armor, your AC equals 10 + your Dexterity modifier + your Constitution modifier.", ClassId = 1 },
            // Bard features
            new Feature { FeatureId = 3, Name = "Bardic Inspiration", Description = "You can inspire others through stirring words or music. As a bonus action, you can choose one creature within 60 feet.", ClassId = 2 },
            new Feature { FeatureId = 4, Name = "Spellcasting", Description = "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music.", ClassId = 2 },
            // Cleric features
            new Feature { FeatureId = 5, Name = "Divine Domain", Description = "Choose a divine domain, such as Life or Tempest, that grants you domain spells and other features.", ClassId = 3 },
            new Feature { FeatureId = 6, Name = "Channel Divinity", Description = "At 2nd level, you gain the ability to channel divine energy directly from your deity.", ClassId = 3 },
            // Druid features
            new Feature { FeatureId = 7, Name = "Druidic", Description = "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages.", ClassId = 4 },
            new Feature { FeatureId = 8, Name = "Spellcasting", Description = "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.", ClassId = 4 },
            // Fighter features
            new Feature { FeatureId = 9, Name = "Fighting Style", Description = "You adopt a particular style of fighting as your specialty. Choose one of the following options.", ClassId = 5 },
            new Feature { FeatureId = 10, Name = "Second Wind", Description = "You have a limited well of stamina that you can draw on to protect yourself from harm.", ClassId = 5 },
            // Monk features
            new Feature { FeatureId = 11, Name = "Unarmored Defense", Description = "While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", ClassId = 6 },
            new Feature { FeatureId = 12, Name = "Martial Arts", Description = "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons.", ClassId = 6 },
            // Paladin features
            new Feature { FeatureId = 13, Name = "Divine Sense", Description = "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears.", ClassId = 7 },
            new Feature { FeatureId = 14, Name = "Lay on Hands", Description = "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest.", ClassId = 7 },
            // Ranger features
            new Feature { FeatureId = 15, Name = "Favored Enemy", Description = "Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.", ClassId = 8 },
            new Feature { FeatureId = 16, Name = "Natural Explorer", Description = "You are a master of navigating the natural world and have a deep understanding of the terrain.", ClassId = 8 },
            // Rogue features
            new Feature { FeatureId = 17, Name = "Sneak Attack", Description = "Beginning at 1st level, you know how to strike subtly and exploit a foe's distraction.", ClassId = 9 },
            new Feature { FeatureId = 18, Name = "Thieves' Cant", Description = "During your rogue training, you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages.", ClassId = 9 },
            // Sorcerer features
            new Feature { FeatureId = 19, Name = "Sorcerous Origin", Description = "Choose a sorcerous origin, which describes the source of your innate magical power.", ClassId = 10 },
            new Feature { FeatureId = 20, Name = "Spellcasting", Description = "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic.", ClassId = 10 },
            // Warlock features
            new Feature { FeatureId = 21, Name = "Otherworldly Patron", Description = "At 1st level, you have struck a bargain with an otherworldly being of your choice.", ClassId = 11 },
            new Feature { FeatureId = 22, Name = "Pact Magic", Description = "Your arcane research and the magic bestowed on you by your patron have given you facility with spells.", ClassId = 11 },
            // Wizard features
            new Feature { FeatureId = 23, Name = "Spellcasting", Description = "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.", ClassId = 12 },
            new Feature { FeatureId = 24, Name = "Arcane Recovery", Description = "You have learned to regain some of your magical energy by studying your spellbook.", ClassId = 12 }
            // Add more features for other classes
            // ...
        );

        modelBuilder.Entity<Trait>().HasData(
            // Dragonborn traits
            new Trait { TraitId = 1, Name = "Draconic Ancestry", Description = "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table." },
            new Trait { TraitId = 2, Name = "Breath Weapon", Description = "You can use your action to exhale destructive energy." },
            // Dwarf traits
            new Trait { TraitId = 3, Name = "Darkvision", Description = "Accustomed to life underground, you have superior vision in dark and dim conditions."},
            new Trait { TraitId = 4, Name = "Dwarven Resilience", Description = "You have advantage on saving throws against poison and resistance against poison damage."},
            // Elf traits
            // new Trait { TraitId = 1, Name = "Darkvision", Description = "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions."},
            new Trait { TraitId = 5, Name = "Fey Ancestry", Description = "You have advantage on saving throws against being charmed, and magic can't put you to sleep." },
            // Gnome traits
            // new Trait { TraitId = 1, Name = "Darkvision", Description = "Accustomed to life underground, you have superior vision in dark and dim conditions."},
            new Trait { TraitId = 6, Name = "Gnome Cunning", Description = "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic."},
            // Half-Elf traits
            new Trait { TraitId = 7, Name = "Ability Score Increase", Description = "Your Charisma score increases by 2, and two other ability scores of your choice increase by 1."},
            // new Trait { TraitId = 1, Name = "Fey Ancestry", Description = "You have advantage on saving throws against being charmed, and magic can't put you to sleep." },
            // Half-Orc traits
            // new Trait { TraitId = 1, Name = "Darkvision", Description = "Thanks to your orc blood, you have superior vision in dark and dim conditions."},
            new Trait { TraitId = 8, Name = "Relentless Endurance", Description = "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead."},
            // Halfling traits
            new Trait { TraitId = 9, Name = "Lucky", Description = "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll."},
            new Trait { TraitId = 10, Name = "Brave", Description = "You have advantage on saving throws against being frightened."},
            // Human traits
            // new Trait { TraitId = 1, Name = "Ability Score Increase", Description = "Your ability scores each increase by 1."},
            // Tiefling traits
            // new Trait { TraitId = 1, Name = "Darkvision", Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light." },
            new Trait { TraitId = 11, Name = "Hellish Resistance", Description = "You have resistance to fire damage.", }
            // Add more racial traits as needed
            // ...
        );

        var items = new[]
        {
            new Item { ItemId = 1, Name = "Chain mail", Description = "It aint good, but it aint bad either", Cost = 75 },
            new Item { ItemId = 2, Name = "Short bow", Description = "A short bow", Cost = 20 },
            // Add more item instances as needed
        };
        modelBuilder.Entity<Item>().HasData(items);

        var spells = new[]
        {
            new Spell { SpellId = 1, Name = "Spell 1" },
            new Spell { SpellId = 2, Name = "Spell 2" },
            // Add more spell instances as needed
        };
        modelBuilder.Entity<Spell>().HasData(spells);

        var characters = new[]
        {
            new Character { CharacterId = 1, Name = "Grondar", RaceId = 1, ClassId = 1 },
            new Character { CharacterId = 2, Name = "Zander", RaceId = 2, ClassId = 2 },
            // Add more character instances as needed
        };
        modelBuilder.Entity<Character>().HasData(characters);

        modelBuilder.Entity("CharacterGuild")
         .HasData(
             new
             {
                 GuildId = 1077311704985239684,
                 CharacterId = 1,
                 JoinedOn = DateTime.UtcNow
             },
             new
             {
                 GuildId = 1077311704985239684,
                 CharacterId = 2,
                 JoinedOn = DateTime.UtcNow
             }
         );

        modelBuilder.Entity("CharacterAlly")
            .HasData(
                new
                {
                    CharacterId = characters[0].CharacterId,
                    AllyId = characters[1].CharacterId
                }
            );

        modelBuilder.Entity("CharacterEnemy")
            .HasData(
                new
                {
                    CharacterId = characters[0].CharacterId,
                    EnemyId = characters[1].CharacterId
                }
            );

        modelBuilder.Entity("CharacterOrganization")
            .HasData(
                new
                {
                    CharacterId = characters[0].CharacterId,
                    OrganizationId = 1
                },
                new
                {
                    CharacterId = characters[1].CharacterId,
                    OrganizationId = 2
                }
            );

        modelBuilder.Entity("CharacterFeature")
            .HasData(
                new
                {
                    CharacterId = characters[0].CharacterId,
                    FeatureId = 2
                },
                new
                {
                    CharacterId = characters[1].CharacterId,
                    FeatureId = 3
                }
            );

        modelBuilder.Entity("CharacterTrait")
            .HasData(
                new
                {
                    CharacterId = characters[0].CharacterId,
                    TraitId = 1
                },
                new
                {
                    CharacterId = characters[1].CharacterId,
                    TraitId = 4
                }
            );

        modelBuilder.Entity("CharacterItem")
            .HasData(
                new
                {
                    CharacterId = 1,
                    ItemId = items[0].ItemId
                },
                new
                {
                    CharacterId = 2,
                    ItemId = items[1].ItemId
                }
            );

        modelBuilder.Entity("CharacterSpell")
            .HasData(
                new
                {
                    CharacterId = 1,
                    SpellId = spells[0].SpellId
                },
                new
                {
                    CharacterId = 2,
                    SpellId = spells[1].SpellId
                }
            );
    }
}
