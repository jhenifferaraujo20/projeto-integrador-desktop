namespace Painel
{
    partial class FormProdutos
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
            this.panelFormProdutos = new System.Windows.Forms.Panel();
            this.ButtonAlterar = new FontAwesome.Sharp.IconButton();
            this.ButtonExcluir = new FontAwesome.Sharp.IconButton();
            this.labelBusca = new System.Windows.Forms.Label();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.ButtonNovo = new FontAwesome.Sharp.IconButton();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.panelFormProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormProdutos
            // 
            this.panelFormProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.panelFormProdutos.Controls.Add(this.ButtonAlterar);
            this.panelFormProdutos.Controls.Add(this.ButtonExcluir);
            this.panelFormProdutos.Controls.Add(this.labelBusca);
            this.panelFormProdutos.Controls.Add(this.textBoxBusca);
            this.panelFormProdutos.Controls.Add(this.ButtonNovo);
            this.panelFormProdutos.Controls.Add(this.GridProdutos);
            this.panelFormProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelFormProdutos.Name = "panelFormProdutos";
            this.panelFormProdutos.Size = new System.Drawing.Size(711, 463);
            this.panelFormProdutos.TabIndex = 1;
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
            // labelBusca
            // 
            this.labelBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBusca.AutoSize = true;
            this.labelBusca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.labelBusca.Location = new System.Drawing.Point(85, 21);
            this.labelBusca.Name = "labelBusca";
            this.labelBusca.Size = new System.Drawing.Size(117, 14);
            this.labelBusca.TabIndex = 3;
            this.labelBusca.Text = "Nome do produto";
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
            // ButtonNovo
            // 
            this.ButtonNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.ButtonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNovo.FlatAppearance.BorderSize = 0;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovo.ForeColor = System.Drawing.Color.White;
            this.ButtonNovo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ButtonNovo.IconColor = System.Drawing.Color.White;
            this.ButtonNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNovo.IconSize = 22;
            this.ButtonNovo.Location = new System.Drawing.Point(280, 425);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(85, 30);
            this.ButtonNovo.TabIndex = 1;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonNovo.UseVisualStyleBackColor = false;
            // 
            // GridProdutos
            // 
            this.GridProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridProdutos.ColumnHeadersHeight = 30;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProdutos.EnableHeadersVisualStyles = false;
            this.GridProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(178)))), ((int)(((byte)(143)))));
            this.GridProdutos.Location = new System.Drawing.Point(88, 76);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.GridProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(139)))), ((int)(((byte)(86)))));
            this.GridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.GridProdutos.RowTemplate.Height = 26;
            this.GridProdutos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(537, 329);
            this.GridProdutos.TabIndex = 0;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 463);
            this.Controls.Add(this.panelFormProdutos);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panelFormProdutos.ResumeLayout(false);
            this.panelFormProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormProdutos;
        private FontAwesome.Sharp.IconButton ButtonAlterar;
        private FontAwesome.Sharp.IconButton ButtonExcluir;
        private System.Windows.Forms.Label labelBusca;
        private System.Windows.Forms.TextBox textBoxBusca;
        private FontAwesome.Sharp.IconButton ButtonNovo;
        private System.Windows.Forms.DataGridView GridProdutos;
    }
}