using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Chambre
    {
        private int numero;
        private bool estDisponible;
        private Client client;

        public Chambre(int numero)
        {
            this.numero = numero;
            this.estDisponible = true;
        }

        public int Numero
        {
            get { return this.numero; }

        }
        public bool EstDisponible
        {
            get { return this.estDisponible; }
            set { this.estDisponible = value; }
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public string AfficherChambre()
        {
            string infoClient = "";
            if (this.client == null)
            {
                infoClient = "Chambre vide";
            }
            else
            {
                infoClient = this.client.AfficherClient();
            }

            return "\nNuméro de chambre : " + this.numero +
                "\nDisponibilité : " + this.estDisponible +
                "\nClient : " + infoClient;
        }
    }
}
