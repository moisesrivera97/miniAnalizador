using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAnalizadorLexico
{
    class AnalizadorLexico
    {
        private List<Token> salida;
        private int estado;
        private string auxLex;

        public List<Token> escanear(string entrada)
        {
            entrada = entrada + "#";
            salida = new List<Token>();
            estado = 0;
            auxLex = "";
            char c;

            return salida;
        }

        private void addToken(Token.Tipo tipo)
        {
            salida.Add(new Token(tipo, auxLex));
            auxLex = "";
        }
    }
}
