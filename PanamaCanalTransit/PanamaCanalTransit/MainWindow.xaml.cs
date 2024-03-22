using System.Windows;

namespace PanamaCanalTransit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.StateChanged += MainWindow_StateChanged;
        }

        private void MainWindow_StateChanged(object? sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                header.Margin = new Thickness(-100, 0, 0, 3);
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                header.Margin = new Thickness(-400, 3, 0, 10);
            }
            else if (this.WindowState == WindowState.Normal)
            {
                header.Margin = new Thickness(-100, 0, 0, 3);
            }
        }
    }
}