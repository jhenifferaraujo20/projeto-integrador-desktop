namespace Painel
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFormClientes = new System.Windows.Forms.Panel();
            this.ButtonNovoCliente = new FontAwesome.Sharp.IconButton();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.labelBusca = new System.Windows.Forms.Label();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.ButtonExcluir = new FontAwesome.Sharp.IconButton();
            this.ButtonAlterar = new FontAwesome.Sharp.IconButton();
            this.panelFormClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormClientes
            // 
            this.panelFormClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.panelFormClientes.Controls.Add(this.ButtonAlterar);
            this.panelFormClientes.Controls.Add(this.ButtonExcluir);
            this.panelFormClientes.Controls.Add(this.labelBusca);
            this.panelFormClientes.Controls.Add(this.textBoxBusca);
            this.panelFormClientes.Controls.Add(this.ButtonNovoCliente);
            this.panelFormClientes.Controls.Add(this.GridClientes);
            this.panelFormClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormClientes.Location = new System.Drawing.Point(0, 0);
            this.panelFormClientes.Name = "panelFormClientes";
            this.panelFormClientes.Size = new System.Drawing.Size(711, 463);
            this.panelFormClientes.TabIndex = 0;
            // 
            // ButtonNovoCliente
            // 
            this.ButtonNovoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.ButtonNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNovoCliente.FlatAppearance.BorderSize = 0;
            this.ButtonNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovoCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovoCliente.ForeColor = System.Drawing.Color.White;
            this.ButtonNovoCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ButtonNovoCliente.IconColor = System.Drawing.Color.White;
            this.ButtonNovoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNovoCliente.IconSize = 22;
            this.ButtonNovoCliente.Location = new System.Drawing.Point(280, 425);
            this.ButtonNovoCliente.Name = "ButtonNovoCliente";
            this.ButtonNovoCliente.Size = new System.Drawing.Size(85, 30);
            this.ButtonNovoCliente.TabIndex = 1;
            this.ButtonNovoCliente.Text = "Novo";
            this.ButtonNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNovoCliente.UseVisualStyleBackColor = false;
            this.ButtonNovoCliente.Click += new System.EventHandler(this.ButtonNovoCliente_Click);
            // 
            // GridClientes
            // 
            this.GridClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            this.GridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridClientes.ColumnHeadersHeight = 30;
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridClientes.EnableHeadersVisualStyles = false;
            this.GridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            this.GridClientes.Location = new System.Drawing.Point(88, 76);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.GridClientes.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.GridClientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.GridClientes.RowTemplate.Height = 26;
            this.GridClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridClientes.Size = new System.Drawing.Size(537, 329);
            this.GridClientes.TabIndex = 0;
            // 
            // labelBusca
            // 
            this.labelBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBusca.AutoSize = true;
            this.labelBusca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.labelBusca.Location = new System.Drawing.Point(85, 21);
            this.labelBusca.Name = "labelBusca";
            this.labelBusca.Size = new System.Drawing.Size(108, 14);
            this.labelBusca.TabIndex = 3;
            this.labelBusca.Text = "Nome do cliente";
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.textBoxBusca.Location = new System.Drawing.Point(88, 41);
            this.textBoxBusca.Multiline = true;
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(220, 20);
            this.textBoxBusca.TabIndex = 2;
            this.textBoxBusca.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.ButtonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExcluir.ForeColor = System.Drawing.Color.White;
            this.ButtonExcluir.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ButtonExcluir.IconColor = System.Drawing.Color.White;
            this.ButtonExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonExcluir.IconSize = 22;
            this.ButtonExcluir.Location = new System.Drawing.Point(184, 425);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(85, 30);
            this.ButtonExcluir.TabIndex = 4;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExcluir.UseVisualStyleBackColor = false;
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.ButtonAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAlterar.FlatAppearance.BorderSize = 0;
            this.ButtonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlterar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlterar.ForeColor = System.Drawing.Color.White;
            this.ButtonAlterar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ButtonAlterar.IconColor = System.Drawing.Color.White;
            this.ButtonAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAlterar.IconSize = 22;
            this.ButtonAlterar.Location = new System.Drawing.Point(88, 425);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(85, 30);
            this.ButtonAlterar.TabIndex = 5;
            this.ButtonAlterar.Text = "Alterar";
            this.ButtonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAlterar.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 463);
            this.Controls.Add(this.panelFormClientes);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelFormClientes.ResumeLayout(false);
            this.panelFormClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormClientes;
        private System.Windows.Forms.DataGridView GridClientes;
        private FontAwesome.Sharp.IconButton ButtonNovoCliente;
        private System.Windows.Forms.Label labelBusca;
        private System.Windows.Forms.TextBox textBoxBusca;
        private FontAwesome.Sharp.IconButton ButtonAlterar;
        private FontAwesome.Sharp.IconButton ButtonExcluir;
    }
}