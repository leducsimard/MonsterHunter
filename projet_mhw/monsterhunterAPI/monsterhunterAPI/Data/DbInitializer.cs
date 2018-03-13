using monsterhunterAPI.DTO;
using monsterhunterAPI.Models;
using monsterhunterAPI.Models.ItemProperty;
using monsterhunterAPI.Models.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace monsterhunterAPI.Data
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //Start by initializating Sharpnesses
            var sqlFileSharpnesses = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "Sharpnesses.sql").FirstOrDefault().ToString();
            if (sqlFileSharpnesses != null)
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(sqlFileSharpnesses));
                context.SaveChanges();
            }
            var Sharpnesses = context.Sharpnesses.ToList();
            var SharpnessesGreatSword = Sharpnesses.GetRange(0, 88);
            var SharpnessesDualBlade = Sharpnesses.GetRange(88, 83);
            var SharpnessesLongSword = Sharpnesses.GetRange(171, 82);
            var SharpnessesSwordShield = Sharpnesses.GetRange(253, 91);
            var SharpnessesHammer = Sharpnesses.GetRange(344, 84);
            var SharpnessesHuntingHorn = Sharpnesses.GetRange(428, 85);
            var SharpnessesLance = Sharpnesses.GetRange(513, 84);
            var SharpnessesGunlance = Sharpnesses.GetRange(597, 79);
            var SharpnessesSwitchAxe = Sharpnesses.GetRange(676, 79);
            var SharpnessesChargeBlade = Sharpnesses.GetRange(755, 75);
            var SharpnessesInsectGlaive = Sharpnesses.GetRange(830, 81);

            context.SaveChanges();
        }

        private void prepareGreatSwords(ApplicationDbContext context, List<Sharpness> sharpnessesGreatSwords)
        {
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 384,
                DecorationSlotTable = null,
                Element = null,
                Name = "Buster Blade I",
                Rarity = "1",
                Sharpness = sharpnessesGreatSwords[0]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 432,
                DecorationSlotTable = null,
                Element = null,
                Name = "Buster Blade II",
                Rarity = "1",
                Sharpness = sharpnessesGreatSwords[1]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 480,
                DecorationSlotTable = null,
                Element = null,
                Name = "Buster Sword III",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[2]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 576,
                DecorationSlotTable = null,
                Element = null,
                Name = "Buster Blade I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[3]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 624,
                DecorationSlotTable = null,
                Element = null,
                Name = "Buster Blade II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[4]
            });
            var element5 = context.Elements.Add(new Element
            {
                Attack = 240,
                Name = "Poison",
                Active = false
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 672,
                DecorationSlotTable = null,
                Element = element5,
                Name = "Buster Blade III",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[5]
            });
            var element6 = context.Elements.Add(new Element
            {
                Attack = 330,
                Active = false,
                Name = "Poison"
            });
            var decoration6 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 720,
                DecorationSlotTable = decoration6,
                Element = element6,
                Name = "Chrome Razor I",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[6]
            });
            var element7 = context.Elements.Add(new Element
            {
                Attack = 420,
                Active = false,
                Name = "Poison"
            });
            var decoration7 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 864,
                DecorationSlotTable = decoration7,
                Element = element7,
                Name = "Chrome Razor II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[7]
            });
            var element8 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = "Dragon"
            });
            var decoration8 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 912,
                DecorationSlotTable = decoration8,
                Element = element8,
                Name = "Nergal Judicator",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[8]
            });
            var element9 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = "Dragon"
            });
            var decoration9 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 1008,
                DecorationSlotTable = decoration9,
                Element = element9,
                Name = "Purgation's Atrocity",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[9]
            });
            var element10 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = "Thunder"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 528,
                DecorationSlotTable = null,
                Element = element10,
                Name = "Thunder Blade I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[10]
            });
            var element11 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = "Thunder"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 624,
                DecorationSlotTable = null,
                Element = element11,
                Name = "Thunder Blade II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[11]
            });
            var element12 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = "Thunder"
            });
            var decoration12 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 672,
                DecorationSlotTable = decoration12,
                Element = element12,
                Name = "Lightning Punisher I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[12]
            });
            var element13 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = "Thunder"
            });
            var decoration13 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 816,
                DecorationSlotTable = decoration13,
                Element = element13,
                Name = "Lightning Punisher II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[13]
            });
            var element14 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Thunder"
            });
            var decoration14 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 912,
                DecorationSlotTable = decoration14,
                Element = element14,
                Name = "Lightning Punisher III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[14]
            });
            var element15 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Ice"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 576,
                DecorationSlotTable = null,
                Element = element15,
                Name = "Freeze Blade I",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[15]
            });
            var element16 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = "Ice"
            });
            var decoration16 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 624,
                DecorationSlotTable = decoration16,
                Element = element16,
                Name = "Freeze Blade II",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[16]
            });
            var element17 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = "Ice"
            });
            var decoration17 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 720,
                DecorationSlotTable = decoration17,
                Element = element17,
                Name = "Frost Blade I",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[17]
            });
            var element18 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 390,
                Name = "Ice"
            });
            var decoration18 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 768,
                DecorationSlotTable = decoration18,
                Element = element18,
                Name = "Frost Blade II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[18]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 528,
                DecorationSlotTable = null,
                Element = null,
                Name = "Jagras Blade I",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[19]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 576,
                DecorationSlotTable = null,
                Element = null,
                Name = "Jagras Blade II",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[20]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 672,
                DecorationSlotTable = null,
                Element = null,
                Name = "Jagras Blade III",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[21]
            });
            var decoration22 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            var element22 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 210,
                Name = "Ice"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 816,
                DecorationSlotTable = decoration22,
                Element = element22,
                Name = "Jagras Hacker I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[22]
            });
            var decoration23 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2,
                DecorationSlot_2 = 2
            });
            var element23 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = "Ice"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 864,
                DecorationSlotTable = decoration23,
                Element = element23,
                Name = "Jagras Hacker II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[23]
            });
            var element24 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 300,
                Name = "Ice"
            });
            var decoration24 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3,
                DecorationSlot_2 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Attack = 912,
                DecorationSlotTable = decoration24,
                Element = element24,
                Name = "Jagras Hacker III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[24]
            });
            var element25 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = "Paralysis"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 528,
                DecorationSlotTable = null,
                Element = element25,
                Name = "Girros Blade I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[25]
            });
            var element26 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Paralasys"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 624,
                DecorationSlotTable = null,
                Element = element26,
                Name = "Girros Blade II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[26]
            });
            var element27 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = "Paralysis"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 20,
                Attack = 672,
                DecorationSlotTable = null,
                Element = element27,
                Name = "Malady's Kiss I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[27]
            });
            var element28 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = "Paralysis"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 20,
                Attack = 720,
                DecorationSlotTable = null,
                Element = element28,
                Name = "Malady's Kiss II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[28]
            });
            var element29 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 450,
                Name = "Paralysis"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 20,
                Attack = 768,
                DecorationSlotTable = null,
                Element = element29,
                Name = "Malady's Kiss III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[29]
            });
            var element30 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = "Fire"
            });
            var decoration30 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = decoration30,
                Element = element30,
                Name = "Lava Blaze I",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[30]
            });
            var element31 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = "Fire"
            });
            var decoration31 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2,
                DecorationSlot_2 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 864,
                DecorationSlotTable = decoration31,
                Element = element31,
                Name = "Lava Blaze II",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[31]
            });
            var element32 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Poison"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 528,
                DecorationSlotTable = null,
                Element = element32,
                Name = "Blooming Blade I",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[32]
            });
            var element33 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Poison"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 576,
                DecorationSlotTable = null,
                Element = element33,
                Name = "Blooming Blade II",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[33]
            });
            var element34 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = "Poison"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 624,
                DecorationSlotTable = null,
                Element = element34,
                Name = "Blooming Blade III",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[34]
            });
        }

        private DecorationSlotTable returnDecorationSlotTable(DecorationSlotTableCreationDTO decorationSlotTableCreationDTO)
        {
            var decorationSlotTable = new DecorationSlotTable();
            decorationSlotTable.DecorationSlot_1 = decorationSlotTableCreationDTO.decoration_1_level;
            decorationSlotTable.DecorationSlot_2 = decorationSlotTableCreationDTO.decoration_2_level;
            decorationSlotTable.DecorationSlot_3 = decorationSlotTableCreationDTO.decoration_3_level;

            return decorationSlotTable;
        }
    }
}