using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoSauro
{
    class Ostacolo
    {
        int x = 800;
        int y = 0;

        public Ostacolo(int t)
        {
            int tipo = t;
            switch(tipo)
            {
                case 1:
                    y = 321;
                    break;
                case 2:
                    y = 301;
                    break;
                case 3:
                    y=240;
                    break;
            }
        }
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }
        public void Spawn()
        {

        }
        public void Sposta()
        {
            x = x - 10;
        }
    }
}
