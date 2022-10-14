using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Classe
{
    public class Personne
    {
        #region Attribut 

        /// <summary>
        /// INIT autorise toute modification de la constructeur 
        /// </summary>
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }

        #endregion

        #region Ctor


        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }



        #endregion

    }
}
