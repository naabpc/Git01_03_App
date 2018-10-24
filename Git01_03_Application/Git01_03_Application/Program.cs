using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git01_03_App
{
    class Program
    {
        private static List<Personne> ListePersonne = new List<Personne>();
        static void Main(string[] args)
        {
            ListePersonne.Add(new Personne { Id = 1, Nom = "AngéliqueM", Ville = "Rouen", DateNaissance = new DateTime(1986, 3, 23) });
            ListePersonne.Add(new Personne { Id = 2, Nom = "Ahmed", Ville = "Lille", DateNaissance = new DateTime(1987, 2, 14) });
            ListePersonne.Add(new Personne { Id = 3, Nom = "Ali", Ville = "Orsay", DateNaissance = new DateTime(1984, 1, 30) });
            ListePersonne.Add(new Personne { Id = 4, Nom = "Clément", Ville = "Marseille", DateNaissance = new DateTime(1986, 6, 13) });
            ListePersonne.Add(new Personne { Id = 5, Nom = "AngéliqueP", Ville = "Annecy", DateNaissance = new DateTime(1978, 8, 6) });
            ListePersonne.Add(new Personne { Id = 6, Nom = "Amine", Ville = "Evry", DateNaissance = new DateTime(1985, 5, 25) });
            ListePersonne.Add(new Personne { Id = 7, Nom = "Khalil", Ville = "Constantine", DateNaissance = new DateTime(1984, 1, 6) });
            ListePersonne.Add(new Personne { Id = 8, Nom = "Hacène", Ville = "Strasbourg", DateNaissance = new DateTime(1976, 11, 22) });
            ListePersonne.Add(new Personne { Id = 9, Nom = "Imen", Ville = "Istanbul", DateNaissance = new DateTime(1987, 2, 26) });
            ListePersonne.Add(new Personne { Id = 10, Nom = "Benjamin", Ville = "Chartres", DateNaissance = new DateTime(1986, 1, 9) });
            ListePersonne.Add(new Personne { Id = 11, Nom = "Emmanuel", Ville = "Naïrobi", DateNaissance = new DateTime(1979, 10, 29) });

            // ListePersonne.WriteLine(p => p.Nom);
            foreach (var p in ListePersonne) Console.WriteLine(p);
            Console.Read();

        }
    }
}
