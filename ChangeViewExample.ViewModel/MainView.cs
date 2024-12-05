using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using System.Windows.Input;

namespace ChangeViewExample.ViewModel
{
    public class MainView: ReactiveObject
    {
        [Reactive]
        public string Text { get; set; } = "Change view";
        public ICommand ChangeViewCommand { get; }

        [Reactive]
        public IInnerView SelectedView { get; set; }
        public MainView()
        {
            ChangeViewCommand = ReactiveCommand.Create(ChangeView);
            SelectedView = new ViewRectangle();
        }

        private void ChangeView()
        {
            if (SelectedView is ViewRectangle)
            {
                SelectedView = new ViewText();
            }
            else 
            {
                SelectedView = new ViewRectangle();
            }
        }

    }

    public class ViewRectangle:ReactiveObject, IInnerView
    { }

    public class ViewText : ReactiveObject, IInnerView
    {
        public string Text { get; set; } = "The secondary view";
    }
}
