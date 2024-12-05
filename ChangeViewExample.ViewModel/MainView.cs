using ReactiveUI.Fody.Helpers;

namespace ChangeViewExample.ViewModel
{
    public class MainView
    {
        [Reactive]
        public string Text { get; set; } = "Initial with View Model project";
    }
}
