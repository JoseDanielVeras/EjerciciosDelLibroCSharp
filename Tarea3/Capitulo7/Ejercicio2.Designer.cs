
namespace Tarea3.Capitulo7
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxSignifica = new System.Windows.Forms.TextBox();
            this.labelSignificado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa Que Funciona Como Un Diccionario";
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPalabra.Location = new System.Drawing.Point(197, 93);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(136, 20);
            this.labelPalabra.TabIndex = 1;
            this.labelPalabra.Text = "Digite una palabra:";
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Location = new System.Drawing.Point(339, 93);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(118, 23);
            this.textBoxPalabra.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(475, 92);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 25);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxSignifica
            // 
            this.textBoxSignifica.Location = new System.Drawing.Point(197, 195);
            this.textBoxSignifica.Multiline = true;
            this.textBoxSignifica.Name = "textBoxSignifica";
            this.textBoxSignifica.Size = new System.Drawing.Size(353, 89);
            this.textBoxSignifica.TabIndex = 4;
            // 
            // labelSignificado
            // 
            this.labelSignificado.AutoSize = true;
            this.labelSignificado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSignificado.Location = new System.Drawing.Point(339, 172);
            this.labelSignificado.Name = "labelSignificado";
            this.labelSignificado.Size = new System.Drawing.Size(84, 20);
            this.labelSignificado.TabIndex = 5;
            this.labelSignificado.Text = "Significado";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSignificado);
            this.Controls.Add(this.textBoxSignifica);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxPalabra);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxSignifica;
        private System.Windows.Forms.Label labelSignificado;
    }
}