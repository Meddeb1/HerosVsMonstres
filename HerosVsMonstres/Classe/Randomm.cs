using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Randomm
    {
       

        public static int RandomAll()
        {
            Random random = new Random();
            int aleatoire = random.Next(0, 12);
            return aleatoire;
        }



    }
}
