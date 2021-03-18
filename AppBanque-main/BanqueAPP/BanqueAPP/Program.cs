using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
           // string nom = Console.ReadLine();
            Client c1 = new Client("Nadim","Hamza","rabat");
            Client c2 = new Client("Rezki", "Hicham", "casablanca");
            MAD solde1 = new MAD(9000);
            MAD solde4 = new MAD(200);
            solde1.afficher();
            Compte cc1 = new Compte(c2, solde1);
            cc1.crediter(solde4);
            cc1.debiter(solde4);
            cc1.consulter();
            Compte_Epargne cpt = new Compte_Epargne(c1, solde1,60);
            cpt.calcule_interet();
            
            cpt.consulter();
           // Operation oo = new Operation("retrait", solde1);
           // oo.afficher();
            Console.ReadKey();


        }
    }
}
