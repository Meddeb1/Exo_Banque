using System.Runtime.Serialization;

namespace Exo_Banque.Classe
{
    [Serializable]
    internal class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : base("Solde Insuffisant")
        {
        }

       
    }
}