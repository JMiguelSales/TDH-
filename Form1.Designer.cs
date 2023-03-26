namespace Tdh
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
            this.tilte = new System.Windows.Forms.TextBox();
            this.Vr1 = new System.Windows.Forms.Button();
            this.Vr2 = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.PictureBox();
            this.SecundarioB = new System.Windows.Forms.PictureBox();
            this.SecundarioA = new System.Windows.Forms.PictureBox();
            this.Pontos = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecundarioB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecundarioA)).BeginInit();
            this.SuspendLayout();
            // 
            // tilte
            // 
            this.tilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilte.Location = new System.Drawing.Point(55, 37);
            this.tilte.Name = "tilte";
            this.tilte.Size = new System.Drawing.Size(703, 45);
            this.tilte.TabIndex = 0;
            this.tilte.Text = "Versão modelo com ambos tipos de testes";
            // 
            // Vr1
            // 
            this.Vr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vr1.Location = new System.Drawing.Point(12, 113);
            this.Vr1.Name = "Vr1";
            this.Vr1.Size = new System.Drawing.Size(149, 67);
            this.Vr1.TabIndex = 1;
            this.Vr1.Text = " Brain & Development";
            this.Vr1.UseVisualStyleBackColor = true;
            this.Vr1.Click += new System.EventHandler(this.Vr1_Click);
            // 
            // Vr2
            // 
            this.Vr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vr2.Location = new System.Drawing.Point(12, 203);
            this.Vr2.Name = "Vr2";
            this.Vr2.Size = new System.Drawing.Size(149, 63);
            this.Vr2.TabIndex = 2;
            this.Vr2.Text = "Brain Sci.";
            this.Vr2.UseVisualStyleBackColor = true;
            this.Vr2.Click += new System.EventHandler(this.Vr2_Click);
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.Location = new System.Drawing.Point(373, 203);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(33, 35);
            this.Principal.TabIndex = 3;
            this.Principal.TabStop = false;
            this.Principal.Visible = false;
            // 
            // SecundarioB
            // 
            this.SecundarioB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SecundarioB.Location = new System.Drawing.Point(430, 203);
            this.SecundarioB.Name = "SecundarioB";
            this.SecundarioB.Size = new System.Drawing.Size(36, 34);
            this.SecundarioB.TabIndex = 4;
            this.SecundarioB.TabStop = false;
            this.SecundarioB.Visible = false;
            // 
            // SecundarioA
            // 
            this.SecundarioA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SecundarioA.Location = new System.Drawing.Point(316, 204);
            this.SecundarioA.Name = "SecundarioA";
            this.SecundarioA.Size = new System.Drawing.Size(36, 34);
            this.SecundarioA.TabIndex = 5;
            this.SecundarioA.TabStop = false;
            this.SecundarioA.Visible = false;
            // 
            // Pontos
            // 
            this.Pontos.Location = new System.Drawing.Point(373, 98);
            this.Pontos.Name = "Pontos";
            this.Pontos.Size = new System.Drawing.Size(33, 22);
            this.Pontos.TabIndex = 6;
            this.Pontos.Text = "0";
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(316, 337);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(180, 72);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Parar";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pontos);
            this.Controls.Add(this.SecundarioA);
            this.Controls.Add(this.SecundarioB);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Vr2);
            this.Controls.Add(this.Vr1);
            this.Controls.Add(this.tilte);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecundarioB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecundarioA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tilte;
        private System.Windows.Forms.Button Vr1;
        private System.Windows.Forms.Button Vr2;
        private System.Windows.Forms.PictureBox Principal;
        private System.Windows.Forms.PictureBox SecundarioB;
        private System.Windows.Forms.PictureBox SecundarioA;
        private System.Windows.Forms.TextBox Pontos;
        private System.Windows.Forms.Button Stop;
    }
}

