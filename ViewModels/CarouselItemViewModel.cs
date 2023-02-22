using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace bug_reports_MAUI_Carousel.ViewModels;

public class CarouselItemViewModel : INotifyPropertyChanged
{

    public ICommand ClickGestureCarouselOnlyCommand { get; } = null;

    public ICommand ReleaseGestureCarouselOnlyCommand { get; } = null;


    public Image Image { get; set; } = new Image();


    public CarouselItemViewModel() : base()
    {
        ClickGestureCarouselOnlyCommand = new Command((parameter) =>
        {
            Console.WriteLine("== ClickGestureCarouselOnlyCommand triggered");
        });

        ReleaseGestureCarouselOnlyCommand = new Command((parameter) =>
        {
            Console.WriteLine("== ReleaseGestureCarouselOnlyCommand triggered");
        });
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

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="backingStore"></param>
    /// <param name="value"></param>
    /// <param name="propertyName"></param>
    /// <param name="onChanged"></param>
    /// <returns></returns>
    protected bool SetProperty<T>(ref T backingStore, T value,
        [CallerMemberName] string propertyName = "",
        Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion

}
