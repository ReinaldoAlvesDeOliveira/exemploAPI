using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploAPI.Models
{
    public class NCM
    {
        internal readonly object id;

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public char Ativo { get; set; }

    }
}
