using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using Deadfile.Eyeglass.Interfaces;
using Prism.Events;
using Deadfile.Eyeglass.Messaging;
using Windows.UI.Popups;

namespace Deadfile.Eyeglass.ViewModels
{
    public class ShellViewModel : ViewModelBase, IShellViewModel
    {
        public bool IsPaneOpen
        {
            get { return isPaneOpen; }

            set { SetProperty(ref isPaneOpen, value); }
        }

        public ICommand SplitViewCommand { get; set; }
        public ICommand HomePageCommand { get; set; }
        public ICommand ClientsPageCommand { get; set; }

        private readonly INavigationService navigationService;
        private bool isPaneOpen;

        readonly IDialogService dialogService;

        public ShellViewModel(INavigationService navigationService, IDialogService dialogService, IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            SplitViewCommand = new DelegateCommand(OnSplitView);
            HomePageCommand = new DelegateCommand(OnHomePage);
            ClientsPageCommand = new DelegateCommand(OnClientsPage);
            eventAggregator.GetEvent<PaneContextChangedEvent>().Subscribe(PaneContextChangedHandler);
            navigationService.Navigate(Experiences.Home.ToString(), null);
        }

        private IDeadfileViewModelBase currentContext;
        private void PaneContextChangedHandler(IDeadfileViewModelBase newContext)
        {
            currentContext = newContext;
        }

        private bool GoHome()
        {
            if (currentContext.CanGoBack)
            {
                if (currentContext.HasChanges)
                {
                    dialogService.ShowChoice("Discard Changes?", "You have changes at the moment, do you wish to discard them?", "Discard", new DelegateCommand(currentContext.DiscardChanges), "Cancel");
                }
                if (!currentContext.HasChanges)
                {
                    while (currentContext.CanGoBack)
                    {
                        navigationService.GoBack();
                    }
                    return true;
                }
                return false;
            }
            return true;
        }

        private void OnHomePage()
        {
            GoHome();
        }

        private void OnClientsPage()
        {
            if (GoHome())
            {
                navigationService.Navigate(Experiences.Clients.ToString(), null);
            }
        }

        private void OnSplitView()
        {
            IsPaneOpen = !IsPaneOpen;
        }

    }
}
