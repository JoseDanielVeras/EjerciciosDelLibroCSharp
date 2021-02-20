
namespace Tarea4.Capitulo8
{
    partial class Ejercicio3
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
            this.HoraLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.FechaTextBox = new System.Windows.Forms.TextBox();
            this.MostrarHoraFechaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.Location = new System.Drawing.Point(28, 37);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(55, 28);
            this.HoraLabel.TabIndex = 0;
            this.HoraLabel.Text = "Hora";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.Location = new System.Drawing.Point(28, 83);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(62, 28);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "Fecha";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(101, 42);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.Size = new System.Drawing.Size(152, 23);
            this.HoraTextBox.TabIndex = 2;
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.Location = new System.Drawing.Point(101, 88);
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(152, 23);
            this.FechaTextBox.TabIndex = 3;
            // 
            // MostrarHoraFechaButton
            // 
            this.MostrarHoraFechaButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MostrarHoraFechaButton.Location = new System.Drawing.Point(52, 142);
            this.MostrarHoraFechaButton.Name = "MostrarHoraFechaButton";
            this.MostrarHoraFechaButton.Size = new System.Drawing.Size(167, 33);
            this.MostrarHoraFechaButton.TabIndex = 4;
            this.MostrarHoraFechaButton.Text = "Mostrar Hora y Fecha";
            this.MostrarHoraFechaButton.UseVisualStyleBackColor = true;
            this.MostrarHoraFechaButton.Click += new System.EventHandler(this.MostrarHoraFechaButton_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 225);
            this.Controls.Add(this.MostrarHoraFechaButton);
            this.Controls.Add(this.FechaTextBox);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.HoraLabel);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.TextBox FechaTextBox;
        private System.Windows.Forms.Button MostrarHoraFechaButton;
    }
}