using Autofac;
using XStoreApp.Autofac;

namespace XStore.Droid
{
    public class Setup:AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);
        }
    }
}