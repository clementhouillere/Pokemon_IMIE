using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IMIE.Model
{
    public class Attaque
    {
        private long id;
        private String name;
        private int puissance;

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

        public int Puissance
        {
            get
            {
                return puissance;
            }

            set
            {
                puissance = value;
            }
        }
    }
}
