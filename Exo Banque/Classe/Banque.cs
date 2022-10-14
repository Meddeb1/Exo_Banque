using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Classe
{
    
    class Banque
    {
        

        private string? _nom;

        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

        public string? Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Dictionary<string, Compte> Comptes
        {
            get { return _comptes; }

        }

        //public KeyValuePair<string, Courant>[] Compte
        //{
        //    get { return _compte.ToArray(); }

        //}


        // Indexeurs
        public Compte this[string key]
        {
            get
            {
                Compte compte;

                Comptes.TryGetValue(key, out compte);   // retrouvé la valeur en fonction de la clé  
                return compte;
            }

            set
            {
                Comptes[key] = value;
            }
        }

        public Banque(string nom)
        {
            Nom = nom;
        }

        public void Ajouter(Compte compte)
        {



            compte.PassageEnNegatifEvent += PassageEnNegatifAction; // ajouter un event


            _comptes.Add(compte.Numero, compte);

            /*_compte[compte.Numero] = compte; */ // va pas lever une exception = si le numro de compte est null et la gerer auto
        }

        public void Supprimer(string Numero)
        {
            //if (!_compte.ContainsKey(Numero))
            //{
            //    throw new KeyNotFoundException($"la cle {Numero} n'a pas ete trouvé ");
                
            //}

            //Compte comptes = _compte[Numero];
            //comptes.PassageEnNegatifEvent -= PassageEnNegatifAction;
            //Compte.Remove(Numero);



            Compte? compte = this[Numero];  // supprimer un event

            if(compte is not null)
            {
                compte.PassageEnNegatifEvent -= PassageEnNegatifAction;
                _comptes.Remove(Numero);
            }
            
        }

        public double AvoirDesComptes(Personne p)
        {
            double avoir = 0.0;

            //Linq "Where"

            foreach (Compte c in Comptes.Values)/*.Where(c => c.Titulaire == p))*/
            {
                if(c.Titulaire == p)
                {
                    avoir += c;
                }
                
            }
            return avoir;
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"Le compte {compte.Numero} vient de passer en negatif");  // message de declenchement de l event
        }
        













    }
}
