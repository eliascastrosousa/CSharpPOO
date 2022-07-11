using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Notas {
    public class Aluno {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public void PesoNota() {
            nota1 = (nota1 * 30) / 10;
            nota2 = (nota2 * 35) / 10;
            nota3 = (nota3 * 35) / 10;
        }
        public double AlunoNotas() {
            return (nota1 + nota2 + nota3);
        }


    }


}
