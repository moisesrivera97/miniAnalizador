using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAnalizadorLexico
{
    class AnalizadorLexico
    {
        private List<Token> salida;
        private int estado;
        private string auxLex;

        public List<Token> escanear(string entrada)
        {
            entrada = string.Concat(entrada.Where(l => !char.IsWhiteSpace(l)));
            entrada = entrada + "#";
            salida = new List<Token>();
            estado = 0;
            auxLex = "";
            char c;

            for(int i = 0; i < entrada.Length - 1; i++)
            {
                c = entrada[i];

                switch (estado)
                {
                    case 0:
                        {
                            if (char.IsDigit(c))
                            {

                            }
                            break;
                        }
                }
            }

            return salida;
        }

        private void addToken(Token.Tipo tipo)
        {
            salida.Add(new Token(tipo, auxLex));
            auxLex = "";
        }
    }
}
