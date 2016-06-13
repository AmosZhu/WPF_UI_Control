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

namespace AM_CONTROL
{
    /// <summary>
    /// Interaction logic for HotButton.xaml
    /// </summary>
    public partial class HotButton : UserControl
    {
        public HotButton()
        {
            InitializeComponent();
        }
        
        public Image NormalImage
        {
            get { return (Image)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }


        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(Image), typeof(HotButton), new PropertyMetadata((Image)null));

        public Image HotImage
        {
            get { return (Image)GetValue(HotImageProperty); }
            set { SetValue(HotImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HotImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HotImageProperty =
            DependencyProperty.Register("HotImage", typeof(Image), typeof(HotButton), new PropertyMetadata((Image)null));

        public Image DisableImage
        {
            get { return (Image)GetValue(DisableImageProperty); }
            set { SetValue(DisableImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisableImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisableImageProperty =
            DependencyProperty.Register("DisableImage", typeof(Image), typeof(HotButton), new PropertyMetadata((Image)null));

        public event RoutedEventHandler Click;
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if(this.Click!=null)
            {
                this.Click(this, e);
            }
        }


    }
}
