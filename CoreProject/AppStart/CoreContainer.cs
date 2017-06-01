using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CoreProject.Factories;

namespace CoreProject.AppStart
{
public  abstract  class CoreContainer
    {
        public void Run()
        {
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);
            var container= builder.Build();
            var viewFactory = container.Resolve<IViewFactory>();
            RegisterViews(viewFactory);
            ConfigureApplication(container);

        }
        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreModule>();
        }
        protected abstract void RegisterViews(IViewFactory viewFactory);


        protected abstract void ConfigureApplication(IContainer container);
       

      

      
    }
}
