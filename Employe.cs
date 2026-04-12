using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Employe
    {
        private string nom;
        private string prenom;
        private int age;
        private Guid id;

        public Employe(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.id = Guid.NewGuid();
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Guid Id
        {
            get { return this.id; }
        }

        public string AfficherEmploye()
        {
            return "\nNom : " + this.nom +
                "\nPrénom : " + this.prenom +
                "\nAge : " + this.age +
                "\nID : " + this.id;
        }
    }
}
