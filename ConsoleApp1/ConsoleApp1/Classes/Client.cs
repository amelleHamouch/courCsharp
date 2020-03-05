using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class Client
    {
        private String nom;
        private String prenom;
        private int tel;
        private int idClient;

        public Client(String nom, String prenom, int tel)
        {
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public Client()
        {
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }
        public int IdClient { get => idClient; set => idClient = value; }

        public void depot(decimal montant, Compte compte)
        {
            compte.montants.Add(montant);
            compte.operations.Add("Dépôt : ");
        }

        public void retrait(decimal montant, Compte compte)
        {
            compte.montants.Add(montant);
            compte.operations.Add("Retrait : ");
        }

        public void AfficherSolde(Compte compte)
        {
            Console.WriteLine("Votre solde est de : " + compte.Solde + " " + "€");

        }

        public void AfficherOperations(Compte compte)
        {

            foreach(String ope in compte.operations)
            {
                Console.WriteLine("Opération : " + " " + ope);
                foreach (decimal mont in compte.montants)
                {
                    Console.WriteLine("Montant : " + " " + mont);

                }

            }
            AfficherSolde(compte);
        }

    }


}
