using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class CompteBancaire : Compte
    {

        private decimal tauxInteret;

        public CompteBancaire(decimal solde) : base(solde)
        {
            Compte.Code += 1;
        }

        public CompteBancaire()
        {
            Compte.Code += 1;
        }
    }
}
