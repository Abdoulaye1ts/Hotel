using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel("Etoile", new DateTime(2008, 01, 01));

            Chambre ch1 = new Chambre(001);
            Chambre ch2 = new Chambre(002);
            Chambre ch3 = new Chambre(003);

            hotel1.AjouterChambre(ch1);
            hotel1.AjouterChambre(ch2);
            hotel1.AjouterChambre(ch3);

            Client cl1 = new Client("ADAMS", "Nate", 11);
            Client cl2 = new Client("ADAMS", "Aaron", 39);
            Client cl3 = new Client("ADAMS", "Cheryl", 36);

            hotel1.AjouterClient(cl1);
            hotel1.AjouterClient(cl2);
            hotel1.AjouterClient(cl3);

            Employe empl1 = new Employe("TOMATE", "TOM", 20);
            hotel1.AjouterEmploye(empl1);

            hotel1.LouerChambre(cl1, ch1);

            Console.WriteLine("Informations chambres :");
            Console.WriteLine(ch1.AfficherChambre());
            Console.WriteLine(ch2.AfficherChambre());

            Console.WriteLine("Informations clients :");  
            Console.WriteLine(cl2.AfficherClient());
            Console.WriteLine(cl3.AfficherClient());

            Console.WriteLine("\nInformations employés :");
            Console.WriteLine(empl1.AfficherEmploye());


            Console.WriteLine("Informations de l'hôtel :");
            Console.WriteLine(hotel1.AfficherHotel());


        }
    }
}
