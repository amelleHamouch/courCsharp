using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class Compte
    {

        private static int code;
        private decimal solde;
        private int idClient;

        public List<decimal> montants = new List<decimal>();
        public List<String> operations = new List<String>();

        public Compte()
        {
            Solde = 0;
        }

        public Compte(decimal solde)
        {
            Solde = solde;
        }

        public static int Code { get => code; set => code = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public int IdClient { get => idClient; set => idClient = value; }


    }
}
