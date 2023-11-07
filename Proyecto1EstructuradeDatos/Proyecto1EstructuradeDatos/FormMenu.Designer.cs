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
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxModPedido = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAgregarPlato = new System.Windows.Forms.ComboBox();
            this.labelPedido = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.BievenidoNombre = new System.Windows.Forms.Label();
            this.textBoxNombreMenu = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_lista_prod = new System.Windows.Forms.Button();
            this.listBoxProdPedidos = new System.Windows.Forms.ListBox();
            this.buttonProdCocina = new System.Windows.Forms.Button();
            this.buttonListPedido = new System.Windows.Forms.Button();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelNombreMenu = new System.Windows.Forms.Label();
            this.groupBoxPedido = new System.Windows.Forms.GroupBox();
            this.buttonStats = new System.Windows.Forms.Button();
            this.groupBoxModPedido.SuspendLayout();
            this.groupBoxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloMenu
            // 
            this.labelTituloMenu.AutoSize = true;
            this.labelTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTituloMenu.Location = new System.Drawing.Point(257, 9);
            this.labelTituloMenu.Name = "labelTituloMenu";
            this.labelTituloMenu.Size = new System.Drawing.Size(103, 39);
            this.labelTituloMenu.TabIndex = 0;
            this.labelTituloMenu.Text = "Menu";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(194, 38);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(104, 21);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(194, 92);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(104, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Eliminar";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBoxModPedido
            // 
            this.groupBoxModPedido.Controls.Add(this.label1);
            this.groupBoxModPedido.Controls.Add(this.comboBoxAgregarPlato);
            this.groupBoxModPedido.Controls.Add(this.buttonDel);
            this.groupBoxModPedido.Controls.Add(this.buttonAgregar);
            this.groupBoxModPedido.Location = new System.Drawing.Point(9, 107);
            this.groupBoxModPedido.Name = "groupBoxModPedido";
            this.groupBoxModPedido.Size = new System.Drawing.Size(313, 137);
            this.groupBoxModPedido.TabIndex = 4;
            this.groupBoxModPedido.TabStop = false;
            this.groupBoxModPedido.Text = "Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione la linea que desea borrar";
            // 
            // comboBoxAgregarPlato
            // 
            this.comboBoxAgregarPlato.FormattingEnabled = true;
            this.comboBoxAgregarPlato.Location = new System.Drawing.Point(13, 38);
            this.comboBoxAgregarPlato.Name = "comboBoxAgregarPlato";
            this.comboBoxAgregarPlato.Size = new System.Drawing.Size(155, 21);
            this.comboBoxAgregarPlato.TabIndex = 4;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.BackColor = System.Drawing.SystemColors.Window;
            this.labelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPedido.Location = new System.Drawing.Point(104, 46);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(79, 25);
            this.labelPedido.TabIndex = 5;
            this.labelPedido.Text = "Pedido";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(47, 250);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(257, 47);
            this.buttonEnviar.TabIndex = 7;
            this.buttonEnviar.Text = "Enviar pedido";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
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
            // textBoxNombreMenu
            // 
            this.textBoxNombreMenu.Location = new System.Drawing.Point(62, 23);
            this.textBoxNombreMenu.Name = "textBoxNombreMenu";
            this.textBoxNombreMenu.Size = new System.Drawing.Size(210, 20);
            this.textBoxNombreMenu.TabIndex = 11;
            // 
            // textBoxHora
            // 
            this.textBoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHora.Location = new System.Drawing.Point(47, 71);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.ReadOnly = true;
            this.textBoxHora.Size = new System.Drawing.Size(210, 13);
            this.textBoxHora.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_lista_prod
            // 
            this.button_lista_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lista_prod.Location = new System.Drawing.Point(492, 391);
            this.button_lista_prod.Name = "button_lista_prod";
            this.button_lista_prod.Size = new System.Drawing.Size(129, 47);
            this.button_lista_prod.TabIndex = 14;
            this.button_lista_prod.Text = "Lista de productos";
            this.button_lista_prod.UseVisualStyleBackColor = true;
            this.button_lista_prod.Click += new System.EventHandler(this.button_lista_prod_Click);
            // 
            // listBoxProdPedidos
            // 
            this.listBoxProdPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdPedidos.FormattingEnabled = true;
            this.listBoxProdPedidos.Location = new System.Drawing.Point(12, 74);
            this.listBoxProdPedidos.Name = "listBoxProdPedidos";
            this.listBoxProdPedidos.Size = new System.Drawing.Size(262, 303);
            this.listBoxProdPedidos.TabIndex = 15;
            // 
            // buttonProdCocina
            // 
            this.buttonProdCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProdCocina.Location = new System.Drawing.Point(336, 391);
            this.buttonProdCocina.Name = "buttonProdCocina";
            this.buttonProdCocina.Size = new System.Drawing.Size(129, 47);
            this.buttonProdCocina.TabIndex = 16;
            this.buttonProdCocina.Text = "Productos en cocina";
            this.buttonProdCocina.UseVisualStyleBackColor = true;
            this.buttonProdCocina.Click += new System.EventHandler(this.buttonProdCocina_Click);
            // 
            // buttonListPedido
            // 
            this.buttonListPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListPedido.Location = new System.Drawing.Point(174, 391);
            this.buttonListPedido.Name = "buttonListPedido";
            this.buttonListPedido.Size = new System.Drawing.Size(129, 47);
            this.buttonListPedido.TabIndex = 17;
            this.buttonListPedido.Text = "Lista de Pedidos";
            this.buttonListPedido.UseVisualStyleBackColor = true;
            this.buttonListPedido.Click += new System.EventHandler(this.buttonListPedido_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(8, 71);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 13);
            this.labelHora.TabIndex = 12;
            this.labelHora.Text = "Hora:";
            // 
            // labelNombreMenu
            // 
            this.labelNombreMenu.AutoSize = true;
            this.labelNombreMenu.Location = new System.Drawing.Point(6, 26);
            this.labelNombreMenu.Name = "labelNombreMenu";
            this.labelNombreMenu.Size = new System.Drawing.Size(50, 13);
            this.labelNombreMenu.TabIndex = 10;
            this.labelNombreMenu.Text = "Nombre: ";
            // 
            // groupBoxPedido
            // 
            this.groupBoxPedido.Controls.Add(this.labelNombreMenu);
            this.groupBoxPedido.Controls.Add(this.groupBoxModPedido);
            this.groupBoxPedido.Controls.Add(this.buttonEnviar);
            this.groupBoxPedido.Controls.Add(this.textBoxNombreMenu);
            this.groupBoxPedido.Controls.Add(this.labelHora);
            this.groupBoxPedido.Controls.Add(this.textBoxHora);
            this.groupBoxPedido.Location = new System.Drawing.Point(289, 70);
            this.groupBoxPedido.Name = "groupBoxPedido";
            this.groupBoxPedido.Size = new System.Drawing.Size(348, 307);
            this.groupBoxPedido.TabIndex = 18;
            this.groupBoxPedido.TabStop = false;
            this.groupBoxPedido.Text = "Pedido";
            this.groupBoxPedido.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonStats
            // 
            this.buttonStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStats.Location = new System.Drawing.Point(19, 391);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonStats.Size = new System.Drawing.Size(129, 47);
            this.buttonStats.TabIndex = 19;
            this.buttonStats.Text = "Estadísticas";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.groupBoxPedido);
            this.Controls.Add(this.buttonListPedido);
            this.Controls.Add(this.buttonProdCocina);
            this.Controls.Add(this.listBoxProdPedidos);
            this.Controls.Add(this.button_lista_prod);
            this.Controls.Add(this.BievenidoNombre);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.labelTituloMenu);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBoxModPedido.ResumeLayout(false);
            this.groupBoxModPedido.PerformLayout();
            this.groupBoxPedido.ResumeLayout(false);
            this.groupBoxPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloMenu;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBoxModPedido;
        private System.Windows.Forms.ComboBox comboBoxAgregarPlato;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label BievenidoNombre;
        private System.Windows.Forms.TextBox textBoxNombreMenu;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_lista_prod;
        private System.Windows.Forms.ListBox listBoxProdPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProdCocina;
        private System.Windows.Forms.Button buttonListPedido;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelNombreMenu;
        private System.Windows.Forms.GroupBox groupBoxPedido;
        private System.Windows.Forms.Button buttonStats;
    }
}