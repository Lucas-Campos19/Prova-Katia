using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Onibus : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int ID { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Destino { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Horario { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Motorista { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Aluno { get; set; }

        [OpcoesBase(UsaBD = true)]
      
        public new List<Onibus> Todos()
        {
            List<Onibus> oni = new List<Onibus>();
            foreach (var ibase in base.Todos())
            {
                oni.Add((Onibus)ibase);
            }
            return oni;
        }
    }
}
