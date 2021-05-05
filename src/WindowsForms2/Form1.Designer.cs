
namespace WindowsForms2
{
    partial class Form1
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
            this.ListaProdutos = new System.Windows.Forms.ListView();
            this.NumeroRegistos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdProduto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesignacaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VolumeProduto = new System.Windows.Forms.TextBox();
            this.PesoProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UnidadesStockProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MarcaProduto = new System.Windows.Forms.TextBox();
            this.CategoriaProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.HideSelection = false;
            this.ListaProdutos.Location = new System.Drawing.Point(26, 65);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(256, 302);
            this.ListaProdutos.TabIndex = 1;
            this.ListaProdutos.UseCompatibleStateImageBehavior = false;
            this.ListaProdutos.SelectedIndexChanged += new System.EventHandler(this.ListaProdutos_SelectedIndexChanged);
            // 
            // NumeroRegistos
            // 
            this.NumeroRegistos.AutoSize = true;
            this.NumeroRegistos.Location = new System.Drawing.Point(26, 374);
            this.NumeroRegistos.Name = "NumeroRegistos";
            this.NumeroRegistos.Size = new System.Drawing.Size(35, 13);
            this.NumeroRegistos.TabIndex = 2;
            this.NumeroRegistos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // IdProduto
            // 
            this.IdProduto.AutoSize = true;
            this.IdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduto.Location = new System.Drawing.Point(328, 65);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Size = new System.Drawing.Size(41, 13);
            this.IdProduto.TabIndex = 4;
            this.IdProduto.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Designação:";
            // 
            // DesignacaoProduto
            // 
            this.DesignacaoProduto.Location = new System.Drawing.Point(308, 117);
            this.DesignacaoProduto.Name = "DesignacaoProduto";
            this.DesignacaoProduto.Size = new System.Drawing.Size(310, 20);
            this.DesignacaoProduto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço:";
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.Location = new System.Drawing.Point(636, 117);
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.Size = new System.Drawing.Size(59, 20);
            this.PrecoProduto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição:";
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(308, 177);
            this.DescricaoProduto.Multiline = true;
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(387, 55);
            this.DescricaoProduto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Volume:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Peso:";
            // 
            // VolumeProduto
            // 
            this.VolumeProduto.Location = new System.Drawing.Point(308, 268);
            this.VolumeProduto.Name = "VolumeProduto";
            this.VolumeProduto.Size = new System.Drawing.Size(158, 20);
            this.VolumeProduto.TabIndex = 14;
            // 
            // PesoProduto
            // 
            this.PesoProduto.Location = new System.Drawing.Point(472, 267);
            this.PesoProduto.Name = "PesoProduto";
            this.PesoProduto.Size = new System.Drawing.Size(158, 20);
            this.PesoProduto.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unidades Stock:";
            // 
            // UnidadesStockProduto
            // 
            this.UnidadesStockProduto.Location = new System.Drawing.Point(636, 267);
            this.UnidadesStockProduto.Name = "UnidadesStockProduto";
            this.UnidadesStockProduto.Size = new System.Drawing.Size(59, 20);
            this.UnidadesStockProduto.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Marca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Categoria:";
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.Location = new System.Drawing.Point(308, 318);
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.Size = new System.Drawing.Size(201, 20);
            this.MarcaProduto.TabIndex = 20;
            // 
            // CategoriaProduto
            // 
            this.CategoriaProduto.Location = new System.Drawing.Point(515, 318);
            this.CategoriaProduto.Name = "CategoriaProduto";
            this.CategoriaProduto.Size = new System.Drawing.Size(180, 20);
            this.CategoriaProduto.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.CategoriaProduto);
            this.Controls.Add(this.MarcaProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UnidadesStockProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PesoProduto);
            this.Controls.Add(this.VolumeProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescricaoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DesignacaoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroRegistos);
            this.Controls.Add(this.ListaProdutos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaProdutos;
        private System.Windows.Forms.Label NumeroRegistos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DesignacaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VolumeProduto;
        private System.Windows.Forms.TextBox PesoProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UnidadesStockProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MarcaProduto;
        private System.Windows.Forms.TextBox CategoriaProduto;
    }
}

