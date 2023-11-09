
namespace projeto11à13
{
    partial class frmCômodos
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
            this.lblLargura = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreatotal = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtAreatotal = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(93, 58);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(137, 13);
            this.lblLargura.TabIndex = 0;
            this.lblLargura.Text = "Digite a largura do cômodo:";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(271, 55);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(100, 20);
            this.txtLargura.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(93, 132);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(131, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Digite o nome do cômodo:";
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Location = new System.Drawing.Point(93, 95);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(165, 13);
            this.lblComprimento.TabIndex = 3;
            this.lblComprimento.Text = "Digite o comprimento do cômodo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(271, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(271, 92);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(100, 20);
            this.txtComprimento.TabIndex = 5;
            this.txtComprimento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(93, 197);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(88, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Área do cômodo:";
            // 
            // lblAreatotal
            // 
            this.lblAreatotal.AutoSize = true;
            this.lblAreatotal.Location = new System.Drawing.Point(93, 235);
            this.lblAreatotal.Name = "lblAreatotal";
            this.lblAreatotal.Size = new System.Drawing.Size(55, 13);
            this.lblAreatotal.TabIndex = 7;
            this.lblAreatotal.Text = "Área total:";
            this.lblAreatotal.Visible = false;
            this.lblAreatotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(271, 194);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 8;
            // 
            // txtAreatotal
            // 
            this.txtAreatotal.Location = new System.Drawing.Point(271, 232);
            this.txtAreatotal.Name = "txtAreatotal";
            this.txtAreatotal.Size = new System.Drawing.Size(100, 20);
            this.txtAreatotal.TabIndex = 9;
            this.txtAreatotal.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(195, 318);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(308, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCômodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtAreatotal);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblAreatotal);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblComprimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.lblLargura);
            this.Name = "frmCômodos";
            this.Text = "Cômodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreatotal;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtAreatotal;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}