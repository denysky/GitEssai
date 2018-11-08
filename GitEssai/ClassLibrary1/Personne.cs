using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light

{
    public class Personne
    {
        public string Name{ get; set; }
        public Personne(string name)
        {
            Name = name;
        }
        public Personne()
        {
            Name = "Toto";
        }
    }
}
