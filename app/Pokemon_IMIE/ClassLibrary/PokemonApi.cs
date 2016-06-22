using ClassLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PokemonApi
    {
        private long id;
        private String name;
        private String logo;
        private int hp;
        private int maxHp;

        public PokemonApi()
        {

        }

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
    }
}
