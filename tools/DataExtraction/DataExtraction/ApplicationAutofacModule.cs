using Autofac;

namespace DataExtraction
{
    internal class ApplicationAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<Application>().As<IApplication>().SingleInstance();
        }
    }
}
