using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAnalizadorLexico
{
    class Token
    {
        public enum Tipo
        {
            REAL,
            IDENTIFICADOR,
        }

        private Tipo tipoToken;
        private string valor;

        public Token(Tipo tipo, string auxLex)
        {
            this.tipoToken = tipo;
            this.valor = auxLex;
        }

        public Tipo getTipo()
        {
            return tipoToken;
        }
        public string getValor()
        {
            return valor;
        }
    }
}
