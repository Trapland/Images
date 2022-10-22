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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int value = 0;
        public List<BitmapImage> Images = new List<BitmapImage>();
        public BitmapImage CurrentImage { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Images.Add(new BitmapImage(new Uri("C:\\1\\111.jpg")));
            Images.Add(new BitmapImage(new Uri("C:\\1\\germany.png")));
            Images.Add(new BitmapImage(new Uri("C:\\1\\eng.png")));
            Images.Add(new BitmapImage(new Uri("C:\\1\\ukr.png")));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (value >= Images.Count) value = 0;
            CurrentImage = Images[value];
            img.Source = CurrentImage;
            value++;
        }
    }
}
