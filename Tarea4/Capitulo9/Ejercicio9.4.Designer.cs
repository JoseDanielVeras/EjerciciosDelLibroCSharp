
namespace Tarea4.Capitulo9
{
    partial class Ejercicio9
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
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.OpcionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumeroLabel.Location = new System.Drawing.Point(37, 22);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(196, 20);
            this.NumeroLabel.TabIndex = 0;
            this.NumeroLabel.Text = "Escriba un numero del 1 al 8";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(86, 66);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumeroTextBox.TabIndex = 1;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(99, 113);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 2;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // OpcionTextBox
            // 
            this.OpcionTextBox.Location = new System.Drawing.Point(37, 158);
            this.OpcionTextBox.Name = "OpcionTextBox";
            this.OpcionTextBox.Size = new System.Drawing.Size(204, 23);
            this.OpcionTextBox.TabIndex = 3;
            // 
            // Ejercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 217);
            this.Controls.Add(this.OpcionTextBox);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.TextBox OpcionTextBox;
    }
}