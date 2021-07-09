namespace Painel
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.horaData = new System.Windows.Forms.Timer(this.components);
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnMarketing = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.btnPedidos = new FontAwesome.Sharp.IconButton();
            this.btnPainel = new FontAwesome.Sharp.IconButton();
            this.ButtonFechar = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnMarketing);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnPainel);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 591);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(257, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(24, 51);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(211, 29);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "J\'adore Boutique";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            this.panelBarraTitulo.Controls.Add(this.ButtonFechar);
            this.panelBarraTitulo.Controls.Add(this.lblChildForm);
            this.panelBarraTitulo.Controls.Add(this.iconCurrentChild);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(257, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(727, 80);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.lblChildForm.Location = new System.Drawing.Point(70, 33);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(55, 18);
            this.lblChildForm.TabIndex = 2;
            this.lblChildForm.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.panelDesktop.Controls.Add(this.lblData);
            this.panelDesktop.Controls.Add(this.lblLogo);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(257, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(727, 511);
            this.panelDesktop.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            this.lblHora.Location = new System.Drawing.Point(309, 240);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(113, 38);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "label1";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.lblLogo.Location = new System.Drawing.Point(166, 166);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(427, 59);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "J\'adore Boutique";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            this.lblData.Location = new System.Drawing.Point(186, 286);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(78, 26);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "label1";
            // 
            // horaData
            // 
            this.horaData.Enabled = true;
            this.horaData.Tick += new System.EventHandler(this.horaData_Tick);
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 33;
            this.iconCurrentChild.Location = new System.Drawing.Point(30, 26);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(33, 33);
            this.iconCurrentChild.TabIndex = 2;
            this.iconCurrentChild.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnConfig.IconColor = System.Drawing.Color.White;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 440);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfig.Size = new System.Drawing.Size(257, 60);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarketing.FlatAppearance.BorderSize = 0;
            this.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketing.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketing.ForeColor = System.Drawing.Color.White;
            this.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnMarketing.IconColor = System.Drawing.Color.White;
            this.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarketing.IconSize = 32;
            this.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.Location = new System.Drawing.Point(0, 380);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMarketing.Size = new System.Drawing.Size(257, 60);
            this.btnMarketing.TabIndex = 4;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 320);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Size = new System.Drawing.Size(257, 60);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProdutos.IconColor = System.Drawing.Color.White;
            this.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutos.IconSize = 32;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 260);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProdutos.Size = new System.Drawing.Size(257, 60);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnPedidos.IconColor = System.Drawing.Color.White;
            this.btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPedidos.IconSize = 32;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 200);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPedidos.Size = new System.Drawing.Size(257, 60);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnPainel.IconColor = System.Drawing.Color.White;
            this.btnPainel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPainel.IconSize = 32;
            this.btnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.Location = new System.Drawing.Point(0, 140);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPainel.Size = new System.Drawing.Size(257, 60);
            this.btnPainel.TabIndex = 0;
            this.btnPainel.Text = "Painel";
            this.btnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.FlatAppearance.BorderSize = 0;
            this.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ButtonFechar.IconColor = System.Drawing.Color.White;
            this.ButtonFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonFechar.IconSize = 22;
            this.ButtonFechar.Location = new System.Drawing.Point(694, 3);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(30, 30);
            this.ButtonFechar.TabIndex = 6;
            this.ButtonFechar.UseVisualStyleBackColor = true;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J\'adore Boutique";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPainel;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer horaData;
        private FontAwesome.Sharp.IconButton ButtonFechar;
    }
}

