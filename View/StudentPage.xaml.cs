namespace Module02Activity01.View;

using Module02Activity01.ViewModel;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		BindingContext = new StudentViewModel();
	}
}