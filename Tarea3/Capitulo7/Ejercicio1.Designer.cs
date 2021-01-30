
namespace Tarea3.Capitulo7
{
    partial class Ejercicio1
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelTexto = new System.Windows.Forms.Label();
            this.textBoxCalificacion = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.labelCaliMinima = new System.Windows.Forms.Label();
            this.labelCaliMaxima = new System.Windows.Forms.Label();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxCaliMaxima = new System.Windows.Forms.TextBox();
            this.textBoxCaliMinima = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LabelTitulo.Location = new System.Drawing.Point(115, 18);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(581, 21);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Programa Que Calcula El Promedio La Calificación Maxíma y Mínima De Una Clase";
            // 
            // LabelTexto
            // 
            this.LabelTexto.AutoSize = true;
            this.LabelTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTexto.Location = new System.Drawing.Point(315, 94);
            this.LabelTexto.Name = "LabelTexto";
            this.LabelTexto.Size = new System.Drawing.Size(148, 20);
            this.LabelTexto.TabIndex = 1;
            this.LabelTexto.Text = "Digite la calificación:";
            // 
            // textBoxCalificacion
            // 
            this.textBoxCalificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCalificacion.Location = new System.Drawing.Point(319, 122);
            this.textBoxCalificacion.Multiline = true;
            this.textBoxCalificacion.Name = "textBoxCalificacion";
            this.textBoxCalificacion.Size = new System.Drawing.Size(55, 34);
            this.textBoxCalificacion.TabIndex = 2;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(380, 122);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(83, 34);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(319, 171);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(144, 43);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPromedio.Location = new System.Drawing.Point(293, 238);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(81, 21);
            this.labelPromedio.TabIndex = 5;
            this.labelPromedio.Text = "Promedio:";
            // 
            // labelCaliMinima
            // 
            this.labelCaliMinima.AutoSize = true;
            this.labelCaliMinima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCaliMinima.Location = new System.Drawing.Point(226, 321);
            this.labelCaliMinima.Name = "labelCaliMinima";
            this.labelCaliMinima.Size = new System.Drawing.Size(149, 21);
            this.labelCaliMinima.TabIndex = 6;
            this.labelCaliMinima.Text = "Calificacion Minima:";
            // 
            // labelCaliMaxima
            // 
            this.labelCaliMaxima.AutoSize = true;
            this.labelCaliMaxima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCaliMaxima.Location = new System.Drawing.Point(223, 280);
            this.labelCaliMaxima.Name = "labelCaliMaxima";
            this.labelCaliMaxima.Size = new System.Drawing.Size(151, 21);
            this.labelCaliMaxima.TabIndex = 7;
            this.labelCaliMaxima.Text = "Calificacion Maxima:";
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(380, 238);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(83, 23);
            this.textBoxPromedio.TabIndex = 8;
            // 
            // textBoxCaliMaxima
            // 
            this.textBoxCaliMaxima.Location = new System.Drawing.Point(380, 278);
            this.textBoxCaliMaxima.Name = "textBoxCaliMaxima";
            this.textBoxCaliMaxima.Size = new System.Drawing.Size(83, 23);
            this.textBoxCaliMaxima.TabIndex = 9;
            // 
            // textBoxCaliMinima
            // 
            this.textBoxCaliMinima.Location = new System.Drawing.Point(380, 319);
            this.textBoxCaliMinima.Name = "textBoxCaliMinima";
            this.textBoxCaliMinima.Size = new System.Drawing.Size(83, 23);
            this.textBoxCaliMinima.TabIndex = 10;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCaliMinima);
            this.Controls.Add(this.textBoxCaliMaxima);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.labelCaliMaxima);
            this.Controls.Add(this.labelCaliMinima);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxCalificacion);
            this.Controls.Add(this.LabelTexto);
            this.Controls.Add(this.LabelTitulo);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelTexto;
        private System.Windows.Forms.TextBox textBoxCalificacion;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.Label labelCaliMinima;
        private System.Windows.Forms.Label labelCaliMaxima;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.TextBox textBoxCaliMaxima;
        private System.Windows.Forms.TextBox textBoxCaliMinima;
    }
}