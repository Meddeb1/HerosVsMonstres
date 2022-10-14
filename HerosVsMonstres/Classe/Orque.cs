using HerosVsMonstres.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Orque : Monstre , IOr
    {
        public override int BonusForce => base.Force + 1;

        public int Or { get; set; }

        
        public Orque() : base()
        {
            Or = new De(0, 4).Roll();
        }

        public override string Race()
        {
            return "Orque";
        }
    }
}
