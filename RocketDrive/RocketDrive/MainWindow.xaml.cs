using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RocketDrive
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ps;
            ps = @"C:\Users\q1\source\repos\RocketDrive\RocketDrive\res\script\run11.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "  -executionpolicy RemoteSigned -nologo -noninteractive -windowStyle hidden  -File " + ps);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string ps11;
            ps11 = @"C:\Users\q1\source\repos\RocketDrive\RocketDrive\res\script\deleteAll.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy RemoteSigned -nologo -noninteractive -windowStyle hidden -File " + ps11);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string ps12;
            ps12 = @"C:\Users\q1\source\repos\RocketDrive\RocketDrive\res\script\re11.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy RemoteSigned -nologo -noninteractive -windowStyle hidden -File " + ps12);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string ps13;
            ps13 = @"C:\Users\q1\source\repos\RocketDrive\RocketDrive\res\script\dismount.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy RemoteSigned -nologo -noninteractive -windowStyle hidden -File " + ps13);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string ps14;
            ps14 = @"C:\Users\q1\source\repos\RocketDrive\RocketDrive\res\script\mount.ps1";
            System.Diagnostics.Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy RemoteSigned -nologo -noninteractive -windowStyle hidden -File " + ps14);
        }
    }
}
