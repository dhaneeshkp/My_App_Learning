//using CoreProject.AppStart;
//using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Autofac;
using CoreProject.Factories;
using XamarinApp.MainMasterModule;
using CoreProject.AppStart;

namespace XamarinApp
{
    public class XamarinApp : CoreContainer
    {
        private readonly Application _application;
        public XamarinApp(Application application)
        {
            _application = application;
        }
        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<MainMasterModule.MainMasterModule>();
        }

        protected override void ConfigureApplication(IContainer container)
        {

        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<Mvvm.ViewModel.Login.LoginViewModel, Mvvm.View.Login.LoginView>();
        }
    }
}
