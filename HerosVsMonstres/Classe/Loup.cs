using HerosVsMonstres.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Loup : Monstre , ICuir
    {

        public int Cuir { get; set; }

        public Loup():base()
        {
            Cuir = new De(0,4).Roll();
        }
        public override string Race()
        {
            return "Loup";
        }
    }
}
