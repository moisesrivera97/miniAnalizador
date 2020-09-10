using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAnalizadorLexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxEntrada.Text = "";
        }

        private void BotonAnalizar_Click(object sender, EventArgs e)
        {
            AnalizadorLexico anaLex = new AnalizadorLexico();
            List<Token> listaTokens = anaLex.escanear(TextBoxEntrada.Text);

            foreach (Token t in listaTokens)
            {
                MessageBox.Show(t.getTipo().ToString() + ", " + t.getValor().ToString());
            }
        }
    }
}
