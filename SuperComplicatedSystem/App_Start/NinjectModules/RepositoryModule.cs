using Ninject.Modules;
using Ninject.Web.Common;
using SuperCompilcatedSystem.Data;
using SuperComplicatedSystem.Data.EFRepository;
using SuperComplicatedSystem.Data.UnitOfWork;
using ToDoList.Data.UnitOfWork;

namespace SuperComplicatedSystem.App_Start.NinjectModules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<SuperComplicateSystemContext>().ToSelf().InRequestScope();
            this.Bind(typeof(IEFGenericRepository<>)).To(typeof(EFGenericRepository<>)).InRequestScope();
            this.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
        }
    }
}