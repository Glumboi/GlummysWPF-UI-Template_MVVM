namespace Glummy_WPF_UI_Template_MVVM.ViewModels;

public class DemoViewModel : ViewModelBase
{
    string _helloWorld = "Hello World!";
    
    public string HelloWorld { get => _helloWorld; set => SetProperty(ref _helloWorld, value); }
}