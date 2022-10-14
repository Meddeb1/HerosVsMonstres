using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Nain : Hero
    {
        public override int Force => base.Force + 2;
    }
}
