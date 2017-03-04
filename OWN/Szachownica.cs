using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OWN
{
    class Chess
    {
        private int[,] tab_szach { get; set; }

        
        public Chess()
        {
            this.tab_szach = new int[8, 8];
            for (int i = 0; i < 8; i=i+2)
            {
                tab_szach[0,i] = GlobalVariable.WHITE;
                tab_szach[1,i + 1] = GlobalVariable.WHITE;
                tab_szach[2,i] = GlobalVariable.WHITE;

                tab_szach[7,i + 1] = GlobalVariable.BLACK;
                tab_szach[6,i] = GlobalVariable.BLACK;
                tab_szach[5,i+1] = GlobalVariable.BLACK;
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
            else {
                this.tab_szach[x, y] = color;
                return 1;
            }
        }
        
        public int remove(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0) return GlobalVariable.FORBIDDEN;
            else if (tab_szach[x, y] == GlobalVariable.EMPTY) return GlobalVariable.EMPTY;
            else {
                this.tab_szach[x, y] = GlobalVariable.EMPTY;
                return 1;
            }
        }
    }
}
