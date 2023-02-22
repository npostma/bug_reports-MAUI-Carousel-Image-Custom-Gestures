using bug_reports_MAUI_Carousel.ViewModels;

namespace bug_reports_MAUI_Carousel;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainPageViewModel();
    }

}

