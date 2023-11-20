using System.IO;
using System;
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
using MinecraftLaunch.Modules.Utilities;


namespace BAMCL
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            JavaPath.ItemsSource = JavaUtil.GetJavas();
            GamePath.ItemsSource = new GameCoreUtil(".minecraft").GetGameCores();
        }

        //界面拖动
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //界面最小化
        private void Window_Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //界面关闭
        private void Window_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}