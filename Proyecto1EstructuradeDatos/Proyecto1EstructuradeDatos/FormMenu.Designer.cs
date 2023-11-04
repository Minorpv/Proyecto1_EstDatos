namespace Proyecto1EstructuradeDatos
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.labelTituloMenu = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.groupBoxPedido = new System.Windows.Forms.GroupBox();
            this.comboBoxMod = new System.Windows.Forms.ComboBox();
            this.comboBoxAgregar = new System.Windows.Forms.ComboBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.BievenidoNombre = new System.Windows.Forms.Label();
            this.labelNombreMenu = new System.Windows.Forms.Label();
            this.textBoxNombreMenu = new System.Windows.Forms.TextBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_lista_prod = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloMenu
            // 
            this.labelTituloMenu.AutoSize = true;
            this.labelTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTituloMenu.Location = new System.Drawing.Point(343, 9);
            this.labelTituloMenu.Name = "labelTituloMenu";
            this.labelTituloMenu.Size = new System.Drawing.Size(103, 39);
            this.labelTituloMenu.TabIndex = 0;
            this.labelTituloMenu.Text = "Menu";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(23, 56);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(23, 126);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 2;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            // 
            // groupBoxPedido
            // 
            this.groupBoxPedido.Controls.Add(this.comboBoxMod);
            this.groupBoxPedido.Controls.Add(this.comboBoxAgregar);
            this.groupBoxPedido.Controls.Add(this.buttonMod);
            this.groupBoxPedido.Controls.Add(this.buttonAgregar);
            this.groupBoxPedido.Location = new System.Drawing.Point(12, 131);
            this.groupBoxPedido.Name = "groupBoxPedido";
            this.groupBoxPedido.Size = new System.Drawing.Size(389, 174);
            this.groupBoxPedido.TabIndex = 4;
            this.groupBoxPedido.TabStop = false;
            this.groupBoxPedido.Text = "Pedido";
            // 
            // comboBoxMod
            // 
            this.comboBoxMod.FormattingEnabled = true;
            this.comboBoxMod.Location = new System.Drawing.Point(133, 128);
            this.comboBoxMod.Name = "comboBoxMod";
            this.comboBoxMod.Size = new System.Drawing.Size(210, 21);
            this.comboBoxMod.TabIndex = 5;
            // 
            // comboBoxAgregar
            // 
            this.comboBoxAgregar.FormattingEnabled = true;
            this.comboBoxAgregar.Items.AddRange(new object[] {
            "Pollo",
            "Res",
            "Cerdo",
            "Lasagna",
            "Chopsuey",
            "Canelones",
            "Bebida Natural"});
            this.comboBoxAgregar.Location = new System.Drawing.Point(133, 57);
            this.comboBoxAgregar.Name = "comboBoxAgregar";
            this.comboBoxAgregar.Size = new System.Drawing.Size(210, 21);
            this.comboBoxAgregar.TabIndex = 4;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPedido.Location = new System.Drawing.Point(550, 71);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(79, 25);
            this.labelPedido.TabIndex = 5;
            this.labelPedido.Text = "Pedido";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(84, 388);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(257, 40);
            this.buttonEnviar.TabIndex = 7;
            this.buttonEnviar.Text = "Enviar pedido";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // BievenidoNombre
            // 
            this.BievenidoNombre.AutoSize = true;
            this.BievenidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BievenidoNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BievenidoNombre.Location = new System.Drawing.Point(12, 73);
            this.BievenidoNombre.Name = "BievenidoNombre";
            this.BievenidoNombre.Size = new System.Drawing.Size(0, 39);
            this.BievenidoNombre.TabIndex = 9;
            // 
            // labelNombreMenu
            // 
            this.labelNombreMenu.AutoSize = true;
            this.labelNombreMenu.Location = new System.Drawing.Point(60, 95);
            this.labelNombreMenu.Name = "labelNombreMenu";
            this.labelNombreMenu.Size = new System.Drawing.Size(50, 13);
            this.labelNombreMenu.TabIndex = 10;
            this.labelNombreMenu.Text = "Nombre: ";
            // 
            // textBoxNombreMenu
            // 
            this.textBoxNombreMenu.Location = new System.Drawing.Point(145, 92);
            this.textBoxNombreMenu.Name = "textBoxNombreMenu";
            this.textBoxNombreMenu.Size = new System.Drawing.Size(210, 20);
            this.textBoxNombreMenu.TabIndex = 11;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(60, 339);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 13);
            this.labelHora.TabIndex = 12;
            this.labelHora.Text = "Hora:";
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(145, 336);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(210, 20);
            this.textBoxHora.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_lista_prod
            // 
            this.button_lista_prod.Location = new System.Drawing.Point(13, 13);
            this.button_lista_prod.Name = "button_lista_prod";
            this.button_lista_prod.Size = new System.Drawing.Size(121, 23);
            this.button_lista_prod.TabIndex = 14;
            this.button_lista_prod.Text = "Lista de productos";
            this.button_lista_prod.UseVisualStyleBackColor = true;
            this.button_lista_prod.Click += new System.EventHandler(this.button_lista_prod_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(424, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 329);
            this.listBox1.TabIndex = 15;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_lista_prod);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.textBoxNombreMenu);
            this.Controls.Add(this.labelNombreMenu);
            this.Controls.Add(this.BievenidoNombre);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.groupBoxPedido);
            this.Controls.Add(this.labelTituloMenu);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBoxPedido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloMenu;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.GroupBox groupBoxPedido;
        private System.Windows.Forms.ComboBox comboBoxMod;
        private System.Windows.Forms.ComboBox comboBoxAgregar;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label BievenidoNombre;
        private System.Windows.Forms.Label labelNombreMenu;
        private System.Windows.Forms.TextBox textBoxNombreMenu;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_lista_prod;
        private System.Windows.Forms.ListBox listBox1;
    }
}