using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exo_Banque.Classe
{
    public class Courant : Compte
    {
        #region Attribut

        private double _LigneDeCredit;
        #endregion


        #region Proprieté
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("la ligne de credit est strictement positive!!!");
                }


                _LigneDeCredit = value;
            }
        }

        #endregion

        /// <summary>
        /// Constructeur de la classe Courant
        /// </summary>
        /// <param name="numero">Represente  le numero du compte</param>
        /// <param name="titulaire"> Represente le proprietaire du compte</param>
        #region Ctr
        public Courant(string numero,Personne titulaire) : base(numero, titulaire)
        {

        }

        public Courant(string numero, Personne titulaire,double solde) : base(numero, titulaire,solde)
        {
            
        }
        public Courant(string numero, double ligneDeCredit, Personne titulaire) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }




        #endregion

        #region Methode


        public override void Retrait(double Montant)
        {
           double oldSolde = Solde;
           
            Retrait(Montant, LigneDeCredit);

            if(oldSolde >= 0 && Solde < 0)
            {
                RaiseEventPassageEnNegatif();
            }
        }

        protected override double CaluclInteret()
        {

            if (Solde < 0)
            {
                return Solde * 0.0975;
            }

            else
            {
                return Solde * 0.03;
            }

            // Ternaire : return Solde > 0 ? Solde * 0.03 : Solde * 0.0975;
        }


        //private void MaMethode(Compte c)
        //{
        //    PassageEnnegatifEvent(Compte c);
        //}

        #endregion
    }

}
