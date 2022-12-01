namespace formulaire
{
    partial class Nom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Modifer = new System.Windows.Forms.Button();
            this.Enregister = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Anuller = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.identifiant = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(445, 37);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(136, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prenom.Location = new System.Drawing.Point(150, 151);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(64, 20);
            this.prenom.TabIndex = 5;
            this.prenom.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(161, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom";
            // 
            // Modifer
            // 
            this.Modifer.BackColor = System.Drawing.SystemColors.Highlight;
            this.Modifer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifer.Location = new System.Drawing.Point(407, 197);
            this.Modifer.Name = "Modifer";
            this.Modifer.Size = new System.Drawing.Size(94, 48);
            this.Modifer.TabIndex = 7;
            this.Modifer.Text = "Modifier";
            this.Modifer.UseVisualStyleBackColor = false;
            this.Modifer.Click += new System.EventHandler(this.Modifer_Click);
            // 
            // Enregister
            // 
            this.Enregister.BackColor = System.Drawing.SystemColors.Highlight;
            this.Enregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregister.Location = new System.Drawing.Point(269, 197);
            this.Enregister.Name = "Enregister";
            this.Enregister.Size = new System.Drawing.Size(132, 48);
            this.Enregister.TabIndex = 8;
            this.Enregister.Text = "Enregistrer";
            this.Enregister.UseVisualStyleBackColor = false;
            this.Enregister.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(165, 195);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(98, 48);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(507, 197);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(110, 48);
            this.Supprimer.TabIndex = 10;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Anuller
            // 
            this.Anuller.BackColor = System.Drawing.SystemColors.Highlight;
            this.Anuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anuller.Location = new System.Drawing.Point(630, 195);
            this.Anuller.Name = "Anuller";
            this.Anuller.Size = new System.Drawing.Size(88, 48);
            this.Anuller.TabIndex = 11;
            this.Anuller.Text = "Anuller";
            this.Anuller.UseVisualStyleBackColor = false;
            this.Anuller.Click += new System.EventHandler(this.Anuller_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(445, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // identifiant
            // 
            this.identifiant.Location = new System.Drawing.Point(237, 64);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(445, 26);
            this.identifiant.TabIndex = 0;
            this.identifiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(445, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.Anuller);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Enregister);
            this.Controls.Add(this.Modifer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.identifiant);
            this.Name = "Nom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Modifer;
        private System.Windows.Forms.Button Enregister;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Anuller;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.TextBox textBox2;
    }
}

