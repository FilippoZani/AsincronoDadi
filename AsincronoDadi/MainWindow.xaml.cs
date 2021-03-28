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
using System.Threading;

namespace AsincronoDadi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri uri1 = new Uri("dado1.png", UriKind.Relative);
        Uri uri2 = new Uri("dado2.png", UriKind.Relative);
        Uri uri3 = new Uri("dado3.png", UriKind.Relative);
        Uri uri4 = new Uri("dado4.png", UriKind.Relative);
        Uri uri5 = new Uri("dado5.png", UriKind.Relative);
        Uri uri6 = new Uri("dado6.png", UriKind.Relative);
        ImageSource dado1;
        ImageSource dado2;
        ImageSource dado3;
        ImageSource dado4;
        ImageSource dado5;
        ImageSource dado6;
        int i;
        int k;
        Random r;
        public MainWindow()
        {
            InitializeComponent();
            dado1 = new BitmapImage(uri1);
            dado2 = new BitmapImage(uri2);
            dado3 = new BitmapImage(uri3);
            dado4 = new BitmapImage(uri4);
            dado5 = new BitmapImage(uri5);
            dado6 = new BitmapImage(uri6);
            r = new Random();
            EstrazioneContinua();
        }

        public async void EstrazioneContinua()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    i = r.Next(1, 7);
                    k = r.Next(1, 7);

                    switch (i)
                    {
                        case 1:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado1;
                            }));
                            break;
                        case 2:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado2;
                            }));
                            break;
                        case 3:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado3;
                            }));
                            break;
                        case 4:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado4;
                            }));
                            break;
                        case 5:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado5;
                            }));
                            break;
                        case 6:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado6;
                            }));
                            break;
                        default:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img1.Source = dado1;
                            }));
                            break;
                    }

                    switch (k)
                    {
                        case 1:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado1;
                            }));
                            break;
                        case 2:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado2;
                            }));
                            break;
                        case 3:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado3;
                            }));
                            break;
                        case 4:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado4;
                            }));
                            break;
                        case 5:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado5;
                            }));
                            break;
                        case 6:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado6;
                            }));
                            break;
                        default:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                img2.Source = dado1;
                            }));
                            break;
                    }
                }
            });
        }
    }
}
