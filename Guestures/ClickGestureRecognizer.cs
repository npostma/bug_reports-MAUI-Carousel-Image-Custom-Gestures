using System.Windows.Input;

namespace bug_reports_MAUI_Carousel.Guestures;
public class ClickGestureRecognizer : Element, IGestureRecognizer
{
    public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(ClickGestureRecognizer), null, BindingMode.OneWay, null, null, null, null, null);

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(ClickGestureRecognizer), null, BindingMode.TwoWay, null, null, null, null, null);

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