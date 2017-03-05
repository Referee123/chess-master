using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OWN
{
    class Chess
    {
        private int[,] tab_szach { get; set; }
        MainWindow controls;
        Button button;
        public Chess(MainWindow content)
        {
            controls = content;
            Initalize();
        }

        public void Initalize()
        {
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button = controls.FindName("button" + a++) as Button;
                    double firstmarginLeft = button.Margin.Left;
                    double firstmarginTop = button.Margin.Top;
                    Thickness margin = button.Margin;
                    margin.Left = 80 * i;
                    margin.Top = 80 * j;
                    button.Margin = margin;
                    button.Width = 80;
                    button.Height = 80;
                    string numeric = new String(button.Content.ToString().ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
                    
                    if (Convert.ToInt16(numeric) < 3 || Convert.ToInt16(numeric) > 6)
                    {
                        controls.pawns.Add(new Pawn(button));
                    }
                        
                }
            }



        }


        public int show(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0) return GlobalVariable.FORBIDDEN;
            else return tab_szach[x, y];
        }

        public int add(int x, int y, int color)
        {
            if (x % 2 == 0 && y % 2 == 0) return GlobalVariable.FORBIDDEN;
            else
            {
                this.tab_szach[x, y] = color;
                return 1;
            }
        }

        public int remove(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0) return GlobalVariable.FORBIDDEN;
            else if (tab_szach[x, y] == GlobalVariable.EMPTY) return GlobalVariable.EMPTY;
            else
            {
                this.tab_szach[x, y] = GlobalVariable.EMPTY;
                return 1;
            }
        }
    }
}
