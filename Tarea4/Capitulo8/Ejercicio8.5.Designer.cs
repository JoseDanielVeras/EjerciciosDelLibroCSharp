
namespace Tarea4.Capitulo8
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
            this.CadenaUnoLabel = new System.Windows.Forms.Label();
            this.CadenaDosLabel = new System.Windows.Forms.Label();
            this.CadenaUnoTextBox = new System.Windows.Forms.TextBox();
            this.CadenaDosTextBox = new System.Windows.Forms.TextBox();
            this.OrdenarButton = new System.Windows.Forms.Button();
            this.OrdenarlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CadenaUnoLabel
            // 
            this.CadenaUnoLabel.AutoSize = true;
            this.CadenaUnoLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadenaUnoLabel.Location = new System.Drawing.Point(12, 26);
            this.CadenaUnoLabel.Name = "CadenaUnoLabel";
            this.CadenaUnoLabel.Size = new System.Drawing.Size(90, 20);
            this.CadenaUnoLabel.TabIndex = 0;
            this.CadenaUnoLabel.Text = "Cadena Uno";
            // 
            // CadenaDosLabel
            // 
            this.CadenaDosLabel.AutoSize = true;
            this.CadenaDosLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadenaDosLabel.Location = new System.Drawing.Point(12, 76);
            this.CadenaDosLabel.Name = "CadenaDosLabel";
            this.CadenaDosLabel.Size = new System.Drawing.Size(89, 20);
            this.CadenaDosLabel.TabIndex = 1;
            this.CadenaDosLabel.Text = "Cadena Dos";
            // 
            // CadenaUnoTextBox
            // 
            this.CadenaUnoTextBox.Location = new System.Drawing.Point(108, 23);
            this.CadenaUnoTextBox.Name = "CadenaUnoTextBox";
            this.CadenaUnoTextBox.Size = new System.Drawing.Size(164, 23);
            this.CadenaUnoTextBox.TabIndex = 2;
            // 
            // CadenaDosTextBox
            // 
            this.CadenaDosTextBox.Location = new System.Drawing.Point(108, 73);
            this.CadenaDosTextBox.Name = "CadenaDosTextBox";
            this.CadenaDosTextBox.Size = new System.Drawing.Size(164, 23);
            this.CadenaDosTextBox.TabIndex = 3;
            // 
            // OrdenarButton
            // 
            this.OrdenarButton.Location = new System.Drawing.Point(108, 110);
            this.OrdenarButton.Name = "OrdenarButton";
            this.OrdenarButton.Size = new System.Drawing.Size(75, 23);
            this.OrdenarButton.TabIndex = 4;
            this.OrdenarButton.Text = "Ordenar";
            this.OrdenarButton.UseVisualStyleBackColor = true;
            this.OrdenarButton.Click += new System.EventHandler(this.OrdenarButton_Click);
            // 
            // OrdenarlistBox
            // 
            this.OrdenarlistBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdenarlistBox.FormattingEnabled = true;
            this.OrdenarlistBox.ItemHeight = 20;
            this.OrdenarlistBox.Location = new System.Drawing.Point(12, 147);
            this.OrdenarlistBox.Name = "OrdenarlistBox";
            this.OrdenarlistBox.Size = new System.Drawing.Size(260, 104);
            this.OrdenarlistBox.TabIndex = 5;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.OrdenarlistBox);
            this.Controls.Add(this.OrdenarButton);
            this.Controls.Add(this.CadenaDosTextBox);
            this.Controls.Add(this.CadenaUnoTextBox);
            this.Controls.Add(this.CadenaDosLabel);
            this.Controls.Add(this.CadenaUnoLabel);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadenaUnoLabel;
        private System.Windows.Forms.Label CadenaDosLabel;
        private System.Windows.Forms.TextBox CadenaUnoTextBox;
        private System.Windows.Forms.TextBox CadenaDosTextBox;
        private System.Windows.Forms.Button OrdenarButton;
        private System.Windows.Forms.ListBox OrdenarlistBox;
    }
}