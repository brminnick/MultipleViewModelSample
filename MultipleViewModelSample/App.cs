using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MultipleViewModelSample
{
	public class App : Application
	{
		public App() => MainPage = new MainPage();
	}
}
