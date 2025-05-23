
namespace ShellContentBugs;

public partial class OtherPage : ContentPage, IQueryAttributable
{
	public OtherPage()
	{
		InitializeComponent();
	}

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage?test=true");
	}
}