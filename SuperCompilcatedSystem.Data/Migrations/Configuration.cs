namespace SuperCompilcatedSystem.Data.Migrations
{
    using SuperComplicatedSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperCompilcatedSystem.Data.SuperComplicateSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SuperComplicateSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var type1 = new equipmentType() { name = "PC" };
            //var type2 = new equipmentType() { name = "Video Card" };
            //var type3 = new equipmentType() { name = "Processor" };
            //var type4 = new equipmentType() { name = "Video Card Processor" };

            //var eq = new Equipment() { name = "Dell", equipmentType = type1 };
            //var eq1 = new Equipment() { name = "Lenovo", equipmentType = type1 };
            //var eq2 = new Equipment() { name = "Pravetz", equipmentType = type1 };

            //var eq3 = new Equipment() { name = "NVIDIA Riva 128", equipmentType = type2 };
            //var eq4 = new Equipment() { name = "3Dfx Vodoo", equipmentType = type2 };
            //var eq5 = new Equipment() { name = "ATI Rage", equipmentType = type2 };

            //var eq6 = new Equipment() { name = "440LX c", equipmentType = type4 };
            //var eq7 = new Equipment() { name = "DAC", equipmentType = type4 };
            //var eq8 = new Equipment() { name = "MACH 64", equipmentType = type4 };

            //var eq9 = new Equipment() { name = "Intel", equipmentType = type3 };
            //var eq10 = new Equipment() { name = "AMD", equipmentType = type3 };
            //var eq11 = new Equipment() { name = "Intel", equipmentType = type3 };

            //context.EquipmentType.AddOrUpdate(type1, type2, type3, type4);
            //context.Equipment.AddOrUpdate(eq, eq1, eq2, eq3, eq4, eq5, eq6, eq7, eq8, eq9, eq10, eq11);
            //base.Seed(context);
        }
    }
}
