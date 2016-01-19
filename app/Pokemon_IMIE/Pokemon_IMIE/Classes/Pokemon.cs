using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IMIE.Classes
{
    class Pokemon
    {
        private String nom;

        public Pokemon(String nom)
        {
            this.Nom = nom;
        }

        public String Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
    }
}
