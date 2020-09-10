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

            for(int i = 0; i <= entrada.Length - 1; i++)
            {
                c = entrada[i];

                switch (estado)
                {
                    case 0:
                        {
                            if (char.IsDigit(c))
                            {
                                estado = 1;
                                auxLex += c;
                            }
                            else if (char.IsLetter(c))
                            {
                                estado = 2;
                                auxLex += c;
                            }
                            else
                            {
                                MessageBox.Show("Error léxico, Solo se puede iniciar con un identificador o un número real");
                            }
                            break;
                        }
                    case 1:
                        {
                            if(c.ToString() == ".")
                            {
                                estado = 3;
                                auxLex += c;
                            }
                            else
                            {
                                MessageBox.Show("Error léxico, Solo se permite un número entero con punto decimal");
                                goto endProgram;
                            }
                            break;
                        }
                    case 2:
                        {
                            if(c.ToString() == "#" && i == entrada.Length - 1)
                            {
                                addToken(Token.Tipo.IDENTIFICADOR);
                                MessageBox.Show("Analizador léxico terminado");
                            }
                            else if(char.IsLetter(c) || char.IsDigit(c))
                            {
                                auxLex += c;
                            }
                            else
                            {
                                MessageBox.Show("Error léxico, los identificadores solo pueden contener letras y números");
                                goto endProgram;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (char.IsDigit(c))
                            {
                                estado = 4;
                                auxLex += c;
                            }
                            else
                            {
                                MessageBox.Show("Error léxico, Se requiere al menos un número entero después del punto");
                                goto endProgram;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (c.ToString() == "#" && i == entrada.Length - 1)
                            {
                                addToken(Token.Tipo.REAL);
                                MessageBox.Show("Analizador léxico terminado");
                            }
                            else if(char.IsDigit(c))
                            {
                                auxLex += c;
                            }
                            else
                            {
                                MessageBox.Show("Error léxico, los números reales solo permiten números");
                                goto endProgram;
                            }
                            break;
                        }
                }
            }
            endProgram:
            return salida;
        }

        private void addToken(Token.Tipo tipo)
        {
            salida.Add(new Token(tipo, auxLex));
            auxLex = "";
        }
    }
}
