namespace Proyecto1EstructuradeDatos
{
    partial class FormListaProd
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
            this.titulo_listaProd = new System.Windows.Forms.Label();
            this.listBox_Prod = new System.Windows.Forms.ListBox();
            this.button_AgregarProd = new System.Windows.Forms.Button();
            this.button_ModProd = new System.Windows.Forms.Button();
            this.textBox_CodProd = new System.Windows.Forms.TextBox();
            this.label_CodProd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_TipoProd = new System.Windows.Forms.ComboBox();
            this.textBox_NombreProd = new System.Windows.Forms.TextBox();
            this.label_NombreProd = new System.Windows.Forms.Label();
            this.label_TipoProd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_tipoMod = new System.Windows.Forms.ComboBox();
            this.textBox_nomMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_listaProd
            // 
            this.titulo_listaProd.AutoSize = true;
            this.titulo_listaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_listaProd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titulo_listaProd.Location = new System.Drawing.Point(19, 9);
            this.titulo_listaProd.Name = "titulo_listaProd";
            this.titulo_listaProd.Size = new System.Drawing.Size(298, 37);
            this.titulo_listaProd.TabIndex = 0;
            this.titulo_listaProd.Text = "Lista de productos";
            // 
            // listBox_Prod
            // 
            this.listBox_Prod.FormattingEnabled = true;
            this.listBox_Prod.Location = new System.Drawing.Point(26, 65);
            this.listBox_Prod.Name = "listBox_Prod";
            this.listBox_Prod.Size = new System.Drawing.Size(493, 368);
            this.listBox_Prod.TabIndex = 1;
            // 
            // button_AgregarProd
            // 
            this.button_AgregarProd.Location = new System.Drawing.Point(80, 201);
            this.button_AgregarProd.Name = "button_AgregarProd";
            this.button_AgregarProd.Size = new System.Drawing.Size(75, 23);
            this.button_AgregarProd.TabIndex = 2;
            this.button_AgregarProd.Text = "Agregar";
            this.button_AgregarProd.UseVisualStyleBackColor = true;
            this.button_AgregarProd.Click += new System.EventHandler(this.button_AgregarProd_Click);
            // 
            // button_ModProd
            // 
            this.button_ModProd.Location = new System.Drawing.Point(86, 140);
            this.button_ModProd.Name = "button_ModProd";
            this.button_ModProd.Size = new System.Drawing.Size(75, 23);
            this.button_ModProd.TabIndex = 3;
            this.button_ModProd.Text = "Modificar";
            this.button_ModProd.UseVisualStyleBackColor = true;
            this.button_ModProd.Click += new System.EventHandler(this.button_ModProd_Click);
            // 
            // textBox_CodProd
            // 
            this.textBox_CodProd.Location = new System.Drawing.Point(19, 45);
            this.textBox_CodProd.Name = "textBox_CodProd";
            this.textBox_CodProd.Size = new System.Drawing.Size(192, 20);
            this.textBox_CodProd.TabIndex = 4;
            // 
            // label_CodProd
            // 
            this.label_CodProd.AutoSize = true;
            this.label_CodProd.Location = new System.Drawing.Point(16, 29);
            this.label_CodProd.Name = "label_CodProd";
            this.label_CodProd.Size = new System.Drawing.Size(40, 13);
            this.label_CodProd.TabIndex = 5;
            this.label_CodProd.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_TipoProd);
            this.groupBox1.Controls.Add(this.textBox_NombreProd);
            this.groupBox1.Controls.Add(this.label_NombreProd);
            this.groupBox1.Controls.Add(this.label_TipoProd);
            this.groupBox1.Controls.Add(this.button_AgregarProd);
            this.groupBox1.Controls.Add(this.textBox_CodProd);
            this.groupBox1.Controls.Add(this.label_CodProd);
            this.groupBox1.Location = new System.Drawing.Point(548, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Productos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_TipoProd
            // 
            this.comboBox_TipoProd.FormattingEnabled = true;
            this.comboBox_TipoProd.Items.AddRange(new object[] {
            "Bebida",
            "Plato fuerte"});
            this.comboBox_TipoProd.Location = new System.Drawing.Point(19, 150);
            this.comboBox_TipoProd.Name = "comboBox_TipoProd";
            this.comboBox_TipoProd.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipoProd.TabIndex = 9;
            // 
            // textBox_NombreProd
            // 
            this.textBox_NombreProd.Location = new System.Drawing.Point(19, 97);
            this.textBox_NombreProd.Name = "textBox_NombreProd";
            this.textBox_NombreProd.Size = new System.Drawing.Size(192, 20);
            this.textBox_NombreProd.TabIndex = 8;
            // 
            // label_NombreProd
            // 
            this.label_NombreProd.AutoSize = true;
            this.label_NombreProd.Location = new System.Drawing.Point(16, 81);
            this.label_NombreProd.Name = "label_NombreProd";
            this.label_NombreProd.Size = new System.Drawing.Size(44, 13);
            this.label_NombreProd.TabIndex = 7;
            this.label_NombreProd.Text = "Nombre";
            // 
            // label_TipoProd
            // 
            this.label_TipoProd.AutoSize = true;
            this.label_TipoProd.Location = new System.Drawing.Point(16, 133);
            this.label_TipoProd.Name = "label_TipoProd";
            this.label_TipoProd.Size = new System.Drawing.Size(28, 13);
            this.label_TipoProd.TabIndex = 6;
            this.label_TipoProd.Text = "Tipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_tipoMod);
            this.groupBox2.Controls.Add(this.textBox_nomMod);
            this.groupBox2.Controls.Add(this.button_ModProd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(548, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione el producto a modificar";
            // 
            // comboBox_tipoMod
            // 
            this.comboBox_tipoMod.FormattingEnabled = true;
            this.comboBox_tipoMod.Items.AddRange(new object[] {
            "Bebida",
            "Plato fuerte"});
            this.comboBox_tipoMod.Location = new System.Drawing.Point(74, 96);
            this.comboBox_tipoMod.Name = "comboBox_tipoMod";
            this.comboBox_tipoMod.Size = new System.Drawing.Size(137, 21);
            this.comboBox_tipoMod.TabIndex = 9;
            // 
            // textBox_nomMod
            // 
            this.textBox_nomMod.Location = new System.Drawing.Point(74, 53);
            this.textBox_nomMod.Name = "textBox_nomMod";
            this.textBox_nomMod.Size = new System.Drawing.Size(137, 20);
            this.textBox_nomMod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo";
            // 
            // FormListaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Prod);
            this.Controls.Add(this.titulo_listaProd);
            this.Name = "FormListaProd";
            this.Text = "FormListaProd";
            this.Load += new System.EventHandler(this.FormListaProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_listaProd;
        private System.Windows.Forms.ListBox listBox_Prod;
        private System.Windows.Forms.Button button_AgregarProd;
        private System.Windows.Forms.Button button_ModProd;
        private System.Windows.Forms.TextBox textBox_CodProd;
        private System.Windows.Forms.Label label_CodProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_NombreProd;
        private System.Windows.Forms.Label label_TipoProd;
        private System.Windows.Forms.TextBox textBox_NombreProd;
        private System.Windows.Forms.ComboBox comboBox_TipoProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_tipoMod;
        private System.Windows.Forms.TextBox textBox_nomMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}