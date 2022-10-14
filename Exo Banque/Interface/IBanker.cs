using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Banque.Classe;

namespace Exo_Banque.Interface
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire { get; }

        void AppliquerInteret();

    }
}

