namespace CineLF.FE
{
    partial class ListaPelis
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtSillas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.DGVPelis = new System.Windows.Forms.DataGridView();
            this.btMu = new System.Windows.Forms.Button();
            this.btFood = new System.Windows.Forms.Button();
            this.btBuy = new System.Windows.Forms.Button();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.txtPrecioFood = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVFood = new System.Windows.Forms.DataGridView();
            this.btAceptarFood = new System.Windows.Forms.Button();
            this.btBuscarPeli = new System.Windows.Forms.Button();
            this.btBorrarPeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(77, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(183, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Location = new System.Drawing.Point(395, 89);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 3;
            this.txtTime.Visible = false;
            // 
            // txtSillas
            // 
            this.txtSillas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSillas.Location = new System.Drawing.Point(289, 88);
            this.txtSillas.Name = "txtSillas";
            this.txtSillas.Size = new System.Drawing.Size(100, 20);
            this.txtSillas.TabIndex = 2;
            this.txtSillas.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(180, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(392, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asientos";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(286, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horario";
            this.label4.Visible = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAceptar.Location = new System.Drawing.Point(568, 84);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(78, 30);
            this.btAceptar.TabIndex = 11;
            this.btAceptar.Text = "Agregar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Visible = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // DGVPelis
            // 
            this.DGVPelis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPelis.Location = new System.Drawing.Point(29, 151);
            this.DGVPelis.Name = "DGVPelis";
            this.DGVPelis.Size = new System.Drawing.Size(524, 259);
            this.DGVPelis.TabIndex = 12;
            this.DGVPelis.Visible = false;
            // 
            // btMu
            // 
            this.btMu.Location = new System.Drawing.Point(43, 12);
            this.btMu.Name = "btMu";
            this.btMu.Size = new System.Drawing.Size(102, 35);
            this.btMu.TabIndex = 13;
            this.btMu.Text = "Añadir Pelicula";
            this.btMu.UseVisualStyleBackColor = true;
            this.btMu.Click += new System.EventHandler(this.btMu_Click);
            // 
            // btFood
            // 
            this.btFood.Location = new System.Drawing.Point(151, 12);
            this.btFood.Name = "btFood";
            this.btFood.Size = new System.Drawing.Size(102, 35);
            this.btFood.TabIndex = 14;
            this.btFood.Text = "Añadir Comida";
            this.btFood.UseVisualStyleBackColor = true;
            this.btFood.Click += new System.EventHandler(this.btFood_Click);
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(259, 12);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(102, 35);
            this.btBuy.TabIndex = 15;
            this.btBuy.Text = "Realizar Compra";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // txtNameFood
            // 
            this.txtNameFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameFood.Location = new System.Drawing.Point(77, 89);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(100, 20);
            this.txtNameFood.TabIndex = 16;
            this.txtNameFood.Visible = false;
            // 
            // txtPrecioFood
            // 
            this.txtPrecioFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecioFood.Location = new System.Drawing.Point(183, 89);
            this.txtPrecioFood.Name = "txtPrecioFood";
            this.txtPrecioFood.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFood.TabIndex = 17;
            this.txtPrecioFood.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(289, 114);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(286, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad";
            this.label5.Visible = false;
            // 
            // DGVFood
            // 
            this.DGVFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFood.Location = new System.Drawing.Point(29, 151);
            this.DGVFood.Name = "DGVFood";
            this.DGVFood.Size = new System.Drawing.Size(524, 259);
            this.DGVFood.TabIndex = 20;
            this.DGVFood.Visible = false;
            // 
            // btAceptarFood
            // 
            this.btAceptarFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAceptarFood.Location = new System.Drawing.Point(652, 84);
            this.btAceptarFood.Name = "btAceptarFood";
            this.btAceptarFood.Size = new System.Drawing.Size(78, 30);
            this.btAceptarFood.TabIndex = 21;
            this.btAceptarFood.Text = "Agregar";
            this.btAceptarFood.UseVisualStyleBackColor = true;
            this.btAceptarFood.Visible = false;
            this.btAceptarFood.Click += new System.EventHandler(this.btAceptarFood_Click);
            // 
            // btBuscarPeli
            // 
            this.btBuscarPeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBuscarPeli.Location = new System.Drawing.Point(568, 124);
            this.btBuscarPeli.Name = "btBuscarPeli";
            this.btBuscarPeli.Size = new System.Drawing.Size(78, 30);
            this.btBuscarPeli.TabIndex = 22;
            this.btBuscarPeli.Text = "Buscar";
            this.btBuscarPeli.UseVisualStyleBackColor = true;
            this.btBuscarPeli.Click += new System.EventHandler(this.btBuscarPeli_Click);
            // 
            // btBorrarPeli
            // 
            this.btBorrarPeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBorrarPeli.Location = new System.Drawing.Point(568, 160);
            this.btBorrarPeli.Name = "btBorrarPeli";
            this.btBorrarPeli.Size = new System.Drawing.Size(78, 30);
            this.btBorrarPeli.TabIndex = 23;
            this.btBorrarPeli.Text = "Borrar";
            this.btBorrarPeli.UseVisualStyleBackColor = true;
            this.btBorrarPeli.Click += new System.EventHandler(this.btBorrarPeli_Click);
            // 
            // ListaPelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.btBorrarPeli);
            this.Controls.Add(this.btBuscarPeli);
            this.Controls.Add(this.btAceptarFood);
            this.Controls.Add(this.DGVFood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioFood);
            this.Controls.Add(this.txtNameFood);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.btFood);
            this.Controls.Add(this.btMu);
            this.Controls.Add(this.DGVPelis);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSillas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtName);
            this.Name = "ListaPelis";
            this.Text = "ListaPelis";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtSillas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView DGVPelis;
        private System.Windows.Forms.Button btMu;
        private System.Windows.Forms.Button btFood;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.TextBox txtPrecioFood;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVFood;
        private System.Windows.Forms.Button btAceptarFood;
        private System.Windows.Forms.Button btBuscarPeli;
        private System.Windows.Forms.Button btBorrarPeli;
    }
}