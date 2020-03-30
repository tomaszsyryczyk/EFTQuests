using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Core.Registration;
using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.PageHtmlProvider;

namespace DataExtraction.Logic
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<PageHtmlProvider.PageHtmlProvider>().As<IPageHtmlProvider>().SingleInstance();
            builder.RegisterType<MerchantParser>().As<IMerchantParser>().InstancePerDependency();
        }
    }
}
