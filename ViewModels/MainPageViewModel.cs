using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bug_reports_MAUI_Carousel.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{

    private ObservableCollection<CarouselItemViewModel> carouselItems;
    public ObservableCollection<CarouselItemViewModel> CarouselItems
    {
        get => carouselItems;
        set
        {
            carouselItems = value;
            OnPropertyChanged(nameof(CarouselItems));
        }
    }


    public MainPageViewModel() : base()
    {
        CarouselItems = new ObservableCollection<CarouselItemViewModel>();

        var item1 = new CarouselItemViewModel();
        item1.Image.Source = ImageSource.FromFile("blue.png");
        var item2 = new CarouselItemViewModel();
        item2.Image.Source = ImageSource.FromFile("red.png");
        var item3 = new CarouselItemViewModel();
        item3.Image.Source = ImageSource.FromFile("green.png");

        AddToCarousel(item1);
        AddToCarousel(item2);
        AddToCarousel(item3);
    }


    public void AddToCarousel(CarouselItemViewModel item)
    {
        CarouselItems.Add(item);
        OnPropertyChanged(nameof(CarouselItems));
    }


    #region INotifyPropertyChanged
    /// <summary>
    /// 
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChangedEventHandler changed = PropertyChanged;
        if (changed == null)
        {
            return;
        }

        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

}
