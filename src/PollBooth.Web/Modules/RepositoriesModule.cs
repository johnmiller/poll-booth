using System.Data.Entity;
using Ninject.Modules;
using Ninject.Web.Common;
using PollBooth.Domain.Repositories;

namespace PollBooth.Web.Modules
{
    public class RepositoriesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<PollBoothContext>().InRequestScope();
            Bind(typeof (IRepository<>)).To(typeof (Repository<>));
        }
    }
}