using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMobiele
{
    public class AllDataRepository
    {
        public List<Kleuter> AllKleuters { get; set; }

        public List<Gezin> AllGezins { get; set; }

        public List<Klas> AllKlassen { get; set; }

        public List<Hoek> AllHoeken { get; set; }

        public List<Foto> AllFotos { get; set; }

        public List<Leerkracht> AllLeerkrachten { get; set; }

        public List<School> AllScholen { get; set; }
    }
}
