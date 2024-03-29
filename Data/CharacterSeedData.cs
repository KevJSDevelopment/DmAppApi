﻿using System;
using System.Diagnostics;
using DMApp.Models;
using Microsoft.EntityFrameworkCore;

public static class CharacterSeedData
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        var classes = new[]
        {
            new CharacterClass { Id = 1, Name = "Barbarian", Description = "A fierce warrior of primitive background who taps into their rage to unleash devastating attacks." },
            new CharacterClass { Id = 2, Name = "Bard", Description = "A spellcaster who uses their performances to weave magic and inspire allies or hinder foes." },
            new CharacterClass { Id = 3, Name = "Cleric", Description = "A holy warrior who channels divine power to heal allies, smite enemies, and protect the faith." },
            new CharacterClass { Id = 4, Name = "Druid", Description = "A spellcaster who draws power from nature and can transform into animals, commanding natural forces." },
            new CharacterClass { Id = 5, Name = "Fighter", Description = "A versatile warrior skilled in combat maneuvers and capable of taking on a variety of roles." },
            new CharacterClass { Id = 6, Name = "Monk", Description = "A disciplined warrior who has honed their body into a deadly weapon and gained mastery over ki." },
            new CharacterClass { Id = 7, Name = "Paladin", Description = "A holy knight dedicated to upholding justice and righteousness, channeling divine power in combat." },
            new CharacterClass { Id = 8, Name = "Ranger", Description = "A skilled hunter and tracker who excels at ranged combat and navigating the wilderness." },
            new CharacterClass { Id = 9, Name = "Rogue", Description = "A stealthy scoundrel who specializes in deception, agility, and exploiting their foes' weaknesses." },
            new CharacterClass { Id = 10, Name = "Sorcerer", Description = "A spellcaster with innate magical abilities, able to shape and cast spells through force of personality." },
            new CharacterClass { Id = 11, Name = "Warlock", Description = "A spellcaster who makes a pact with a powerful entity, gaining magical abilities in exchange for service." },
            new CharacterClass { Id = 12, Name = "Wizard", Description = "A scholarly magic-user who studies arcane knowledge and casts spells through careful study and preparation." }
            // Add more classes as needed
        };

        modelBuilder.Entity<CharacterClass>().HasData(classes);

        var races = new[]
        {
            new CharacterRace { Id = 1, Name = "Dragonborn", Description = "A humanoid creature with draconic ancestry, possessing dragon-like features and abilities." },
            new CharacterRace { Id = 2, Name = "Dwarf", Description = "A stout and tough humanoid known for their resilience, craftsmanship, and strong sense of tradition." },
            new CharacterRace { Id = 3, Name = "Elf", Description = "A graceful and long-lived humanoid race with a deep connection to magic and the natural world." },
            new CharacterRace { Id = 4, Name = "Gnome", Description = "A small and inventive humanoid known for their curiosity, ingenuity, and love of tinkering." },
            new CharacterRace { Id = 5, Name = "Half-Elf", Description = "A mixed heritage humanoid with both human and elven ancestry, combining the best traits of both races." },
            new CharacterRace { Id = 6, Name = "Half-Orc", Description = "A powerful and intimidating humanoid born from the union of orc and human parents, known for their strength and resilience." },
            new CharacterRace { Id = 7, Name = "Halfling", Description = "A small and nimble humanoid known for their luck, agility, and ability to avoid danger." },
            new CharacterRace { Id = 8, Name = "Human", Description = "A versatile and adaptable humanoid race, known for their ambition, diversity, and capacity for greatness." },
            new CharacterRace { Id = 9, Name = "Tiefling", Description = "A humanoid with infernal bloodline, often bearing demonic traits and possessing a connection to the Fiend." }
            // Add more races as needed
        };

        modelBuilder.Entity<CharacterRace>().HasData(races);

        var organizations = new[]
        {
            new Organization { Id = 1, Name = "Harper's Guild", Description = "A secret organization dedicated to preserving knowledge, maintaining balance, and fighting evil in all its forms." },
            new Organization { Id = 2, Name = "Order of the Gauntlet", Description = "A militant order that seeks to protect the innocent, enforce justice, and eradicate evil from the world." },
            new Organization { Id = 3, Name = "Emerald Enclave", Description = "A society of druids and other nature-focused individuals who strive to protect the natural world and maintain the balance of nature." },
            new Organization { Id = 4, Name = "Lords' Alliance", Description = "A political alliance of powerful city-states and influential leaders who work together to maintain stability and ensure the safety of their respective regions." },
            new Organization { Id = 5, Name = "Zhentarim", Description = "A secretive and powerful mercenary organization that operates in the shadows, pursuing wealth, power, and influence through any means necessary." },
            new Organization { Id = 6, Name = "Harpers", Description = "A scattered network of spies and informants who work to promote good, gather information, and thwart the plans of evil organizations." },
            new Organization { Id = 7, Name = "Cult of the Dragon", Description = "A fanatical cult that seeks to raise and control dragons, believing that they are the key to ultimate power and world domination." }
            // Add more organizations as needed
        };

        modelBuilder.Entity<Organization>().HasData(organizations);

        var features = new[]
        {
            // Barbarian features
            new Feature { Id = 1, Name = "Rage", Description = "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action.", ClassId = 1 },
            new Feature { Id = 2, Name = "Unarmored Defense", Description = "While you are not wearing any armor, your AC equals 10 + your Dexterity modifier + your Constitution modifier.", ClassId = 1 },
            // Bard features
            new Feature { Id = 3, Name = "Bardic Inspiration", Description = "You can inspire others through stirring words or music. As a bonus action, you can choose one creature within 60 feet.", ClassId = 2 },
            new Feature { Id = 4, Name = "Spellcasting", Description = "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music.", ClassId = 2 },
            // Cleric features
            new Feature { Id = 5, Name = "Divine Domain", Description = "Choose a divine domain, such as Life or Tempest, that grants you domain spells and other features.", ClassId = 3 },
            new Feature { Id = 6, Name = "Channel Divinity", Description = "At 2nd level, you gain the ability to channel divine energy directly from your deity.", ClassId = 3 },
            // Druid features
            new Feature { Id = 7, Name = "Druidic", Description = "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages.", ClassId = 4 },
            new Feature { Id = 8, Name = "Spellcasting", Description = "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.", ClassId = 4 },
            // Fighter features
            new Feature { Id = 9, Name = "Fighting Style", Description = "You adopt a particular style of fighting as your specialty. Choose one of the following options.", ClassId = 5 },
            new Feature { Id = 10, Name = "Second Wind", Description = "You have a limited well of stamina that you can draw on to protect yourself from harm.", ClassId = 5 },
            // Monk features
            new Feature { Id = 11, Name = "Unarmored Defense", Description = "While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", ClassId = 6 },
            new Feature { Id = 12, Name = "Martial Arts", Description = "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons.", ClassId = 6 },
            // Paladin features
            new Feature { Id = 13, Name = "Divine Sense", Description = "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears.", ClassId = 7 },
            new Feature { Id = 14, Name = "Lay on Hands", Description = "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest.", ClassId = 7 },
            // Ranger features
            new Feature { Id = 15, Name = "Favored Enemy", Description = "Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.", ClassId = 8 },
            new Feature { Id = 16, Name = "Natural Explorer", Description = "You are a master of navigating the natural world and have a deep understanding of the terrain.", ClassId = 8 },
            // Rogue features
            new Feature { Id = 17, Name = "Sneak Attack", Description = "Beginning at 1st level, you know how to strike subtly and exploit a foe's distraction.", ClassId = 9 },
            new Feature { Id = 18, Name = "Thieves' Cant", Description = "During your rogue training, you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages.", ClassId = 9 },
            // Sorcerer features
            new Feature { Id = 19, Name = "Sorcerous Origin", Description = "Choose a sorcerous origin, which describes the source of your innate magical power.", ClassId = 10 },
            new Feature { Id = 20, Name = "Spellcasting", Description = "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic.", ClassId = 10 },
            // Warlock features
            new Feature { Id = 21, Name = "Otherworldly Patron", Description = "At 1st level, you have struck a bargain with an otherworldly being of your choice.", ClassId = 11 },
            new Feature { Id = 22, Name = "Pact Magic", Description = "Your arcane research and the magic bestowed on you by your patron have given you facility with spells.", ClassId = 11 },
            // Wizard features
            new Feature { Id = 23, Name = "Spellcasting", Description = "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.", ClassId = 12 },
            new Feature { Id = 24, Name = "Arcane Recovery", Description = "You have learned to regain some of your magical energy by studying your spellbook.", ClassId = 12 }
            // Add more features for other classes
            // ...
        };

        modelBuilder.Entity<Feature>().HasData(features);

        var traits = new[]
        {
            // Dragonborn traits
            new Trait { Id = 1, Name = "Draconic Ancestry", Description = "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table." },
            new Trait { Id = 2, Name = "Breath Weapon", Description = "You can use your action to exhale destructive energy." },
            // Dwarf traits
            new Trait { Id = 3, Name = "Darkvision", Description = "Accustomed to life underground, you have superior vision in dark and dim conditions."},
            new Trait { Id = 4, Name = "Dwarven Resilience", Description = "You have advantage on saving throws against poison and resistance against poison damage."},
            // Elf traits
            // new Trait { Id = 1, Name = "Darkvision", Description = "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions."},
            new Trait { Id = 5, Name = "Fey Ancestry", Description = "You have advantage on saving throws against being charmed, and magic can't put you to sleep." },
            // Gnome traits
            // new Trait { Id = 1, Name = "Darkvision", Description = "Accustomed to life underground, you have superior vision in dark and dim conditions."},
            new Trait { Id = 6, Name = "Gnome Cunning", Description = "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic."},
            // Half-Elf traits
            new Trait { Id = 7, Name = "Ability Score Increase", Description = "Your Charisma score increases by 2, and two other ability scores of your choice increase by 1."},
            // new Trait { Id = 1, Name = "Fey Ancestry", Description = "You have advantage on saving throws against being charmed, and magic can't put you to sleep." },
            // Half-Orc traits
            // new Trait { Id = 1, Name = "Darkvision", Description = "Thanks to your orc blood, you have superior vision in dark and dim conditions."},
            new Trait { Id = 8, Name = "Relentless Endurance", Description = "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead."},
            // Halfling traits
            new Trait { Id = 9, Name = "Lucky", Description = "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll."},
            new Trait { Id = 10, Name = "Brave", Description = "You have advantage on saving throws against being frightened."},
            // Human traits
            // new Trait { Id = 1, Name = "Ability Score Increase", Description = "Your ability scores each increase by 1."},
            // Tiefling traits
            // new Trait { Id = 1, Name = "Darkvision", Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light." },
            new Trait { Id = 11, Name = "Hellish Resistance", Description = "You have resistance to fire damage.", }
            // Add more racial traits as needed
            // ...
        };

        modelBuilder.Entity<Trait>().HasData(traits);

        var items = new[]
        {
            new Item { Id = 1, Name = "Chain mail", Description = "It aint good, but it aint bad either", Cost = 75 },
            new Item { Id = 2, Name = "Short bow", Description = "A short bow", Cost = 20 },
            // Add more item instances as needed
        };
        modelBuilder.Entity<Item>().HasData(items);

        var spells = new[]
        {
            new Spell { Id = 1, Name = "Spell 1" },
            new Spell { Id = 2, Name = "Spell 2" },
            // Add more spell instances as needed
        };
        modelBuilder.Entity<Spell>().HasData(spells);


        //var campaigns = new[]
        //{
        //    new Campaign { CampaignId = 1, Name = "Lord of the rings", },
        //    new Campaign { CampaignId = 2, Name = "Harry Potter" },
        //    // Add more character instances as needed
        //};

        //modelBuilder.Entity<Campaign>().HasData(campaigns);

        var characters = new[]
        {
            new Character { Id = 1, Name = "Grondar", RaceId = 1 },
            new Character { Id = 2, Name = "Zander", RaceId = 2 },
            // Add more character instances as needed
        };

        modelBuilder.Entity<CharacterClassCharacter>()
            .HasData(
                new CharacterClassCharacter
                {
                    CharacterClassId = classes[0].Id,
                    CharacterId = characters[0].Id
                },
                new CharacterClassCharacter
                {
                    CharacterClassId = classes[1].Id,
                    CharacterId = characters[1].Id
                }

            );
        modelBuilder.Entity<Character>().HasData(characters);

        modelBuilder.Entity<CharacterAlly>()
            .HasData(
                new CharacterAlly
                {
                    CharacterId = characters[0].Id,
                    AllyId = characters[1].Id,
                }
            );

        modelBuilder.Entity<CharacterEnemy>()
            .HasData(
                new CharacterEnemy
                {
                    CharacterId = characters[0].Id,
                    EnemyId = characters[1].Id
                }
            );

        modelBuilder.Entity<CharacterOrganization>()
            .HasData(
                new CharacterOrganization
                {
                    CharacterId = characters[0].Id,
                    OrganizationId = 1
                },
                new CharacterOrganization
                {
                    CharacterId = characters[1].Id,
                    OrganizationId = 2
                }
            );

        modelBuilder.Entity<CharacterFeature>()
            .HasData(
                new CharacterFeature
                {
                    CharacterId = characters[0].Id,
                    FeatureId = 2
                },
                new CharacterFeature
                {
                    CharacterId = characters[1].Id,
                    FeatureId = 3
                }
            );

        modelBuilder.Entity<CharacterTrait>()
            .HasData(
                new CharacterTrait
                {
                    CharacterId = characters[0].Id,
                    TraitId = 1
                },
                new CharacterTrait
                {
                    CharacterId = characters[1].Id,
                    TraitId = 4
                }
            );

        modelBuilder.Entity<CharacterItem>()
            .HasData(
                new CharacterItem
                {
                    CharacterId = characters[0].Id,
                    ItemId = items[0].Id
                },
                new CharacterItem
                {
                    CharacterId = characters[1].Id,
                    ItemId = items[1].Id
                }
            );

        modelBuilder.Entity<CharacterSpell>()
            .HasData(
                new CharacterSpell
                {
                    CharacterId = characters[0].Id,
                    SpellId = spells[0].Id
                },
                new CharacterSpell
                {
                    CharacterId = characters[1].Id,
                    SpellId = spells[1].Id
                }
            );

    }
}
