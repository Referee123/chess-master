using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace OWN
{
    public class Pawn
    {
        public string Field { get; set; }
        Button position;

        public Pawn(Button _button)
        {
            position = _button;
            Field = _button.Content.ToString();
            _button.Background = Brushes.Blue;
        }

        public void InitalizePawn()
        {
            for (int i = 0; i < 3; i++)
            {

            }
        }
    }
}
