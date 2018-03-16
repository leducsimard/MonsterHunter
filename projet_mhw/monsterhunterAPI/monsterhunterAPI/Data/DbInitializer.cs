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
            var element35 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 420,
                Name = "Poison"
            });
            var decoration35 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 720,
                DecorationSlotTable = decoration35,
                Element = element35,
                Name = "Datura Blaze I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[35]
            });
            var element36 = context.Elements.Add(new Element {
                Active = true,
                Attack = 480,
                Name = "Poison"
            });
            var decoration36 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = decoration36,
                Element = element36,
                Name = "Datura Blaze II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[36]
            });
            var element37 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 540,
                Name = "Poison"
            });
            var decoration37 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 816,
                DecorationSlotTable = decoration37,
                Element = element37,
                Name = "Datura Blaze III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[37]
            });
            var element38 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = "Fire"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 10,
                Attack = 672,
                DecorationSlotTable = null,
                Element = element38,
                Name = "Flame Blade I",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[38]
            });
            var element39 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = "Fire"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 10,
                Attack = 720,
                DecorationSlotTable = null,
                Element = element39,
                Name = "Flame Blade II",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[39]
            });
            var element40 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = "Fire"
            });
            var decoration40 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 768,
                DecorationSlotTable = decoration40,
                Element = element40,
                Name = "Red Wing",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[40]
            });
            var element41 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = "Fire"
            });
            var decoration41 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 816,
                DecorationSlotTable = decoration41,
                Element = element41,
                Name = "Blue Wing",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[41]
            });
            var element42 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Fire"
            });
            var decoration42 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 912,
                DecorationSlotTable = decoration42,
                Element = element42,
                Name = "Rathalos Glinsword",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[42]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 480,
                DecorationSlotTable = null,
                Element = null,
                Name = "Bone Blade I",
                Rarity = "1",
                Sharpness = sharpnessesGreatSwords[43]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 528,
                DecorationSlotTable = null,
                Element = null,
                Name = "Bone Blade II",
                Rarity = "1",
                Sharpness = sharpnessesGreatSwords[44]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 576,
                DecorationSlotTable = null,
                Element = null,
                Name = "Bone Blade III",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[45]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 672,
                DecorationSlotTable = null,
                Element = null,
                Name = "Bone Slasher I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[46]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 720,
                DecorationSlotTable = null,
                Element = null,
                Name = "Bone Slasher II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[47]
            });
            var decoration48 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = decoration48,
                Element = null,
                Name = "Bone Slasher III",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[48]
            });
            var element49 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = "Ice"
            });
            var decoration49 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Defense = 10,
                Attack = 816,
                DecorationSlotTable = decoration49,
                Element = element49,
                Name = "Giant Jawblade I",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[49]
            });
            var element50 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Ice"
            });
            var decoration50 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 912,
                DecorationSlotTable = decoration50,
                Defense = 10,
                Element = element50,
                Name = "Giant Jawblade II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[50]
            });
            var element51 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Dragon"
            });
            var decoration51 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 912,
                DecorationSlotTable = decoration51,
                Defense = 0,
                Element = element51,
                Name = "Hazal Kys",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[51]
            });
            var element52 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Dragon"
            });
            var decoration52 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 960,
                DecorationSlotTable = decoration52,
                Defense = 0,
                Element = element52,
                Name = "Leviathan's Fury",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[52]
            });
            var element53 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Fire"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -30,
                Attack = 720,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element53,
                Name = "Flammenzahn",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[53]
            });
            var element54 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Fire"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -30,
                Attack = 864,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element54,
                Name = "Flammenzahn+",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[54]
            });
            var element55 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = "Fire"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -30,
                Attack = 1008,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element55,
                Name = "Gnashing Flammenzahn",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[55]
            });
            var element56 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = "Water"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 576,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element56,
                Name = "Aqua Slasher I",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[56]
            });
            var element57 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = "Water"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 624,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element57,
                Name = "Aqua Slasher II",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[57]
            });
            var element58 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = "Water"
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 672,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element58,
                Name = "Aqua Slasher III",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[58]
            });
            var element59 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = "Water"
            });
            var decoration59 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = decoration59,
                Defense = 0,
                Element = element59,
                Name = "Water Golum I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[59]
            });
            var element60 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = "Water"
            });
            var decoration60 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 816,
                DecorationSlotTable = decoration60,
                Defense = 0,
                Element = element60,
                Name = "Water Golum II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[60]
            });
            var element61 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = "Water"
            });
            var decoration61 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 912,
                DecorationSlotTable = decoration61,
                Defense = 0,
                Element = element61,
                Name = "Water Golum III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[61]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 624,
                DecorationSlotTable = null,
                Defense = 10,
                Element = null,
                Name = "Carapace Buster I",
                Rarity = "2",
                Sharpness = sharpnessesGreatSwords[62]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 672,
                DecorationSlotTable = null,
                Defense = 10,
                Element = null,
                Name = "Carapace Buster II",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[63]
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 720,
                DecorationSlotTable = null,
                Defense = 10,
                Element = null,
                Name = "Carapace Buster III",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[64]
            });
            var element65 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 270,
                Name = "Paralysis"
            });
            var decoration65 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 816,
                DecorationSlotTable = decoration65,
                Defense = 15,
                Element = element65,
                Name = "Barroth Shredder I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[65]
            });
        }
    }
}