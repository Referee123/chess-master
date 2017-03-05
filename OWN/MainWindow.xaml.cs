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
        public List<Pawn> pawns { get; set; }
        private int buffer = 0;
        private System.Windows.Media.Brush ColorBuffer;
        Button FirstMove;
        Button SecondMove;
        Chess chess;


        public MainWindow()
        {
            InitializeComponent();
            pawns = new List<Pawn>();
            InitalizeChess();

        }

        private void InitalizeChess()
        {
            chess = new Chess(this);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(FirstMove != null)
            {
                FirstMove = sender as Button;
            }
            else
            {
                SecondMove = sender as Button;
            }
        }
        private void double_Click(Button button)
        {
            button.Background = ColorBuffer;
        }

    }
}
