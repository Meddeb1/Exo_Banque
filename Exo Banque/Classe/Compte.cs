using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Banque.Classe;
using Exo_Banque.Interface;

namespace Exo_Banque
{

    public abstract class Compte : /*ICustomer,*/ IBanker
    {
        // delegate : 
        // la classe « Compte » :
        //1. Ajoutez un événement appelé « PassageEnNégatifEvent » dont le délégué(« PassageEnNegatifDelegate ») devra recevoir en paramètre un objet
        //de type « Compte » et ne rien renvoyer.

        // creation de l'evenement
        /*p PassageEnNegatifDelegate _passageEnNegatifEvent;*/  //123


        public event Action<Compte> PassageEnNegatifEvent;
        
            
        


        // surcharge operator
        public static double operator +(double Solde, Compte c)
        {
            return Solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        #region Attribut
        private string? _Numero;
        private double _Solde;
        private Personne _Titulaire;
        #endregion

        #region Proprieté

        public string? Numero
        {
            get { return _Numero; }
            private set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set
            {
                //    if (Solde < 0)
                //    {
                _Solde = value;
                //    PassageEnnegatifEvent(this);    //123
                //}


            }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            private set { _Titulaire = value; }
        }

        

        #endregion
        #region Ctr

        

        protected Compte(string numero , Personne titulaire)
        {
            Numero = numero;

            Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire,double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }


        #endregion

        #region Methode
        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0);
        }

        protected void Retrait(double Montant, double LigneDeCredit)
        {
            if (Montant <= 0)
                throw new ArgumentOutOfRangeException(nameof(Montant));

            if (Solde - Montant < -LigneDeCredit)
                throw new SoldeInsuffisantException();

            Solde -= Montant;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Montant"></param>
        /// <exception cref="ArgumentOutOfRangeException">Le montany doit etre superieur a 0</exception>
        public void Depot(double Montant)
        {
            if (Montant <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Montant));
            }

           
            Solde += Montant;
        }

        //Définir la classe « Compte » comme étant abstraite.
            //2. Ajouter une méthode abstraite « protected » à la classe « Compte » appelée « CalculInteret » ayant pour prototype « double CalculInteret() »
            //en sachant que pour un livret d’épargne le taux est toujours de 4.5% tandis que pour le compte courant si le solde est positif le taux sera de 3%
            //sinon de 9.75%.
            //3. Ajouter une méthode « public » à la classe « Compte » appelée « AppliquerInteret » qui additionnera le solde avec le retour de la méthode
            //« CalculInteret ».

        protected abstract double CaluclInteret();

        public void AppliquerInteret()
        {
            Console.WriteLine($"l'Interet est : {CaluclInteret()}");
            
             Solde += CaluclInteret();
        }

        // delegate

        protected void RaiseEventPassageEnNegatif()
        {
            Action<Compte> passageEnNegatifEvent = PassageEnNegatifEvent;

            passageEnNegatifEvent?.Invoke(this);
        }

        #endregion

    }
}
