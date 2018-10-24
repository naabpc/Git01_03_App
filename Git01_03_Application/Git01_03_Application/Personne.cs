using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git01_03_App
{
    internal class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        public DateTime DateNaissance { get; set; }
        public override string ToString()
        {
            return Nom + " : " + DateNaissance.ToShortDateString();
        }
    }
}
