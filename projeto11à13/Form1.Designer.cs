﻿
namespace projeto11à13
{
    partial class FrmMenu
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
            this.exercício11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício11ToolStripMenuItem,
            this.exercício12ToolStripMenuItem,
            this.exercício13ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercício11ToolStripMenuItem
            // 
            this.exercício11ToolStripMenuItem.Name = "exercício11ToolStripMenuItem";
            this.exercício11ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.exercício11ToolStripMenuItem.Text = "Exercício 11";
            this.exercício11ToolStripMenuItem.Click += new System.EventHandler(this.exercício11ToolStripMenuItem_Click);
            // 
            // exercício12ToolStripMenuItem
            // 
            this.exercício12ToolStripMenuItem.Name = "exercício12ToolStripMenuItem";
            this.exercício12ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.exercício12ToolStripMenuItem.Text = "Exercício 12";
            this.exercício12ToolStripMenuItem.Click += new System.EventHandler(this.exercício12ToolStripMenuItem_Click);
            // 
            // exercício13ToolStripMenuItem
            // 
            this.exercício13ToolStripMenuItem.Name = "exercício13ToolStripMenuItem";
            this.exercício13ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.exercício13ToolStripMenuItem.Text = "Exercício 13";
            this.exercício13ToolStripMenuItem.Click += new System.EventHandler(this.exercício13ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercício11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

