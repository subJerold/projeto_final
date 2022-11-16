namespace Dupla_final_vendas
{
    partial class frm_produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descrição = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_categoria = new System.Windows.Forms.ComboBox();
            this.bnt_novo = new System.Windows.Forms.Button();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.bnt_excluir = new System.Windows.Forms.Button();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txt_Descrição
            // 
            this.txt_Descrição.Location = new System.Drawing.Point(90, 28);
            this.txt_Descrição.Name = "txt_Descrição";
            this.txt_Descrição.Size = new System.Drawing.Size(121, 20);
            this.txt_Descrição.TabIndex = 1;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(291, 28);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(121, 20);
            this.txt_Valor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // CB_categoria
            // 
            this.CB_categoria.FormattingEnabled = true;
            this.CB_categoria.Location = new System.Drawing.Point(528, 28);
            this.CB_categoria.Name = "CB_categoria";
            this.CB_categoria.Size = new System.Drawing.Size(121, 21);
            this.CB_categoria.TabIndex = 5;
            // 
            // bnt_novo
            // 
            this.bnt_novo.Location = new System.Drawing.Point(119, 110);
            this.bnt_novo.Name = "bnt_novo";
            this.bnt_novo.Size = new System.Drawing.Size(75, 23);
            this.bnt_novo.TabIndex = 6;
            this.bnt_novo.Text = "Novo";
            this.bnt_novo.UseVisualStyleBackColor = true;
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.Location = new System.Drawing.Point(229, 110);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bnt_cadastrar.TabIndex = 7;
            this.bnt_cadastrar.Text = "Cadastrar";
            this.bnt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bnt_excluir
            // 
            this.bnt_excluir.Location = new System.Drawing.Point(337, 110);
            this.bnt_excluir.Name = "bnt_excluir";
            this.bnt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bnt_excluir.TabIndex = 8;
            this.bnt_excluir.Text = "Excluir";
            this.bnt_excluir.UseVisualStyleBackColor = true;
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Location = new System.Drawing.Point(438, 110);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bnt_cancelar.TabIndex = 9;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 251);
            this.dataGridView1.TabIndex = 10;
            // 
            // frm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.bnt_excluir);
            this.Controls.Add(this.bnt_cadastrar);
            this.Controls.Add(this.bnt_novo);
            this.Controls.Add(this.CB_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Descrição);
            this.Controls.Add(this.label1);
            this.Name = "frm_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frm_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Descrição;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_categoria;
        private System.Windows.Forms.Button bnt_novo;
        private System.Windows.Forms.Button bnt_cadastrar;
        private System.Windows.Forms.Button bnt_excluir;
        private System.Windows.Forms.Button bnt_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}