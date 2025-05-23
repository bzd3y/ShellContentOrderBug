
namespace ShellContentBugs
{
	public partial class MainPage : ContentPage, IQueryAttributable
    {
        public MainPage()
        {
            InitializeComponent();
        }

		public void ApplyQueryAttributes(IDictionary<string, object> query)
		{

		}

		private async void OnCounterClicked(object sender, EventArgs e)
        {
			await Shell.Current.GoToAsync("//OtherPage?test=false");
		}
	}

}
