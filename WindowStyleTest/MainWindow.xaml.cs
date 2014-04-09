using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WindowStyleTest
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
      // quick fix to show the taskbar
      this.WindowStyle = System.Windows.WindowStyle.ThreeDBorderWindow;
      this.WindowState = System.Windows.WindowState.Maximized;
      this.WindowStyle = System.Windows.WindowStyle.None;
    }
  }
}
