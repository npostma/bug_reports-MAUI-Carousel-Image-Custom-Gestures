using System.Windows.Input;

namespace bug_reports_MAUI_Carousel.Guestures;
public class ReleasedGestureRecognizer : Element, IGestureRecognizer
{
    public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(ReleasedGestureRecognizer), null, BindingMode.OneWay, null, null, null, null, null);

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(ReleasedGestureRecognizer), null, BindingMode.TwoWay, null, null, null, null, null);

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }
}

