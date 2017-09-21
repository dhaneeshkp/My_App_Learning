using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Xamarin.Forms;
using Autofac.Core;

namespace XamarinApp
{

    public partial class App : Application
    {

        public class SomeType : IService
        {
            public void DoWork()
            {

            }
        }
        public interface IService
        {
            void DoWork();
        }
        private static IContainer Container { get; set; }
        public App()
        {
            InitializeComponent();


            //var builder = new ContainerBuilder();

            //// Usually you're only interested in exposing the type
            //// via its interface:
            //builder.RegisterType<SomeType>().As<IService>();

            //// However, if you want BOTH services (not as common)
            //// you can say so:
            //builder.RegisterType<SomeType>().AsSelf().As<IService>();

            MainPage = new Mvvm.View.Login.LoginView();
        }
        public void initialize()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IService>();
                writer.DoWork();
            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
