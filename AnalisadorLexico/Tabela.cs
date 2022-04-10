using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    internal class Tabela
    {
        int posicao;
        Token token;
        public Tabela(int pos,Token token) {
          this.token=token;
          this.posicao=pos;
        }
        public int posicaoGet { get { return posicao; } }
        public int posicaoSet { set { posicao = value; } }
        public Token TokenGet { get { return token; } }
        public Token TokenSet { set { token = value; } }
    }
}
