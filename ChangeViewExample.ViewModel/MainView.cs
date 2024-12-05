using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using System.Windows.Input;

namespace ChangeViewExample.ViewModel
{
    public class MainView: ReactiveObject
    {
        [Reactive]
        public string Text { get; set; } = "Initial with View Model project";
        public ICommand ChangeViewCommand { get; }

        public MainView()
        {
            ChangeViewCommand = ReactiveCommand.Create(ChangeView);
        }

        private void ChangeView()
        {
            Text = "Change view command exists";
        }
    }
}
