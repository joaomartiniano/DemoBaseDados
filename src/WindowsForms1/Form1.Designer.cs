
namespace WindowsForms1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaCategorias1 = new System.Windows.Forms.ListBox();
            this.ListaCategorias2 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaCategorias3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demonstração de Ligação a Base de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categorias (sem ID):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categorias (com ID):";
            // 
            // ListaCategorias1
            // 
            this.ListaCategorias1.FormattingEnabled = true;
            this.ListaCategorias1.Location = new System.Drawing.Point(27, 134);
            this.ListaCategorias1.Name = "ListaCategorias1";
            this.ListaCategorias1.Size = new System.Drawing.Size(214, 212);
            this.ListaCategorias1.TabIndex = 3;
            // 
            // ListaCategorias2
            // 
            this.ListaCategorias2.HideSelection = false;
            this.ListaCategorias2.Location = new System.Drawing.Point(314, 134);
            this.ListaCategorias2.Name = "ListaCategorias2";
            this.ListaCategorias2.Size = new System.Drawing.Size(214, 212);
            this.ListaCategorias2.TabIndex = 4;
            this.ListaCategorias2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categorias (combobox):";
            // 
            // ListaCategorias3
            // 
            this.ListaCategorias3.FormattingEnabled = true;
            this.ListaCategorias3.Location = new System.Drawing.Point(590, 134);
            this.ListaCategorias3.Name = "ListaCategorias3";
            this.ListaCategorias3.Size = new System.Drawing.Size(169, 21);
            this.ListaCategorias3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Obter dados da tabela Categorias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListaCategorias3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaCategorias2);
            this.Controls.Add(this.ListaCategorias1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListaCategorias1;
        private System.Windows.Forms.ListView ListaCategorias2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ListaCategorias3;
        private System.Windows.Forms.Label label5;
    }
}

