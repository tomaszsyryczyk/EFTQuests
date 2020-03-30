using System;
using System.Net;
using Autofac;
using DataExtraction.Logic;

namespace DataExtraction
{
    class Program
    {
        protected static IContainer Container;
        static void Main(string[] args)
        {
           AutofacInit();
        }

        static void AutofacInit()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<ApplicationAutofacModule>();
            builder.RegisterModule<AutofacModule>();

            Container = builder.Build();
        }
    }
}
