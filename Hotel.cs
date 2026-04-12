using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        private string nomHotel;
        private DateTime dateConstruction;
        private List<Client> clients;
        private List<Employe> employes;
        private List<Chambre> chambres;

        public Hotel(string nom_Hotel, DateTime dateConstruction)
        {
            this.nomHotel = nom_Hotel;
            this.dateConstruction = dateConstruction;
            this.clients = new List<Client>();
            this.employes = new List<Employe>();
            this.chambres = new List<Chambre>();
        }

        public string NomHotel
        {
            get { return this.nomHotel; }
            set { this.nomHotel = value; }
        }
        public DateTime DateConstruction
        {
            get { return this.dateConstruction; }
        }

        public List<Client> Clients
        {
            get { return this.clients; }
        }
        public List<Employe> Employes
        {
            get { return this.employes; }
        }
        public List<Chambre> Chambres
        {
            get { return this.chambres; }
        }

        public void AjouterClient(Client _client)
        {
            clients.Add(_client);
        }
        public void AjouterEmploye(Employe _employe)
        {
            employes.Add(_employe);
        }
        public void AjouterChambre(Chambre _chambre)
        {
            foreach (Chambre c in chambres)
            {
                if (c.Numero == _chambre.Numero)
                {
                    return;
                }
            }
            chambres.Add(_chambre);
        }

        public void LouerChambre(Client _client, Chambre _chambre)
        {
            if (!_chambre.EstDisponible)
            {
                return;
            }

            foreach (Employe e in employes)
            {
                if (e.Id == _client.Id)
                {
                    return;
                }
            }
            _chambre.Client = _client;

            _chambre.EstDisponible = false;
        }

        public string AfficherHotel()
        {
            return "\nNom d'hôtel : " + this.nomHotel +
                "\nDate de construction : " + this.dateConstruction +
                "\nNombre de clients : " + this.clients.Count +
                "\nNombre d'employés : " + this.employes.Count +
                "\nNombre de chambres : " + this.chambres.Count;
        }
    }
}
