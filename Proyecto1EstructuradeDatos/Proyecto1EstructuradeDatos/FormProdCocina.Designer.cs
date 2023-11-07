namespace Proyecto1EstructuradeDatos
{
    partial class FormProdCocina
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
            this.listBoxColaProd = new System.Windows.Forms.ListBox();
            this.label_TituloProdCocina = new System.Windows.Forms.Label();
            this.buttonProdComp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxColaProd
            // 
            this.listBoxColaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxColaProd.FormattingEnabled = true;
            this.listBoxColaProd.Location = new System.Drawing.Point(12, 83);
            this.listBoxColaProd.Name = "listBoxColaProd";
            this.listBoxColaProd.Size = new System.Drawing.Size(775, 303);
            this.listBoxColaProd.TabIndex = 6;
            // 
            // label_TituloProdCocina
            // 
            this.label_TituloProdCocina.AutoSize = true;
            this.label_TituloProdCocina.BackColor = System.Drawing.SystemColors.Control;
            this.label_TituloProdCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloProdCocina.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_TituloProdCocina.Location = new System.Drawing.Point(11, 18);
            this.label_TituloProdCocina.Name = "label_TituloProdCocina";
            this.label_TituloProdCocina.Size = new System.Drawing.Size(393, 33);
            this.label_TituloProdCocina.TabIndex = 5;
            this.label_TituloProdCocina.Text = "Cola de Productos en Cocina";
            // 
            // buttonProdComp
            // 
            this.buttonProdComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonProdComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProdComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProdComp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonProdComp.Location = new System.Drawing.Point(609, 4);
            this.buttonProdComp.Name = "buttonProdComp";
            this.buttonProdComp.Size = new System.Drawing.Size(178, 71);
            this.buttonProdComp.TabIndex = 4;
            this.buttonProdComp.Text = "Producto Completado";
            this.buttonProdComp.UseVisualStyleBackColor = false;
            this.buttonProdComp.Click += new System.EventHandler(this.buttonProdComp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona el pedido de más abajo";
            // 
            // FormProdCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxColaProd);
            this.Controls.Add(this.label_TituloProdCocina);
            this.Controls.Add(this.buttonProdComp);
            this.Name = "FormProdCocina";
            this.Text = "Productos en cocina";
            this.Load += new System.EventHandler(this.FormProdCocina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxColaProd;
        private System.Windows.Forms.Label label_TituloProdCocina;
        private System.Windows.Forms.Button buttonProdComp;
        private System.Windows.Forms.Label label1;
    }
}