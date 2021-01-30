
namespace Tarea3.Capitulo6
{
    partial class Ejercicio6_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.AnadirBotton = new System.Windows.Forms.Button();
            this.CalificacionesListBox = new System.Windows.Forms.ListBox();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxSalones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalifMenorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Promedio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Agregar Califiaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite la Cantidad de Salones:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgregarButton.Location = new System.Drawing.Point(246, 84);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(83, 31);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click_1);
            // 
            // AnadirBotton
            // 
            this.AnadirBotton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnadirBotton.Location = new System.Drawing.Point(297, 39);
            this.AnadirBotton.Name = "AnadirBotton";
            this.AnadirBotton.Size = new System.Drawing.Size(119, 33);
            this.AnadirBotton.TabIndex = 11;
            this.AnadirBotton.Text = "Añadir Alumnos";
            this.AnadirBotton.UseVisualStyleBackColor = true;
            this.AnadirBotton.Click += new System.EventHandler(this.AnadirBotton_Click_1);
            // 
            // CalificacionesListBox
            // 
            this.CalificacionesListBox.FormattingEnabled = true;
            this.CalificacionesListBox.ItemHeight = 15;
            this.CalificacionesListBox.Location = new System.Drawing.Point(102, 217);
            this.CalificacionesListBox.Name = "CalificacionesListBox";
            this.CalificacionesListBox.Size = new System.Drawing.Size(235, 184);
            this.CalificacionesListBox.TabIndex = 10;
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(185, 130);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(54, 23);
            this.textBoxPromedio.TabIndex = 9;
            // 
            // textBoxSalones
            // 
            this.textBoxSalones.Location = new System.Drawing.Point(245, 45);
            this.textBoxSalones.Name = "textBoxSalones";
            this.textBoxSalones.Size = new System.Drawing.Size(46, 23);
            this.textBoxSalones.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Calificacion Menor:";
            // 
            // CalifMenorTextBox
            // 
            this.CalifMenorTextBox.Location = new System.Drawing.Point(185, 169);
            this.CalifMenorTextBox.Name = "CalifMenorTextBox";
            this.CalifMenorTextBox.Size = new System.Drawing.Size(54, 23);
            this.CalifMenorTextBox.TabIndex = 16;
            // 
            // Ejercicio6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalifMenorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.AnadirBotton);
            this.Controls.Add(this.CalificacionesListBox);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.textBoxSalones);
            this.Name = "Ejercicio6_2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button AnadirBotton;
        private System.Windows.Forms.ListBox CalificacionesListBox;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.TextBox textBoxSalones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CalifMenorTextBox;
    }
}