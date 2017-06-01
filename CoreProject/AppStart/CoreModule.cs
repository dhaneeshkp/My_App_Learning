using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Module = Autofac.Module;
using Xamarin.Forms;
using System.Reflection;

namespace CoreProject.AppStart
{
   public class CoreModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Comon registration to resolve all interface with implemented classes
            builder.RegisterAssemblyTypes(typeof(CoreModule).GetTypeInfo().Assembly).AsImplementedInterfaces().SingleInstance();
            //default page resolver
            builder.RegisterInstance<Func<Page>>(() =>
            {
                var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
                var page = masterDetailPage != null ? masterDetailPage.Detail : Application.Current.MainPage;
                //check if page is navigation page
                var navigationPage = page as IPageContainer<Page>;
                return navigationPage != null ? navigationPage.CurrentPage : page;
            });
            //current page Proxy
          //  builder.RegisterType<PageProxy>().As<Ipage>().SingleInstance();
        }
    }
}
