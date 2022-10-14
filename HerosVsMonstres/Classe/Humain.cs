using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Humain : Hero
    {
        public override int BonusForce => base.Force + 1;
        public override int BonusEndurence => base.Endurence + 1;
    }
}
