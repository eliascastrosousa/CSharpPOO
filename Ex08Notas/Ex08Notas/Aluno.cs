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

        public double AlunoNotas() {
            double n1 = ((nota1 * 0.30)/10);
            double n2 = ((nota2 * 0.35) / 10);
            double n3 = ((nota3 * 0.35) / 10);
            return (n1 + n2 + n3)*10;
        }


    }

    
}
