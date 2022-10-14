using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    
    public class De
    {
        #region Prop
        public int Maximun { get; set; }
        public int Minimum { get; set; }
        #endregion

        #region Ctor

        public De(int min , int max)  // 2 De de(4) et (6)
        {
            Minimum = min;
            Maximun = max;
        }

        #endregion

        #region Methode

        public int Roll()
        {
            return Randomm.RandomAll();

        }
        #endregion

    }
}
