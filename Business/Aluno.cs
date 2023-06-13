using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Aluno : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int ID { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Cpf { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string RG { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Endereco { get; set; }
        
        [OpcoesBase(UsaBD = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Faculdade { get; set; }

        [OpcoesBase(UsaBD = true)]
        public double Valor { get; set; }
        public new List<Aluno> Todos()
        {
            List<Aluno> al = new List<Aluno>();
            foreach (var ibase in base.Todos())
            {
                al.Add((Aluno)ibase);
            }
            return al;
        }
    }
}
