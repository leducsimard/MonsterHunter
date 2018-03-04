using monsterhunterAPI.DTO;
using monsterhunterAPI.Models;
using monsterhunterAPI.Models.ItemProperty;
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

            var dtoDecorationSlotTable = new DecorationSlotTableCreationDTO
            {
                decoration_1_level = 1,
                decoration_2_level = 2,
                decoration_3_level = 1
            };

            var weaponTypes = context.WeaponType.AddRange(prepareWeaponType());


            context.SaveChanges();
        }

        private List<WeaponType> prepareWeaponType()
        {
            var listWeaponType = new List<WeaponType>();
            listWeaponType.Add(new WeaponType
            {
                Name = "Great Sword"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Sword & Shield"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Dual Blades"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Long Sword"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Hammer"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Hunting Horn"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Lance"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Gunlance"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Switch Axe"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Charge Blade"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Insect Glaive"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Bow"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Light Bowgun"
            });
            listWeaponType.Add(new WeaponType
            {
                Name = "Heavy Bowgun"
            });
            return listWeaponType;
        }

        private Weapon prepareWeapon(string name)
        {
            var weapon = new Weapon
            {
                Name = name,
                Sharpness = null,
                DecorationSlotTable = null,
                WeaponType = null
            };
            /*
            weapon.Sharpness = returnSharpness(weapon, sharpnessCreationDTO);
            weapon.WeaponType = returnWeaponType(weapon, weaponTypeName);
            weapon.DecorationSlotTable = returnDecorationSlotTable(decorationSlotTableCreationDTO);
            */
            return weapon;
        }

        private Sharpness returnSharpness(SharpnessCreationDTO sharpnessCreationDTO)
        {
            return new Sharpness
            {
                RedSharpness = sharpnessCreationDTO.RedSharpness,
                OrangeSharpness = sharpnessCreationDTO.OrangeSharpness,
                YellowSharpness = sharpnessCreationDTO.YellowSharpness,
                GreenSharpness = sharpnessCreationDTO.GreenSharpness,
                BlueSharpness = sharpnessCreationDTO.BlueSharpness,
                WhiteSharpness = sharpnessCreationDTO.WhiteSharpness
            };
        }

        private WeaponType returnWeaponType(Weapon weapon, string name)
        {
            return new WeaponType
            {
                Name = name
            };
        }

        private DecorationSlotTable returnDecorationSlotTable(DecorationSlotTableCreationDTO decorationSlotTableCreationDTO)
        {
            var decorationSlotTable = new DecorationSlotTable();
            decorationSlotTable.DecorationSlot_1 = returnDecorationSlot(decorationSlotTableCreationDTO.decoration_1_level);
            decorationSlotTable.DecorationSlot_2 = returnDecorationSlot(decorationSlotTableCreationDTO.decoration_2_level);
            decorationSlotTable.DecorationSlot_3 = returnDecorationSlot(decorationSlotTableCreationDTO.decoration_3_level);

            return decorationSlotTable;
        }

        private DecorationSlot returnDecorationSlot(int level)
        {
            return new DecorationSlot
            {
                Level = level
            };
        }
    }
}