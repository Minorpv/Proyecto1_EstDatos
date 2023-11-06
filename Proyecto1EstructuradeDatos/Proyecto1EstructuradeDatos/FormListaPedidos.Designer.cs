namespace Proyecto1EstructuradeDatos
{
    partial class FormListaPedidos
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
            this.buttonPedidoComp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxColaPedido = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPedidoComp
            // 
            this.buttonPedidoComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPedidoComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedidoComp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonPedidoComp.Location = new System.Drawing.Point(610, 9);
            this.buttonPedidoComp.Name = "buttonPedidoComp";
            this.buttonPedidoComp.Size = new System.Drawing.Size(178, 71);
            this.buttonPedidoComp.TabIndex = 1;
            this.buttonPedidoComp.Text = "Pedido Completado";
            this.buttonPedidoComp.UseVisualStyleBackColor = false;
            this.buttonPedidoComp.Click += new System.EventHandler(this.buttonPedidoComp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cola de Pedidos";
            // 
            // listBoxColaPedido
            // 
            this.listBoxColaPedido.FormattingEnabled = true;
            this.listBoxColaPedido.Location = new System.Drawing.Point(13, 88);
            this.listBoxColaPedido.Name = "listBoxColaPedido";
            this.listBoxColaPedido.Size = new System.Drawing.Size(775, 303);
            this.listBoxColaPedido.TabIndex = 3;
            // 
            // FormListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxColaPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPedidoComp);
            this.Name = "FormListaPedidos";
            this.Text = "FormListaPedidos";
            this.Load += new System.EventHandler(this.FormListaPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPedidoComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxColaPedido;
    }
}