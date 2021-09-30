using System.Windows;

namespace TRPZ2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb1.Items.Add("FirstName LastName");
            lb1.Items.Add("Vsevolod Zhohan");
            lb1.Items.Add("Denis Vasylyev IA94");
            lb1.Items.Add("Andrei Ishchenko");
            lb1.Items.Add("Alexandr Rolik");
        }
    }
}
