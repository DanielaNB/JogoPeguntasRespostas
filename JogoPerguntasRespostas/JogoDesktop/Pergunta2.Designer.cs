namespace JogoDesktop
{
    partial class Pergunta2
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
            this.btnPP1 = new System.Windows.Forms.Button();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbRes2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPP1
            // 
            this.btnPP1.Location = new System.Drawing.Point(152, 257);
            this.btnPP1.Name = "btnPP1";
            this.btnPP1.Size = new System.Drawing.Size(143, 45);
            this.btnPP1.TabIndex = 11;
            this.btnPP1.Text = "Próxima pergunta";
            this.btnPP1.UseVisualStyleBackColor = true;
            this.btnPP1.Click += new System.EventHandler(this.btnPP1_Click);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(83, 214);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(37, 17);
            this.rdbResposta4.TabIndex = 10;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "12";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(83, 178);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(37, 17);
            this.rdbResposta3.TabIndex = 9;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "14";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbRes2
            // 
            this.rdbRes2.AutoSize = true;
            this.rdbRes2.Location = new System.Drawing.Point(83, 144);
            this.rdbRes2.Name = "rdbRes2";
            this.rdbRes2.Size = new System.Drawing.Size(37, 17);
            this.rdbRes2.TabIndex = 8;
            this.rdbRes2.TabStop = true;
            this.rdbRes2.Text = "10";
            this.rdbRes2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(83, 110);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(37, 17);
            this.rdbResposta1.TabIndex = 7;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "11";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Location = new System.Drawing.Point(80, 41);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(84, 13);
            this.lblPergunta1.TabIndex = 6;
            this.lblPergunta1.Text = "Quanto é 4 + 7?";
            // 
            // Pergunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 355);
            this.Controls.Add(this.btnPP1);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbRes2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta1);
            this.Name = "Pergunta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta2";
            this.Load += new System.EventHandler(this.Pergunta2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPP1;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbRes2;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.Label lblPergunta1;
    }
}