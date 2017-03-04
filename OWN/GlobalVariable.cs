using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OWN
{
    public static class GlobalVariable
    {
        public static int BLACK = 1;
        public static int WHITE = 2;
        public static int EMPTY = 0;
        public static int FORBIDDEN = -1;
    }

    public class OtherFunctions
    {
        public static void ParseXY (Button button, ref int x, ref int y)
        {
            string[] world = button.Name.Split('n');
            int number = int.Parse(world[1]);
            y = number % 8;
            x = number / 8;            
        }

    }

}
