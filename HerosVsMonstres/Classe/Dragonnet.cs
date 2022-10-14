using HerosVsMonstres.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public class Dragonnet : Monstre , IOr ,ICuir
    {
        public override int BonusEndurence => base.Endurence + 1;

        public int Or { get; set; } 
        public int Cuir { get; set; }

        public Dragonnet() : base ()
        {
            Or = new De(0, 6).Roll(); // l'or est calculé sur la base d'un dé 6 Faces
            Cuir = new De (0,4).Roll(); // l'or est calculé sur la base d'un dé 4 Faces
        }
        

        public override string Race()
        {
            return "Dragonnet";
        }
    }
}
