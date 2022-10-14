using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public abstract class Hero : Personnage
    {
        public int Or { get; set; } 
        public int Cuir { get; set; }

        public Hero() { }
        
    }
}
