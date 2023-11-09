
namespace projeto11à13
{
    partial class frmTabuada
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnquanto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnRepita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(153, 94);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 0;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(55, 97);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(92, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Digite um número:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(210, 176);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(350, 53);
            this.txtResultado.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(367, 139);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEnquanto
            // 
            this.btnEnquanto.Location = new System.Drawing.Point(312, 356);
            this.btnEnquanto.Name = "btnEnquanto";
            this.btnEnquanto.Size = new System.Drawing.Size(75, 23);
            this.btnEnquanto.TabIndex = 5;
            this.btnEnquanto.Text = "Enquanto";
            this.btnEnquanto.UseVisualStyleBackColor = true;
            this.btnEnquanto.Click += new System.EventHandler(this.btnEnquanto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(164, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(475, 356);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(75, 23);
            this.btnPara.TabIndex = 7;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnRepita
            // 
            this.btnRepita.Location = new System.Drawing.Point(394, 356);
            this.btnRepita.Name = "btnRepita";
            this.btnRepita.Size = new System.Drawing.Size(75, 23);
            this.btnRepita.TabIndex = 8;
            this.btnRepita.Text = "Repita";
            this.btnRepita.UseVisualStyleBackColor = true;
            this.btnRepita.Click += new System.EventHandler(this.btnRepita_Click);
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepita);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnquanto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Name = "frmTabuada";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnquanto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnRepita;
    }
}