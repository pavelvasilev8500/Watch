using System;
using System.Windows;
using System.Windows.Input;

namespace Watch
{
    public partial class MainWindow : Window
    {
        private readonly double screenHeight = SystemParameters.FullPrimaryScreenHeight;
        private readonly double screenWidth = SystemParameters.FullPrimaryScreenWidth;

        public MainWindow()
        {
            InitializeComponent();
            SetLocation();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            {
                return;
            }
        }

        private void SetLocation()
        {
            this.Top = (screenHeight - this.Height) - 198;
            this.Left = (screenWidth - this.Width) - 3;
        }


        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Space)
                    Environment.Exit(0);
            }
            catch
            {
                return;
            }
        }
    }
}
