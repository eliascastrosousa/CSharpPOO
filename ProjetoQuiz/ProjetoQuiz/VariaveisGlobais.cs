using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuiz {
    internal class VariaveisGlobais {
        public int PontoCerto = 0;
        public int PontoErrado = 0;

        public void ZerarVariaveis() {
            PontoCerto = 0;
            PontoErrado = 0;
        }

        public int MostrarPontuacao() {
            return PontoCerto;
        }

        public int MostrarPontuacaoErrada() {
            return PontoErrado;
        }

        public void AdicionarPontoCerto() { 
            PontoCerto +=1;
        }
        public void AdicionarPontoErrado() {
            PontoErrado += 1;
        }


    }
}
