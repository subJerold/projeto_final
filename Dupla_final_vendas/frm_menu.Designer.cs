﻿namespace Dupla_final_vendas
{
    partial class frm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consuToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consuToolStripMenuItem
            // 
            this.consuToolStripMenuItem.Name = "consuToolStripMenuItem";
            this.consuToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consuToolStripMenuItem.Text = "Consultas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.btn_cad_produtos.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_produtos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_produtos.Image = global::Dupla_final_vendas.Properties.Resources.cadastro_de_produto;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(12, 42);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(114, 108);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadastrar produtos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = false;
            this.btn_cad_produtos.Click += new System.EventHandler(this.btn_cad_produtos_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.btn_cad_categorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_categorias.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_categorias.Image = global::Dupla_final_vendas.Properties.Resources.cadastrar_categoria;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(161, 42);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(114, 108);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar Categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = false;
            this.btn_cad_categorias.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dupla_final_vendas.Properties.Resources.fundo_branco;
            this.ClientSize = new System.Drawing.Size(932, 492);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.ToolStripMenuItem consuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
    }
}

