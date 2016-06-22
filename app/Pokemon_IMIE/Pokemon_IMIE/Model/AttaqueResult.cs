using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_IMIE.Model
{
    class AttaqueResult
    {
        public object vainqueur { get; set; }
        public string attaqueDuDefenseur { get; set; }
        public int puissanceDuDefenseur { get; set; }
        public int vieDuDefenseur { get; set; }
        public int vieMaxDuDefenseur { get; set; }
        public int vieAttaquant { get; set; }
        public int vieMaxAttaquant { get; set; }
    }
}
