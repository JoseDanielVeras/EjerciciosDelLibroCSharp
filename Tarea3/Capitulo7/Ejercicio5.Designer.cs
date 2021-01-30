
namespace Tarea3.Capitulo7
{
    partial class Ejercicio5
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarNombre = new System.Windows.Forms.TextBox();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.labelBuscarTelefono = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonBorar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "programa Que Funcione Como Una Agenda Telefónica";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(197, 86);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(128, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Digite el Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite el Telefóno:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(333, 86);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(155, 23);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(333, 122);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(155, 23);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardar.Location = new System.Drawing.Point(512, 88);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(77, 55);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guargar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuscar.Location = new System.Drawing.Point(509, 230);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(77, 31);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscarNombre
            // 
            this.textBoxBuscarNombre.Location = new System.Drawing.Point(330, 235);
            this.textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            this.textBoxBuscarNombre.Size = new System.Drawing.Size(155, 23);
            this.textBoxBuscarNombre.TabIndex = 8;
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBuscarNombre.Location = new System.Drawing.Point(194, 235);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(128, 20);
            this.labelBuscarNombre.TabIndex = 7;
            this.labelBuscarNombre.Text = "Digite el Nombre:";
            // 
            // labelBuscarTelefono
            // 
            this.labelBuscarTelefono.AutoSize = true;
            this.labelBuscarTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBuscarTelefono.Location = new System.Drawing.Point(352, 278);
            this.labelBuscarTelefono.Name = "labelBuscarTelefono";
            this.labelBuscarTelefono.Size = new System.Drawing.Size(104, 20);
            this.labelBuscarTelefono.TabIndex = 9;
            this.labelBuscarTelefono.Text = "El Telefóno es:";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(330, 301);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(155, 23);
            this.textBoxResultado.TabIndex = 10;
            // 
            // buttonBorar
            // 
            this.buttonBorar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBorar.Location = new System.Drawing.Point(509, 295);
            this.buttonBorar.Name = "buttonBorar";
            this.buttonBorar.Size = new System.Drawing.Size(77, 31);
            this.buttonBorar.TabIndex = 11;
            this.buttonBorar.Text = "Borar";
            this.buttonBorar.UseVisualStyleBackColor = true;
            this.buttonBorar.Click += new System.EventHandler(this.buttonBorar_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.buttonBorar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelBuscarTelefono);
            this.Controls.Add(this.textBoxBuscarNombre);
            this.Controls.Add(this.labelBuscarNombre);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarNombre;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.Label labelBuscarTelefono;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonBorar;
    }
}