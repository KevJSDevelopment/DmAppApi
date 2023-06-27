using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "CharacterClassId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 42, 18, 192, DateTimeKind.Utc).AddTicks(9990), "A fierce warrior of primitive background who taps into their rage to unleash devastating attacks.", "Barbarian", new DateTime(2023, 6, 25, 17, 42, 18, 192, DateTimeKind.Utc).AddTicks(9990) },
                    { 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A spellcaster who uses their performances to weave magic and inspire allies or hinder foes.", "Bard", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) },
                    { 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A holy warrior who channels divine power to heal allies, smite enemies, and protect the faith.", "Cleric", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) },
                    { 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A spellcaster who draws power from nature and can transform into animals, commanding natural forces.", "Druid", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) },
                    { 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A versatile warrior skilled in combat maneuvers and capable of taking on a variety of roles.", "Fighter", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) },
                    { 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A disciplined warrior who has honed their body into a deadly weapon and gained mastery over ki.", "Monk", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) },
                    { 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), "A holy knight dedicated to upholding justice and righteousness, channeling divine power in combat.", "Paladin", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) },
                    { 8, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), "A skilled hunter and tracker who excels at ranged combat and navigating the wilderness.", "Ranger", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) },
                    { 9, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), "A stealthy scoundrel who specializes in deception, agility, and exploiting their foes' weaknesses.", "Rogue", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) },
                    { 10, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), "A spellcaster with innate magical abilities, able to shape and cast spells through force of personality.", "Sorcerer", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) },
                    { 11, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), "A spellcaster who makes a pact with a powerful entity, gaining magical abilities in exchange for service.", "Warlock", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) },
                    { 12, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), "A scholarly magic-user who studies arcane knowledge and casts spells through careful study and preparation.", "Wizard", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) }
                });

            migrationBuilder.InsertData(
                table: "DiscordGuilds",
                columns: new[] { "GuildId", "CreatedOn", "UpdatedOn" },
                values: new object[] { 1077311704985239684L, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Cost", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 75, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(580), "It aint good, but it aint bad either", "Chain mail", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(580) },
                    { 2, 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(590), "", "", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(590) }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), "A secret organization dedicated to preserving knowledge, maintaining balance, and fighting evil in all its forms.", "Harper's Guild", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) },
                    { 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), "A militant order that seeks to protect the innocent, enforce justice, and eradicate evil from the world.", "Order of the Gauntlet", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) },
                    { 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), "A society of druids and other nature-focused individuals who strive to protect the natural world and maintain the balance of nature.", "Emerald Enclave", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) },
                    { 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), "A political alliance of powerful city-states and influential leaders who work together to maintain stability and ensure the safety of their respective regions.", "Lords' Alliance", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) },
                    { 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), "A secretive and powerful mercenary organization that operates in the shadows, pursuing wealth, power, and influence through any means necessary.", "Zhentarim", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) },
                    { 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), "A scattered network of spies and informants who work to promote good, gather information, and thwart the plans of evil organizations.", "Harpers", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) },
                    { 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), "A fanatical cult that seeks to raise and control dragons, believing that they are the key to ultimate power and world domination.", "Cult of the Dragon", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "CharacterRaceId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(360), "A humanoid creature with draconic ancestry, possessing dragon-like features and abilities.", "Dragonborn", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(360) },
                    { 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), "A stout and tough humanoid known for their resilience, craftsmanship, and strong sense of tradition.", "Dwarf", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) },
                    { 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), "A graceful and long-lived humanoid race with a deep connection to magic and the natural world.", "Elf", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) },
                    { 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), "A small and inventive humanoid known for their curiosity, ingenuity, and love of tinkering.", "Gnome", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) },
                    { 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), "A mixed heritage humanoid with both human and elven ancestry, combining the best traits of both races.", "Half-Elf", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) },
                    { 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), "A powerful and intimidating humanoid born from the union of orc and human parents, known for their strength and resilience.", "Half-Orc", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) },
                    { 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), "A small and nimble humanoid known for their luck, agility, and ability to avoid danger.", "Halfling", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) },
                    { 8, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), "A versatile and adaptable humanoid race, known for their ambition, diversity, and capacity for greatness.", "Human", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) },
                    { 9, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), "A humanoid with infernal bloodline, often bearing demonic traits and possessing a connection to the Fiend.", "Tiefling", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "SpellId", "CreatedOn", "Description", "Name", "SpellLevel", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600), "", "Spell 1", 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600) },
                    { 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600), "", "Spell 2", 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(610) }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550), "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table.", "Draconic Ancestry", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550) },
                    { 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550), "You can use your action to exhale destructive energy.", "Breath Weapon", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550) },
                    { 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "Accustomed to life underground, you have superior vision in dark and dim conditions.", "Darkvision", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) },
                    { 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "You have advantage on saving throws against poison and resistance against poison damage.", "Dwarven Resilience", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) },
                    { 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "You have advantage on saving throws against being charmed, and magic can't put you to sleep.", "Fey Ancestry", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) },
                    { 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", "Gnome Cunning", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) },
                    { 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "Your Charisma score increases by 2, and two other ability scores of your choice increase by 1.", "Ability Score Increase", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) },
                    { 8, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead.", "Relentless Endurance", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) },
                    { 9, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.", "Lucky", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) },
                    { 10, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), "You have advantage on saving throws against being frightened.", "Brave", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) },
                    { 11, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), "You have resistance to fire damage.", "Hellish Resistance", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Acrobatics", "Age", "Alignment", "AnimalHandling", "Arcana", "ArmorClass", "Athletics", "Background", "Charisma", "CharismaSavingThrow", "ClassId", "Constitution", "ConstitutionSavingThrow", "CreatedOn", "CurrentHitPoints", "Deception", "Dexterity", "DexteritySavingThrow", "ExperiencePoints", "Eyes", "Hair", "Height", "History", "Insight", "Intelligence", "IntelligenceSavingThrow", "Intimidation", "Investigation", "IsAcrobaticsProficient", "IsAnimalHandlingProficient", "IsArcanaProficient", "IsAthleticsProficient", "IsDeceptionProficient", "IsHistoryProficient", "IsInsightProficient", "IsIntimidationProficient", "IsInvestigationProficient", "IsMedicineProficient", "IsNatureProficient", "IsPerceptionProficient", "IsPerformanceProficient", "IsPersuasionProficient", "IsReligionProficient", "IsSleightOfHandProficient", "IsStealthProficient", "IsSurvivalProficient", "Level", "MaxHitPoints", "Medicine", "Name", "Nature", "Perception", "Performance", "Persuasion", "ProficiencyBonus", "RaceId", "Religion", "Sex", "Skin", "SleightOfHand", "Speed", "Stealth", "Strength", "StrengthSavingThrow", "Survival", "TemporaryHitPoints", "TokenId", "UpdatedOn", "Weight", "Wisdom", "WisdomSavingThrow" },
                values: new object[,]
                {
                    { 1, 0, "", "", 0, 0, 10, 0, "", 10, 0, 1, 10, 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), 10, 0, 10, 0, 0, "", "", "", 0, 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Grondar", 0, 0, 0, 0, 0, 1, 0, "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), "", 10, 0 },
                    { 2, 0, "", "", 0, 0, 10, 0, "", 10, 0, 2, 10, 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), 10, 0, 10, 0, 0, "", "", "", 0, 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Zander", 0, 0, 0, 0, 0, 2, 0, "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), "", 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ClassId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action.", "Rage", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) },
                    { 2, 1, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), "While you are not wearing any armor, your AC equals 10 + your Dexterity modifier + your Constitution modifier.", "Unarmored Defense", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) },
                    { 3, 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), "You can inspire others through stirring words or music. As a bonus action, you can choose one creature within 60 feet.", "Bardic Inspiration", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) },
                    { 4, 2, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music.", "Spellcasting", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) },
                    { 5, 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), "Choose a divine domain, such as Life or Tempest, that grants you domain spells and other features.", "Divine Domain", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) },
                    { 6, 3, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), "At 2nd level, you gain the ability to channel divine energy directly from your deity.", "Channel Divinity", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) },
                    { 7, 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages.", "Druidic", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) },
                    { 8, 4, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.", "Spellcasting", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) },
                    { 9, 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), "You adopt a particular style of fighting as your specialty. Choose one of the following options.", "Fighting Style", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) },
                    { 10, 5, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), "You have a limited well of stamina that you can draw on to protect yourself from harm.", "Second Wind", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) },
                    { 11, 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), "While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", "Unarmored Defense", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) },
                    { 12, 6, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons.", "Martial Arts", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) },
                    { 13, 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears.", "Divine Sense", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) },
                    { 14, 7, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest.", "Lay on Hands", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) },
                    { 15, 8, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.", "Favored Enemy", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) },
                    { 16, 8, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "You are a master of navigating the natural world and have a deep understanding of the terrain.", "Natural Explorer", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) },
                    { 17, 9, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "Beginning at 1st level, you know how to strike subtly and exploit a foe's distraction.", "Sneak Attack", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) },
                    { 18, 9, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "During your rogue training, you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages.", "Thieves' Cant", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) },
                    { 19, 10, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), "Choose a sorcerous origin, which describes the source of your innate magical power.", "Sorcerous Origin", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) },
                    { 20, 10, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic.", "Spellcasting", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) },
                    { 21, 11, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), "At 1st level, you have struck a bargain with an otherworldly being of your choice.", "Otherworldly Patron", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) },
                    { 22, 11, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), "Your arcane research and the magic bestowed on you by your patron have given you facility with spells.", "Pact Magic", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) },
                    { 23, 12, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520), "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.", "Spellcasting", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520) },
                    { 24, 12, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520), "You have learned to regain some of your magical energy by studying your spellbook.", "Arcane Recovery", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520) }
                });

            migrationBuilder.InsertData(
                table: "CharacterAlly",
                columns: new[] { "AllyId", "CharacterId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterEnemy",
                columns: new[] { "CharacterId", "EnemyId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterFeature",
                columns: new[] { "CharacterId", "FeatureId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CharacterGuild",
                columns: new[] { "CharacterId", "GuildId", "JoinedOn" },
                values: new object[,]
                {
                    { 1, 1077311704985239684L, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(690) },
                    { 2, 1077311704985239684L, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(690) }
                });

            migrationBuilder.InsertData(
                table: "CharacterItem",
                columns: new[] { "CharacterId", "ItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterOrganization",
                columns: new[] { "CharacterId", "OrganizationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterSpell",
                columns: new[] { "CharacterId", "SpellId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterTrait",
                columns: new[] { "CharacterId", "TraitId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterAlly",
                keyColumns: new[] { "AllyId", "CharacterId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterEnemy",
                keyColumns: new[] { "CharacterId", "EnemyId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterFeature",
                keyColumns: new[] { "CharacterId", "FeatureId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterFeature",
                keyColumns: new[] { "CharacterId", "FeatureId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "CharacterItem",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterItem",
                keyColumns: new[] { "CharacterId", "ItemId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterOrganization",
                keyColumns: new[] { "CharacterId", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterOrganization",
                keyColumns: new[] { "CharacterId", "OrganizationId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSpell",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSpell",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterTrait",
                keyColumns: new[] { "CharacterId", "TraitId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterTrait",
                keyColumns: new[] { "CharacterId", "TraitId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2);
        }
    }
}
