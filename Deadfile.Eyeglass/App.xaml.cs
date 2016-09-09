using Prism.Events;
using Prism.Unity.Windows;
using Prism.Windows.AppModel;
using Prism.Windows.Navigation;
using Microsoft.Practices.Unity;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;
using System.Globalization;
using Windows.UI.Xaml;
using Prism.Mvvm;
using Windows.UI.Xaml.Controls;
using Deadfile.Eyeglass.Views;
using Deadfile.Eyeglass.Entity;
using Microsoft.EntityFrameworkCore;
using Deadfile.Eyeglass.Services;
using Deadfile.Eyeglass.Interfaces;
using Deadfile.Eyeglass.Repositories;

namespace Deadfile.Eyeglass
{
    [Bindable]
    sealed partial class App : PrismUnityApplication
    {
        IEventAggregator eventAggregator;

        public App() : base()
        {
            using (var db = new DeadfileContext())
            {
                db.Database.Migrate();
            }
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            Window.Current.Activate();

            return Task.FromResult<object>(null);
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            RegisterTypes();
            return base.OnInitializeAsync(args);
        }

        private void RegisterTypes()
        {
            eventAggregator = new EventAggregator();

            Container.RegisterInstance(typeof(INavigationService), NavigationService, new ContainerControlledLifetimeManager());
            Container.RegisterInstance(typeof(ISessionStateService), SessionStateService, new ContainerControlledLifetimeManager());
            Container.RegisterInstance(typeof(IEventAggregator), eventAggregator, new ContainerControlledLifetimeManager());
            Container.RegisterType<IDialogService, DialogService>();
            Container.RegisterType<IDeadfileRepository, DeadfileRepository>();
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(viewType =>
            {
                var viewModelTypeName = string.Format(CultureInfo.InvariantCulture,
                      "Deadfile.Eyeglass.ViewModels.{0}ViewModel, Deadfile.Eyeglass", viewType.Name);
                var viewModelType = Type.GetType(viewModelTypeName);
                return viewModelType;
            });
        }
        protected override UIElement CreateShell(Frame rootFrame)
        {
            var shell = new Shell();
            (shell.Content as SplitView).Content = rootFrame;
            return shell;
        }
    }
}

