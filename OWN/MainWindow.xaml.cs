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

namespace OWN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int buffer = 0;
        private System.Windows.Media.Brush ColorBuffer;
        private Button ButtonBuffer;
        private string ContentBuffer;
        Chess chess = new Chess();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;
            Button field = new Button();
            field = (Button)sender;
            if (buffer < 1)
            {
                OtherFunctions.ParseXY(field, ref x, ref y);                
                if ((x + y) % 2 != 0)
                {
                    return;
                }
                ColorBuffer = field.Background;
                ButtonBuffer = field;
                ContentBuffer = (string)field.Content;
                buffer++;
            }
            else
            {
                OtherFunctions.ParseXY(field, ref x, ref y);
                if ((x + y) % 2 != 0)
                {
                    buffer = 0;
                    return;
                }
                int oldX = 0;
                int oldY = 0;
                OtherFunctions.ParseXY(ButtonBuffer, ref oldX, ref oldY);
                chess.add(x, y, chess.show(oldX, oldY));
                chess.remove(oldX, oldY);
                ButtonBuffer.Background = Brushes.LightGray;
                buffer = 0;
                field.Background = ColorBuffer;
            }
        }
        private void double_Click(Button button)
        {
            button.Background = ColorBuffer;
        }

    }
}
