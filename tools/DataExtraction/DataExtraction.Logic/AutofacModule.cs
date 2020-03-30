using Autofac;
using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.MerchantQuests;
using DataExtraction.Logic.PageHtmlProvider;

namespace DataExtraction.Logic
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            
            builder.RegisterType<GetMerchantsCommandHandler>().As<IGetMerchantsCommandHandler>().InstancePerDependency();
            builder.RegisterType<MerchantParser>().As<IMerchantParser>().InstancePerDependency();
            builder.RegisterType<MerchantPersister>().As<IMerchantPersister>().InstancePerDependency();
            
            builder.RegisterType<MerchantQuestsCommandHandler>().As<IMerchantQuestsCommandHandler>().InstancePerDependency();
            builder.RegisterType<MerchantQuestsPersister>().As<IMerchantQuestsPersister>().InstancePerDependency();
            builder.RegisterType<MerchantQuestsParser>().As<IMerchantQuestsParser>().InstancePerDependency();

            builder.RegisterType<PageHtmlProvider.PageHtmlProvider>().As<IPageHtmlProvider>().SingleInstance();
        }
    }
}
