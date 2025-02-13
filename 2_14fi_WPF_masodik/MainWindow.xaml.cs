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

namespace _2_14fi_WPF_masodik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //piros / kék
        private bool Red = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        void ClickEvent00(Object s, EventArgs e) {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if(Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button00.Background = color;
        }
        void ClickEvent01(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button01.Background = color;
        }
        void ClickEvent02(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button02.Background = color;
        }
        void ClickEvent10(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button10.Background = color;
        }
        void ClickEvent11(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button11.Background = color;
        }
        void ClickEvent12(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button12.Background = color;
        }
        void ClickEvent20(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button20.Background = color;
        }
        void ClickEvent21(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button21.Background = color;
        }
        void ClickEvent22(Object s, EventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Blue);
            if (Red) color = new SolidColorBrush(Colors.Red);
            Red = !Red;
            Button22.Background = color;
        }
    }
}
