namespace MiniAnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAnalizar = new System.Windows.Forms.Button();
            this.TextBoxEntrada = new System.Windows.Forms.TextBox();
            this.LabelEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAnalizar
            // 
            this.botonAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAnalizar.Location = new System.Drawing.Point(619, 99);
            this.botonAnalizar.Name = "botonAnalizar";
            this.botonAnalizar.Size = new System.Drawing.Size(118, 47);
            this.botonAnalizar.TabIndex = 0;
            this.botonAnalizar.Text = "Analizar";
            this.botonAnalizar.UseVisualStyleBackColor = true;
            // 
            // TextBoxEntrada
            // 
            this.TextBoxEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEntrada.Location = new System.Drawing.Point(12, 52);
            this.TextBoxEntrada.Name = "TextBoxEntrada";
            this.TextBoxEntrada.Size = new System.Drawing.Size(725, 29);
            this.TextBoxEntrada.TabIndex = 1;
            // 
            // LabelEntrada
            // 
            this.LabelEntrada.AutoSize = true;
            this.LabelEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntrada.Location = new System.Drawing.Point(348, 9);
            this.LabelEntrada.Name = "LabelEntrada";
            this.LabelEntrada.Size = new System.Drawing.Size(88, 26);
            this.LabelEntrada.TabIndex = 2;
            this.LabelEntrada.Text = "Entrada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 158);
            this.Controls.Add(this.LabelEntrada);
            this.Controls.Add(this.TextBoxEntrada);
            this.Controls.Add(this.botonAnalizar);
            this.Name = "Form1";
            this.Text = "Analizador Lexico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAnalizar;
        private System.Windows.Forms.TextBox TextBoxEntrada;
        private System.Windows.Forms.Label LabelEntrada;
    }
}

