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

            context.SaveChanges();
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