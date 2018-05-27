using Bytes2you.Validation;
using SuperCompilcatedSystem.Data;
using System.Data.Entity;
using ToDoList.Data.UnitOfWork;

namespace SuperComplicatedSystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;
        public UnitOfWork(SuperComplicateSystemContext context)
        {
            Guard.WhenArgument(context, "context").IsNull().Throw();
            this.context = context;
        }
        public void Commit()
        {
            this.context.SaveChanges();
        }

    }
}
