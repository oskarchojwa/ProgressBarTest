using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using MahApps.Metro.Controls.Dialogs;
using System.Data.SQLite;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var progress = new Progress<double>(value =>
			{
				metroProgressBar.Value = value;
			});

            await Task.Run(() => LoopThroughNumbers(progress));

		}

        void LoopThroughNumbers(IProgress<double> progress)
        {
            double zmienna = 0;
            for (int i= 0; i < 1000000000; i++)
            {
                if (i % 10000000 == 0)
                {
                    zmienna += 1;
                    progress.Report(zmienna);
                }
            }
        }

        private void MetroProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}