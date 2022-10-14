using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Classe
{

    public class Epargne : Compte
    {
        #region Attribut

        private DateTime _dateDernierRetrait;
        #endregion



        #region Proprieté
        public DateTime DateDernierRetrait
        {
            get { return _dateDernierRetrait; }
            private set
            {
                _dateDernierRetrait = value;
            }
        }
        #endregion
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {

        }

        public Epargne(string numero, Personne titulaire, double solde,DateTime dateDernierRetrait) : base(numero, titulaire,solde)
        {
            DateDernierRetrait = dateDernierRetrait;
        }

        #region Methode

        public void Retrait(double Montant)
        {
            double AncientSolde = Solde;
            base.Retrait(Montant);

            if (Solde != AncientSolde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }



        protected override double CaluclInteret()
        {

            return Solde * 0.045;
        }

        #endregion



        ///------------------------------------------- 

    }
}
