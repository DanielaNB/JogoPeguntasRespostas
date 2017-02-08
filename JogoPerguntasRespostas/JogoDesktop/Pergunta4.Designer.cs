namespace JogoDesktop
{
    partial class Pergunta4
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
            this.btnPP1.Location = new System.Drawing.Point(229, 261);
            this.btnPP1.Name = "btnPP1";
            this.btnPP1.Size = new System.Drawing.Size(143, 45);
            this.btnPP1.TabIndex = 17;
            this.btnPP1.Text = "Finalizar";
            this.btnPP1.UseVisualStyleBackColor = true;
            this.btnPP1.Click += new System.EventHandler(this.btnPP1_Click);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(80, 208);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(88, 17);
            this.rdbResposta4.TabIndex = 16;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "Heterocromia";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(80, 172);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(101, 17);
            this.rdbResposta3.TabIndex = 15;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "Olhos diferentes";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbRes2
            // 
            this.rdbRes2.AutoSize = true;
            this.rdbRes2.Location = new System.Drawing.Point(80, 138);
            this.rdbRes2.Name = "rdbRes2";
            this.rdbRes2.Size = new System.Drawing.Size(84, 17);
            this.rdbRes2.TabIndex = 14;
            this.rdbRes2.TabStop = true;
            this.rdbRes2.Text = "Homocromia";
            this.rdbRes2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(80, 104);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(74, 17);
            this.rdbResposta1.TabIndex = 13;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "Heterolhar";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Location = new System.Drawing.Point(12, 44);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(362, 13);
            this.lblPergunta1.TabIndex = 12;
            this.lblPergunta1.Text = "Qual o nome da anomalia genética que deixa a cor de cada olho diferente?";
            // 
            // Pergunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.btnPP1);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbRes2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta1);
            this.Name = "Pergunta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 3";
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