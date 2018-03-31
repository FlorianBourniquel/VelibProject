namespace Bourniquel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStation = new System.Windows.Forms.ListBox();
            this.listBoxInfoStation = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxVille = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir une ville";
            // 
            // listBoxStation
            // 
            this.listBoxStation.FormattingEnabled = true;
            this.listBoxStation.HorizontalScrollbar = true;
            this.listBoxStation.ItemHeight = 20;
            this.listBoxStation.Location = new System.Drawing.Point(738, 302);
            this.listBoxStation.Name = "listBoxStation";
            this.listBoxStation.Size = new System.Drawing.Size(705, 284);
            this.listBoxStation.TabIndex = 3;
            this.listBoxStation.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxInfoStation
            // 
            this.listBoxInfoStation.FormattingEnabled = true;
            this.listBoxInfoStation.HorizontalScrollbar = true;
            this.listBoxInfoStation.ItemHeight = 20;
            this.listBoxInfoStation.Location = new System.Drawing.Point(12, 682);
            this.listBoxInfoStation.Name = "listBoxInfoStation";
            this.listBoxInfoStation.Size = new System.Drawing.Size(1431, 324);
            this.listBoxInfoStation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informations de la station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "VELIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choisir une station";
            // 
            // listBoxVille
            // 
            this.listBoxVille.FormattingEnabled = true;
            this.listBoxVille.HorizontalScrollbar = true;
            this.listBoxVille.ItemHeight = 20;
            this.listBoxVille.Location = new System.Drawing.Point(20, 302);
            this.listBoxVille.Name = "listBoxVille";
            this.listBoxVille.Size = new System.Drawing.Size(677, 284);
            this.listBoxVille.TabIndex = 10;
            this.listBoxVille.SelectedIndexChanged += new System.EventHandler(this.listBoxVille_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 55);
            this.label6.TabIndex = 12;
            this.label6.Text = "Async";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(458, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Delta derniere update data (en secondes)";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(492, 217);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(951, 26);
            this.textBoxTime.TabIndex = 14;
            this.textBoxTime.Text = "0";
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 1086);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxVille);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxInfoStation);
            this.Controls.Add(this.listBoxStation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Velib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStation;
        private System.Windows.Forms.ListBox listBoxInfoStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxVille;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}

