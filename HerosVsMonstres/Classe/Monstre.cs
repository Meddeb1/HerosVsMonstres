using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public abstract class Monstre : Personnage
    {


        public virtual string Race()
        {
            return "Monstre";
        }
       
    }
}
