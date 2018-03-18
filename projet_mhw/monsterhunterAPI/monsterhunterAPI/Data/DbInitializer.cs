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

            prepareGreatSwords(context, SharpnessesGreatSword);
            prepareLongSwords(context, SharpnessesLongSword);

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
                Name = ElementType.Poison,
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
                Name = ElementType.Poison
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
                Name = ElementType.Poison
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
                Name = ElementType.Dragon
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
                Name = ElementType.Dragon
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
                Name = ElementType.Thunder
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
                Name = ElementType.Thunder
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
                Name = ElementType.Thunder
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
                Name = ElementType.Thunder
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
                Name = ElementType.Thunder
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Paralysis
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
                Name = ElementType.Paralysis
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
                Name = ElementType.Paralysis
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
                Name = ElementType.Paralysis
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
                Name = ElementType.Paralysis
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Poison
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
                Name = ElementType.Poison
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
                Name = ElementType.Poison
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
                Name = ElementType.Poison
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
            var element36 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 480,
                Name = ElementType.Poison
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
                Name = ElementType.Poison
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Ice
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
                Name = ElementType.Ice
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
                Name = ElementType.Dragon
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
                Name = ElementType.Dragon
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Fire
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
                Name = ElementType.Water
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
                Name = ElementType.Water
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
                Name = ElementType.Water
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
                Name = ElementType.Water
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
                Name = ElementType.Water
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
                Name = ElementType.Water
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
                Name = ElementType.Paralysis
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
            var element66 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 330,
                Name = ElementType.Paralysis
            });
            var decoration66 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 864,
                DecorationSlotTable = decoration66,
                Defense = 15,
                Element = element66,
                Name = "Barroth Shredder II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[66]
            });
            var element67 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 390,
                Name = ElementType.Paralysis
            });
            var decoration67 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 960,
                DecorationSlotTable = decoration67,
                Defense = 15,
                Element = element67,
                Name = "Barroth Shredder III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[67]
            });
            var element68 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Sleep
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 624,
                DecorationSlotTable = null,
                Defense = 15,
                Element = element68,
                Name = "Spiked Blade I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[68]
            });
            var element69 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = ElementType.Sleep
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 672,
                DecorationSlotTable = null,
                Defense = 15,
                Element = element69,
                Name = "Spiked Blade II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[69]
            });
            var element70 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Sleep
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = null,
                Defense = 20,
                Element = element70,
                Name = "Radobaan Slab I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[70]
            });
            var element71 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Sleep
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 816,
                DecorationSlotTable = null,
                Defense = 20,
                Element = element71,
                Name = "Radobaan Slab II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[71]
            });
            var element72 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Sleep
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 912,
                DecorationSlotTable = null,
                Defense = 20,
                Element = element72,
                Name = "Radobaan Slab III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[72]
            });
            var element73 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Dragon
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 480,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element73,
                Name = "Dragonbone Cleaver I",
                Rarity = "3",
                Sharpness = sharpnessesGreatSwords[73]
            });
            var element74 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = ElementType.Dragon
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 576,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element74,
                Name = "Dragonbone Cleaver II",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[74]
            });
            var element75 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 420,
                Name = ElementType.Dragon
            });
            var decoration75 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = decoration75,
                Defense = 0,
                Element = element75,
                Name = "Dragonbone Cleaver III",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[75]
            });
            var element76 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 390,
                Name = ElementType.Thunder
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 528,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element76,
                Name = "Thundersword",
                Rarity = "4",
                Sharpness = sharpnessesGreatSwords[76]
            });
            var element77 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 480,
                Name = ElementType.Thunder
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 720,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element77,
                Name = "Kirin Thundersword",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[77]
            });
            var element78 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 540,
                Name = ElementType.Thunder
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 768,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element78,
                Name = "King Thundersword",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[78]
            });
            var element79 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = ElementType.Blast
            });
            var decoration79 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 768,
                DecorationSlotTable = decoration79,
                Defense = 20,
                Element = element79,
                Name = "Magda Potestas I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[79]
            });
            var element80 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 420,
                Name = ElementType.Blast
            });
            var decoration80 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = -20,
                Attack = 1056,
                DecorationSlotTable = decoration80,
                Defense = 20,
                Element = element80,
                Name = "Magda Potestas II",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[80]
            });
            var element81 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 90,
                Name = ElementType.Dragon
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 10,
                Attack = 480,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element81,
                Name = "Blacksteel Chopper I",
                Rarity = "5",
                Sharpness = sharpnessesGreatSwords[81]
            });
            var element82 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Dragon
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 10,
                Attack = 576,
                DecorationSlotTable = null,
                Defense = 0,
                Element = element82,
                Name = "Blacksteel Chopper II",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[82]
            });
            var element83 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Ice
            });
            var decoration83 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 816,
                DecorationSlotTable = decoration83,
                Defense = 0,
                Element = element83,
                Name = "Icesteel Edge",
                Rarity = "7",
                Sharpness = sharpnessesGreatSwords[83]
            });
            var element84 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Ice
            });
            var decoration84 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 864,
                DecorationSlotTable = decoration84,
                Defense = 0,
                Element = element84,
                Name = "Daora's Decimator",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[84]
            });
            var element85 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Dragon
            });
            var decoration85 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3,
                DecorationSlot_2 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 15,
                Attack = 816,
                DecorationSlotTable = decoration85,
                Defense = 0,
                Element = element85,
                Name = "Xeno Maliq",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[85]
            });
            var element86 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = ElementType.Blast
            });
            var decoration86 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 864,
                DecorationSlotTable = decoration86,
                Defense = 20,
                Element = element86,
                Name = "Wyvern Jawblade",
                Rarity = "6",
                Sharpness = sharpnessesGreatSwords[86]
            });
            var element87 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 330,
                Name = ElementType.Blast
            });
            var decoration87 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.GreatSwords.Add(new GreatSword
            {
                Affinity = 0,
                Attack = 960,
                DecorationSlotTable = decoration87,
                Defense = 20,
                Element = element87,
                Name = "Great Wyvern Jawblade",
                Rarity = "8",
                Sharpness = sharpnessesGreatSwords[87]
            });
        }

        private void prepareLongSwords(ApplicationDbContext context, List<Sharpness> sharnessesLongSwords)
        {
            context.LongSwords.Add(new LongSword
            {
                Attack = 264,
                Affinity = 0,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Iron Katana I",
                Rarity = "1",
                Sharpness = sharnessesLongSwords[0]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 297,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Iron Katana II",
                Rarity = "1",
                Sharpness = sharnessesLongSwords[1]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 330,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Iron Katana III",
                Rarity = "2",
                Sharpness = sharnessesLongSwords[2]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 363,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Iron Grace I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[3]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 429,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Iron Grace II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[4]
            });
            var element5 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 120,
                Name = ElementType.Water
            });
            var deco5 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 462,
                DecorationSlotTable = deco5,
                Defense = 0,
                Element = element5,
                Name = "Iron Grace III",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[5]
            });
            var ele6 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 150,
                Name = ElementType.Water
            });
            var deco6 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 528,
                DecorationSlotTable = deco6,
                Element = ele6,
                Defense = 0,
                Name = "Iron Gospel I",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[6]
            });
            var ele7 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 180,
                Name = ElementType.Water
            });
            var deco7 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 594,
                DecorationSlotTable = deco7,
                Defense = 0,
                Element = ele7,
                Name = "Iron Gospel II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[7]
            });
            var ele8 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 90,
                Name = ElementType.Dragon
            });
            var deco8 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 627,
                DecorationSlotTable = deco8,
                Defense = 0,
                Element = ele8,
                Name = "Nergal Reaver",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[8]
            });
            var deco9 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            var ele9 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 693,
                Affinity = 0,
                DecorationSlotTable = deco9,
                Defense = 0,
                Element = ele9,
                Name = "Extermination's Edge",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[9]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 429,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Flickering Glow I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[10]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 0,
                Attack = 462,
                DecorationSlotTable = null,
                Defense = 0,
                Element = null,
                Name = "Flickering Glow II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[11]
            });
            var ele12 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = ElementType.Thunder
            });
            var deco12 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 528,
                DecorationSlotTable = deco12,
                Element = ele12,
                Name = "Dazzling Flash I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[12]
            });
            var ele13 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 300,
                Name = ElementType.Thunder
            });
            var deco13 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 561,
                DecorationSlotTable = deco13,
                Element = ele13,
                Name = "Dazzling Flash II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[13]
            });
            var ele14 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 360,
                Name = ElementType.Thunder
            });
            var deco14 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 594,
                DecorationSlotTable = deco14,
                Element = ele14,
                Name = "Dazzling Flash",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[14]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 330,
                Name = "First Dance I",
                Rarity = "2",
                Sharpness = sharnessesLongSwords[15]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 363,
                Name = "First Dance II",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[16]
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 429,
                Name = "First Dance III",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[17]
            });
            var ele18 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 210,
                Name = ElementType.Sleep
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 20,
                Attack = 495,
                Element = ele18,
                Name = "Last Dance I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[18]
            });
            var ele19 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = ElementType.Sleep
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 20,
                Attack = 528,
                Element = ele19,
                Name = "Last Dance II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[19]
            });
            var ele20 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 270,
                Name = ElementType.Sleep
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 20,
                Element = ele20,
                Attack = 561,
                Name = "Last Dance III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[20]
            });
            var ele21 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 90,
                Name = ElementType.Fire
            });
            var deco21 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -10,
                Attack = 594,
                DecorationSlotTable = deco21,
                Defense = 25,
                Element = ele21,
                Name = "Brazenridge I",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[21]
            });
            var ele22 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Fire
            });
            var deco22 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3,
                DecorationSlot_2 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -10,
                Attack = 660,
                DecorationSlotTable = deco22,
                Defense = 25,
                Element = ele22,
                Name = "Brazenridge II",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[22]
            });
            var ele23 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Poison
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 363,
                Element = ele23,
                Name = "Wyvern Blade \"Leaf\"",
                Sharpness = sharnessesLongSwords[23]
            });
            var ele24 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Poison
            });
            var deco24 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 495,
                DecorationSlotTable = deco24,
                Element = ele24,
                Name = "Wyvern Blade \"Verde\"",
                Sharpness = sharnessesLongSwords[24]
            });
            var ele25 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = ElementType.Poison
            });
            var deco25 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 627,
                DecorationSlotTable = deco25,
                Element = ele25,
                Name = "Wyvern Blade \"Holly\"",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[25]
            });
            var ele26 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 396,
                Element = ele26,
                Name = "Wyvern Blade \"Fall\"",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[26]
            });
            var ele27 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = ElementType.Fire
            });
            var deco27 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 528,
                DecorationSlotTable = deco27,
                Element = ele27,
                Name = "Wyvern Blade \"Blood\"",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[27]
            });
            var ele28 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Fire
            });
            var deco28 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 561,
                DecorationSlotTable = deco28,
                Element = ele28,
                Name = "Wyvern Blade \"Azure\"",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[28]
            });
            var ele29 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Fire
            });
            var deco29 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 627,
                DecorationSlotTable = deco29,
                Element = ele29,
                Name = "Wyvern Blade \"Indigo\"",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[29]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 297,
                Name = "Bone Shotel I",
                Rarity = "1",
                Sharpness = sharnessesLongSwords[30]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 330,
                Name = "Bone Shotel II",
                Rarity = "1",
                Sharpness = sharnessesLongSwords[31]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 396,
                Name = "Bone Shotel III",
                Rarity = "2",
                Sharpness = sharnessesLongSwords[32]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 429,
                Name = "Hard Bone Shotel I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[33]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 495,
                Name = "Hard Bone Shotel II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[34]
            });
            var ele35 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 210,
                Name = ElementType.Sleep
            });
            var deco35 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 528,
                Element = ele35,
                DecorationSlotTable = deco35,
                Name = "Hard Bone Shotel III",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[35]
            });
            var ele36 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = ElementType.Sleep
            });
            var deco36 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 561,
                Defense = 10,
                DecorationSlotTable = deco36,
                Element = ele36,
                Name = "Bone Reaper I",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[36]
            });
            var ele37 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 270,
                Name = ElementType.Sleep
            });
            var deco37 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 627,
                Defense = 10,
                DecorationSlotTable = deco37,
                Element = ele37,
                Name = "Bone Reaper II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[37]
            });
            var ele38 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Blast
            });
            var deco38 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -10,
                Attack = 561,
                DecorationSlotTable = deco38,
                Element = ele38,
                Name = "Rookslayer Long Sword",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[38]
            });
            var ele39 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Blast
            });
            var deco39 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1,
                DecorationSlot_2 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -10,
                Attack = 660,
                DecorationSlotTable = deco39,
                Element = ele39,
                Name = "Bazel Varga Rookslayer",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[39]
            });
            var ele40 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 462,
                Element = ele40,
                Name = "Blazing Shotel I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[40]
            });
            var ele41 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 528,
                Element = ele41,
                Name = "Blazing Shotel II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[41]
            });
            var ele42 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 594,
                Element = ele42,
                Name = "Anja Scimitar I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[42]
            });
            var ele43 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 660,
                Element = ele43,
                Name = "Anja Scimitar II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[43]
            });
            var ele44 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 390,
                Name = ElementType.Fire
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 693,
                Element = ele44,
                Name = "Anja Scimitar III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[44]
            });
            var ele45 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Water
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 396,
                Element = ele45,
                Name = "Jyura Shotel I",
                Rarity = "2",
                Sharpness = sharnessesLongSwords[45]
            });
            var ele46 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = ElementType.Water
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 429,
                Element = ele46,
                Name = "Jyura Shotel II",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[46]
            });
            var ele47 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Water
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 462,
                Element = ele47,
                Name = "Jyura Shotel III",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[47]
            });
            var ele48 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Water
            });
            var deco48 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 495,
                DecorationSlotTable = deco48,
                Element = ele48,
                Name = "Dipterus I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[48]
            });
            var ele49 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = ElementType.Water
            });
            var deco49 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 561,
                DecorationSlotTable = deco49,
                Element = ele49,
                Name = "Dipterus II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[49]
            });
            var ele50 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = ElementType.Water
            });
            var deco50 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 627,
                DecorationSlotTable = deco50,
                Element = ele50,
                Name = "Dipterus III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[50]
            });
            var ele51 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Dragon
            });
            var deco51 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 627,
                DecorationSlotTable = deco51,
                Element = ele51,
                Name = "Hazak Grosser I",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[51]
            });
            var ele52 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Dragon
            });
            var deco52 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 660,
                DecorationSlotTable = deco52,
                Element = ele52,
                Name = "Hazak Grosser II",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[52]
            });
            var ele53 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Thunder
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 363,
                Element = ele53,
                Name = "Pulsar Shotel I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[53]
            });
            var ele54 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Thunder
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 396,
                Element = ele54,
                Name = "Pulsar Shotel II",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[54]
            });
            var ele55 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = ElementType.Thunder
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 10,
                Attack = 462,
                Element = ele55,
                Name = "Pulsar Shotel III",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[55]
            });
            var ele56 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Thunder
            });
            var deco56 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 528,
                DecorationSlotTable = deco56,
                Element = ele56,
                Name = "Kadachi Fang I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[56]
            });
            var ele57 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Thunder
            });
            var deco57 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 561,
                DecorationSlotTable = deco57,
                Element = ele57,
                Name = "Kadachi Fang II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[57]
            });
            var ele58 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Thunder
            });
            var deco58 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 594,
                DecorationSlotTable = deco58,
                Element = ele58,
                Name = "Kadachi Fang III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[58]
            });
            var ele59 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 210,
                Name = ElementType.Ice
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 429,
                Element = ele59,
                Name = "Glacial Shotel I",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[59]
            });
            var ele60 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 240,
                Name = ElementType.Ice
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 462,
                Element = ele60,
                Name = "Glacial Shotel II",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[60]
            });
            var ele61 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = ElementType.Ice
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 495,
                Element = ele61,
                Name = "Stealer",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[61]
            });
            var ele62 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = ElementType.Ice
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 528,
                Element = ele62,
                Name = "Legia Stealer",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[62]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 396,
                Name = "Dark Shotel I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[63]
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 429,
                Name = "Dark Shotel II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[64]
            });
            var ele65 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 180,
                Name = ElementType.Paralysis
            });
            var deco65 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 462,
                DecorationSlotTable = deco65,
                Element = ele65,
                Name = "Dark Scimitar I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[65]
            });
            var ele66 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 210,
                Name = ElementType.Paralysis
            });
            var deco66 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 495,
                DecorationSlotTable = deco66,
                Element = ele66,
                Name = "Dark Scimitar",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[66]
            });
            var ele67 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 240,
                Name = ElementType.Paralysis
            });
            var deco67 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 528,
                DecorationSlotTable = deco67,
                Element = ele67,
                Name = "Dark Scimitar III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[67]
            });
            var ele68 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 270,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 330,
                Element = ele68,
                Name = "Dragonbone Stabber I",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[68]
            });
            var ele69 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 330,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 363,
                Element = ele69,
                Name = "Dragonbone Stabber II",
                Rarity = "4",
                Sharpness = sharnessesLongSwords[69]
            });
            var ele70 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 420,
                Name = ElementType.Dragon
            });
            var deco70 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 1
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 528,
                DecorationSlotTable = deco70,
                Element = ele70,
                Name = "Dragonbone Stabber III",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[70]
            });
            var ele71 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = ElementType.Blast
            });
            var deco71 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 528,
                DecorationSlotTable = deco71,
                Defense = 20,
                Element = ele71,
                Name = "Magda Facultas I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[71]
            });
            var ele72 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 360,
                Name = ElementType.Blast
            });
            var deco72 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 2
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = -20,
                Attack = 726,
                DecorationSlotTable = deco72,
                Element = ele72,
                Defense = 20,
                Name = "Magda Facultas II",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[72]
            });
            var ele73 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 330,
                Element = ele73,
                Name = "Blacksteel Long Sword I",
                Rarity = "5",
                Sharpness = sharnessesLongSwords[73]
            });
            var ele74 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 150,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 363,
                Element = ele74,
                Name = "Blacksteel Long Sword II",
                Rarity = "6",
                Sharpness = sharnessesLongSwords[74]
            });
            var ele75 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = ElementType.Blast
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 561,
                Element = ele75,
                Name = "Imperial Saber",
                Rarity = "7",
                Sharpness = sharnessesLongSwords[75]
            });
            var ele76 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 300,
                Name = ElementType.Blast
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 627,
                Element = ele76,
                Name = "Imperial Shimmer",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[76]
            });
            var deco77 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3,
                DecorationSlot_2 = 3
            });
            var ele77 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 180,
                Name = ElementType.Dragon
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 15,
                Attack = 594,
                DecorationSlotTable = deco77,
                Element = ele77,
                Name = "Xeno Cypher",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[77]
            });
            var ele78 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 120,
                Name = ElementType.Dragon
            });
            var deco78 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 561,
                DecorationSlotTable = deco78,
                Element = ele78,
                Defense = 20,
                Rarity = "6",
                Name = "Supremacy Blade",
                Sharpness = sharnessesLongSwords[78]
            });
            var ele79 = context.Elements.Add(new Element
            {
                Active = false,
                Attack = 150,
                Name = ElementType.Dragon
            });
            var deco79 = context.DecorationSlotTables.Add(new DecorationSlotTable
            {
                DecorationSlot_1 = 3
            });
            context.LongSwords.Add(new LongSword
            {
                Attack = 693,
                Defense = 20,
                DecorationSlotTable = deco79,
                Element = ele79,
                Name = "Divine Slasher",
                Rarity = "8",
                Sharpness = sharnessesLongSwords[79]
            });
            var ele80 = context.Elements.Add(new Element
            {
                Active = true,
                Attack = 120,
                Name = ElementType.Water
            });
            context.LongSwords.Add(new LongSword
            {
                Affinity = 20,
                Attack = 363,
                Element = ele80,
                Name = "Azure Star Blade",
                Rarity = "3",
                Sharpness = sharnessesLongSwords[80]
            });
        }
    }
}