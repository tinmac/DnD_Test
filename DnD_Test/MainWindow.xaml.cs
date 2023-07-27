using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DnD_Test
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        Main_VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new Main_VM();
            grid_main.DataContext = vm;
            NameList.ItemsSource = vm.People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.People.Add(new Person("10", "P", "Q"));
            vm.People[0].FirstName = "Sandra";
        }
    }
}