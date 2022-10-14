using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public abstract class Personnage
    {

        #region Attribut

        private int _endurence;
        private int _force;
        private int _pointVie;
        public virtual int BonusForce { get; set; }
        public virtual  int BonusEndurence { get; set; }

        #endregion

        #region Prop
        public virtual int Endurence
        {
            get { return _endurence; }
            private set { _endurence = value; }
        }

        public virtual  int Force
        {
            get { return _force; }
            private set { _force = value; }
        }

        public int PointVie
        {
            get { return _pointVie; }
            private set
            {
                _pointVie = value;
            }
        }
        #endregion

        #region Ctor
        public Personnage() { }
        public Personnage(int endurence,int force,int pointVie)
        {
            Endurence = Outil.CalculMeuilleurs();
            Force = Outil.CalculMeuilleurs();
            PointVie = Endurence + Outil.Modificateur();
        }

        #endregion

        #region Methode

        public int Frapper(Personnage personnage)
        {
            int combat = 0;
            if(combat <= PointVie)
            {
                PointVie = Outil.EnleverPointVie();
            }
            return PointVie;
        }

        
        
        #endregion







    }
}
