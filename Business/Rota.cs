using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Rota : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int ID { get; set; }

        [OpcoesBase(UsaBD = true)]
        public int Numero { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string pontoReferecia { get; set; }

        public new List<Rota> Todos()
        {
            List<Rota> rot = new List<Rota>();
            foreach (var ibase in base.Todos())
            {
                rot.Add((Rota)ibase);
            }
            return rot;
        }
    }
}
