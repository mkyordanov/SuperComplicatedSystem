namespace SuperCompilcatedSystem.Data.Migrations
{
    using SuperComplicatedSystem.Models;
    using SuperComplicatedSystem.Models.Enum;
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

            var pc1 = new PC() { name = "PC1",components= new List<Components>()};
            var pc2 = new PC() { name = "PC2",components= new List<Components>()};
            var pc3 = new PC() { name = "PC3",components= new List<Components>()};
            var pc4 = new PC() { name = "PC4",components= new List<Components>()};

            var c1 = new Components() { Type = ComponentTypes.CPU, Model = "Intel",PCs= new List<PC>() };
            var c2 = new Components() { Type = ComponentTypes.CPU, Model = "AMD",PCs= new List<PC>() };
            var c3 = new Components() { Type = ComponentTypes.GPU, Model = "NVIDIA",PCs= new List<PC>() };
            var c4 = new Components() { Type = ComponentTypes.GPU, Model = "ASUS",PCs= new List<PC>() };
            var c5 = new Components() { Type = ComponentTypes.MotherBoard, Model = "Gigabyte",PCs= new List<PC>() };
            var c6 = new Components() { Type = ComponentTypes.MotherBoard, Model = "ASROCK",PCs= new List<PC>() };
            var c7 = new Components() { Type = ComponentTypes.RAM, Model = "KINGSTON",PCs= new List<PC>() };
            var c8 = new Components() { Type = ComponentTypes.RAM, Model = "Corsair", PCs= new List<PC>() };

            pc1.components.Add(c1);
            pc1.components.Add(c3);
            pc1.components.Add(c5);
            pc1.components.Add(c7);

            pc2.components.Add(c2);
            pc2.components.Add(c4);
            pc2.components.Add(c6);
            pc2.components.Add(c8);

            pc3.components.Add(c1);
            pc3.components.Add(c4);
            pc3.components.Add(c5);
            pc3.components.Add(c8);

            pc4.components.Add(c2);
            pc4.components.Add(c3);
            pc4.components.Add(c6);
            pc4.components.Add(c7);

            c1.PCs.Add(pc1);
            c1.PCs.Add(pc3);

            c2.PCs.Add(pc2);
            c2.PCs.Add(pc4);

            c3.PCs.Add(pc1);
            c3.PCs.Add(pc4);

            c4.PCs.Add(pc2);
            c4.PCs.Add(pc3);

            context.PC.AddOrUpdate(pc1,pc2,pc3,pc4);
            context.Components.AddOrUpdate(c1,c2,c3,c4,c5,c6,c7,c8);
            base.Seed(context);
        }
    }
}
