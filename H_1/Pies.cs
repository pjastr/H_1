using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_1
{
    class Pies
    {
        private int czasPosilku;

        public void UstawCzasPosilku(int czas)
        {
            this.czasPosilku = czas;
        }

        public int PobierzCzasPosilku()
        {
            return czasPosilku;
        }

        public bool PotrzebnySpacer()
        {
            if (czasPosilku > 5) return true;
            else return false;
        }
    }
}
