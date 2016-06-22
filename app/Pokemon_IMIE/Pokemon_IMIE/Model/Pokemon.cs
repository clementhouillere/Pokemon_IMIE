using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IMIE.Model
{
    public class Pokemon
    {
        private long id;
        private String name;
        private String logo;
        private int hp;
        private int maxHp;
        private Dresseur dresseur;
        private List<Attaque> attaques;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Logo
        {
            get
            {
                return logo;
            }

            set
            {
                logo = value;
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public int MaxHp
        {
            get
            {
                return maxHp;
            }

            set
            {
                maxHp = value;
            }
        }

        public Dresseur Dresseur
        {
            get
            {
                return dresseur;
            }

            set
            {
                dresseur = value;
            }
        }

        public List<Attaque> Attaques
        {
            get
            {
                return attaques;
            }

            set
            {
                attaques = value;
            }
        }
    }
}
