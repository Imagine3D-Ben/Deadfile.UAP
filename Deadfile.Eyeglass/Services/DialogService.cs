using Deadfile.Eyeglass.Interfaces;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace Deadfile.Eyeglass.Services
{
    public class DialogService : IDialogService
    {
        public async void ShowMessage(string title, string message)
        {
            await new MessageDialog(title, message).ShowAsync();
        }

        public async void ShowChoice(string title, string message, string yesText, ICommand yesCommand, string noText)
        {
            var dialog = new ContentDialog();
            dialog.Title = title;
            dialog.Content = message;
            dialog.PrimaryButtonText = yesText;
            dialog.PrimaryButtonCommand = yesCommand;
            dialog.SecondaryButtonText = noText;
            dialog.SecondaryButtonCommand = new DelegateCommand(() => { });
            await dialog.ShowAsync();
        }
    }
}
