using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class IHMBanque
    {
        String choix;
        public IHMBanque()
        {

        }

        public void start()
        {
            Func<decimal> retraitNegatif;
            choix = "N";
            do
            {
                Console.WriteLine("Choisissez une action : ");
                Console.WriteLine("1--- Créer un compte bancaire");
                Console.WriteLine("2--- Effectuer un dépôt");
                Console.WriteLine("3--- Effectuer un retrait");
                Console.WriteLine("4--- Afficher opérations et solde");

                int reponse = Convert.ToInt32(Console.ReadLine());
                int choix;
                String soldeClient;
                Client client = new Client();
                Compte compte = new CompteBancaire();

                switch (reponse)
                {
                    case 1:

                        Console.WriteLine("Veuillez nous communiquer votre nom :");
                        String nom = Console.ReadLine();
                        Console.WriteLine("Veuillez nous communiquer votre prenom :");
                        String prenom = Console.ReadLine();
                        Console.WriteLine("Veuillez nous communiquer votre téléphone :");
                        int tel = Convert.ToInt32(Console.ReadLine());

                        client.Nom = nom;
                        client.Prenom = prenom;
                        client.Tel = tel;

                        Console.WriteLine("Quel type de compte ?");
                        Console.WriteLine("1---Compte courant");
                        Console.WriteLine("2---Compte epargne");
                        Console.WriteLine("3---Compte payant");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if(choix == 1)
                        {
                            Console.WriteLine("Désirez vous déposer un solde ? (O/N)");
                            soldeClient = Console.ReadLine();

                            if(soldeClient == "O")
                            {
                                Console.WriteLine("Solde à déposer :");
                                decimal soldeDepot = Convert.ToDecimal(Console.ReadLine());
                                compte = new CompteBancaire(soldeDepot);
                                client.AfficherSolde(compte);

                            }
                            else
                            {
                                
                                client.AfficherSolde(compte);
                            }
                            
                        }

                        break;

                    case 2:
                        Console.WriteLine("Combien désirez-vous déposer ?");
                        decimal montant = Convert.ToDecimal(Console.ReadLine());
                        client.depot(montant, compte);

                        client.AfficherSolde(compte);
                        break;

                    case 3:

                        Console.WriteLine("Combien désirez-vous retirer ?");
                        decimal retrait = Convert.ToDecimal(Console.ReadLine());
                        client.retrait(retrait, compte);

                        client.AfficherSolde(compte);
                        break;
                    case 4:
                        client.AfficherOperations(compte);
                        client.AfficherSolde(compte);
                        break;
                }

            }while(choix != "O");

        }
    }
}
