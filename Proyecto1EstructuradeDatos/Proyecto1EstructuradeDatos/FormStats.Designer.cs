namespace Proyecto1EstructuradeDatos
{
    partial class FormStats
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
            this.listBoxPedRealizado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPedHechos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPromEspera = new System.Windows.Forms.TextBox();
            this.textBoxPedxHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadísticas";
            // 
            // listBoxPedRealizado
            // 
            this.listBoxPedRealizado.FormattingEnabled = true;
            this.listBoxPedRealizado.Location = new System.Drawing.Point(13, 69);
            this.listBoxPedRealizado.Name = "listBoxPedRealizado";
            this.listBoxPedRealizado.Size = new System.Drawing.Size(540, 303);
            this.listBoxPedRealizado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedidos hechos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total de pedidos realizados:";
            // 
            // textBoxPedHechos
            // 
            this.textBoxPedHechos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPedHechos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPedHechos.Location = new System.Drawing.Point(574, 88);
            this.textBoxPedHechos.Name = "textBoxPedHechos";
            this.textBoxPedHechos.ReadOnly = true;
            this.textBoxPedHechos.Size = new System.Drawing.Size(202, 20);
            this.textBoxPedHechos.TabIndex = 4;
            this.textBoxPedHechos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiempo promedio de espera:";
            // 
            // textBoxPromEspera
            // 
            this.textBoxPromEspera.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPromEspera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPromEspera.Location = new System.Drawing.Point(574, 193);
            this.textBoxPromEspera.Name = "textBoxPromEspera";
            this.textBoxPromEspera.ReadOnly = true;
            this.textBoxPromEspera.Size = new System.Drawing.Size(202, 20);
            this.textBoxPromEspera.TabIndex = 6;
            this.textBoxPromEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPedxHora
            // 
            this.textBoxPedxHora.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPedxHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPedxHora.Location = new System.Drawing.Point(574, 298);
            this.textBoxPedxHora.Name = "textBoxPedxHora";
            this.textBoxPedxHora.ReadOnly = true;
            this.textBoxPedxHora.Size = new System.Drawing.Size(202, 20);
            this.textBoxPedxHora.TabIndex = 8;
            this.textBoxPedxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Promedio de pedidos por hora:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(574, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar Estadísticas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPedxHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPromEspera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPedHechos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPedRealizado);
            this.Controls.Add(this.label1);
            this.Name = "FormStats";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPedRealizado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPedHechos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPromEspera;
        private System.Windows.Forms.TextBox textBoxPedxHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}