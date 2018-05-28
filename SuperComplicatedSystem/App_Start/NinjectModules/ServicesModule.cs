using Ninject.Modules;
using SuperComplicatedSystem.Services;
using SuperComplicatedSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperComplicatedSystem.App_Start.NinjectModules
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEquipmentService>().To<EquipmentService>();
        }
    }
}