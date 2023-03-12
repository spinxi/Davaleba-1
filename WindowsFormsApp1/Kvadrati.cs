using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Kvadrati
    {
        public int kvadratisGverdisZoma;
        private int _kvadratisPartobi;
        
        public void MinichebaSetter(int value)
        {
            kvadratisGverdisZoma = value;
        }

        public int GamotanaGetter()
        {
            return kvadratisGverdisZoma;
        }

        public int KvadratisPartobiGetter()
        {
            _kvadratisPartobi = kvadratisGverdisZoma * kvadratisGverdisZoma;
            return _kvadratisPartobi;
        }
    }
}
