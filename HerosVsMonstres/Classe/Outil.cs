using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HerosVsMonstres.Classe
{
    public static class Outil
    {
        /// <summary>
        /// Calcul des meuilleurs pour l'endurence et la Force
        /// </summary>
        /// <returns>result : les 3derniers index du la liste</returns>
        public static int CalculMeuilleurs()
        {
          
            List<int> meuilleurs = new List<int>();    // liste des 3 meuilleurs 

            for (int i = 0; i < 4; i++)
            {  
                De d1 = new De(0,6);  // instanciation d un nouveeau De
                meuilleurs.Add(d1.Roll());  // ajouter le De et appeler la methode Roll
                //meuilleurs[i]=d1.Roll();
            }

            meuilleurs.Sort();  // trier la liste 

            int result = meuilleurs[1] + meuilleurs[2] + meuilleurs[3];  // parcourir les 3 meilleurs 

            return result;
        }

        /// <summary>
        /// calcul modificateur des point de vie 
        /// </summary>
        /// <returns></returns>
        public static int Modificateur()
        {
           int result = 0;

            if (result < 5)
            {
                result = result + 2;
            }
            else if (result < 1)
            {
                result = result + 1;
            }

            else if (result < 15)
            {
                result =result;
            }

            else result = result - 1;

            return result;
        }

        public static int EnleverPointVie()
        {
            De d2 = new De(0,4);

            int result2 = 0;

            if (result2 < 5)
            {
                result2 = d2.Roll() -1;
            }
            else if (result2 < 1)
            {
                result2 = d2.Roll();
            }

            else if (result2 < 15)
            {
                result2 = d2.Roll() + 1;
            }

            result2 = d2.Roll() + 2;

            return result2;
        }


    }
}
