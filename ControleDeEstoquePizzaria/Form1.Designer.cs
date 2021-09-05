
namespace ControleDeEstoquePapelaria
{
    partial class Form1  
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSabor = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.dgPizzaria = new System.Windows.Forms.DataGridView();
            this.btInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIgredientes = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIgredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPizzaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sabor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // tbSabor
            // 
            this.tbSabor.Location = new System.Drawing.Point(62, 19);
            this.tbSabor.Name = "tbSabor";
            this.tbSabor.Size = new System.Drawing.Size(120, 20);
            this.tbSabor.TabIndex = 5;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(233, 19);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(120, 20);
            this.tbTipo.TabIndex = 6;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(429, 19);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(120, 20);
            this.tbCategoria.TabIndex = 7;
            // 
            // dgPizzaria
            // 
            this.dgPizzaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPizzaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colSabor,
            this.colTipo,
            this.colCategoria,
            this.colIgredientes});
            this.dgPizzaria.Location = new System.Drawing.Point(21, 128);
            this.dgPizzaria.Name = "dgPizzaria";
            this.dgPizzaria.Size = new System.Drawing.Size(643, 146);
            this.dgPizzaria.TabIndex = 8;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btInserir.Location = new System.Drawing.Point(566, 19);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(98, 27);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(566, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Red;
            this.btLimpar.Location = new System.Drawing.Point(566, 86);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(98, 27);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Deletar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Igredientes:";
            // 
            // tbIgredientes
            // 
            this.tbIgredientes.Location = new System.Drawing.Point(86, 93);
            this.tbIgredientes.Name = "tbIgredientes";
            this.tbIgredientes.Size = new System.Drawing.Size(463, 20);
            this.tbIgredientes.TabIndex = 13;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colSabor
            // 
            this.colSabor.HeaderText = "Sabor";
            this.colSabor.Name = "colSabor";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colIgredientes
            // 
            this.colIgredientes.HeaderText = "Igredientes";
            this.colIgredientes.Name = "colIgredientes";
            this.colIgredientes.Width = 270;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 288);
            this.Controls.Add(this.tbIgredientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgPizzaria);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.tbSabor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Controle de Estoque - Pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPizzaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSabor;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.DataGridView dgPizzaria;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIgredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIgredientes;
    }
}

