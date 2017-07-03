using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Xamarin.Forms;
using Module = Autofac.Module;
using System.Reflection;
using CoreProject.Services;
using XamarinApp.Services;

namespace XamarinApp.MainMasterModule
{
   public class MainMasterModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            //common registration to resolve all classes and interfaces
            builder.RegisterAssemblyTypes(typeof(MainMasterModule).
                GetTypeInfo().Assembly).
                AsImplementedInterfaces().AsSelf();

            builder.RegisterGeneric(typeof(ValidationService<>)).As(typeof(IValidationService<>));

            builder.RegisterInstance<Func<Page>>(()=>((NavigationPage)Application.Current.MainPage).CurrentPage);
        }
    }
}
