using KB13213_WpfApp1.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB13213_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void series1_AssigningCategoryStyle(object sender, Infragistics.Controls.Charts.AssigningCategoryStyleEventArgs args)
    {
        // 点数が 80 点以上は緑
        if (((ScoreResult)args.GetItems(args.StartIndex, args.EndIndex)[0]).Score >= 80)
        {
            args.Fill = new SolidColorBrush(Colors.LightGreen);
            args.Stroke = new SolidColorBrush(Colors.Green);
        }
        // 点数が 80 点未満 50 点以上は黄色
        else if (((ScoreResult)args.GetItems(args.StartIndex, args.EndIndex)[0]).Score >= 50)
        {
            args.Fill = new SolidColorBrush(Colors.LightYellow);
            args.Stroke = new SolidColorBrush(Colors.Yellow);
        }
        // 点数が 50 点未満は赤
        else
        {
            args.Fill = new SolidColorBrush(Colors.Pink);
            args.Stroke = new SolidColorBrush(Colors.Red);
        }
    }
}