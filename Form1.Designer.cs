namespace ImpliExam
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
            this.NomEx = new System.Windows.Forms.ComboBox();
            this.NomProf = new System.Windows.Forms.TextBox();
            this.Datedb = new System.Windows.Forms.TextBox();
            this.DateFin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeEx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomEx
            // 
            this.NomEx.FormattingEnabled = true;
            this.NomEx.Location = new System.Drawing.Point(278, 22);
            this.NomEx.Name = "NomEx";
            this.NomEx.Size = new System.Drawing.Size(121, 21);
            this.NomEx.TabIndex = 0;
            this.NomEx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NomProf
            // 
            this.NomProf.Location = new System.Drawing.Point(278, 63);
            this.NomProf.Name = "NomProf";
            this.NomProf.Size = new System.Drawing.Size(121, 20);
            this.NomProf.TabIndex = 1;
            // 
            // Datedb
            // 
            this.Datedb.Location = new System.Drawing.Point(278, 99);
            this.Datedb.Name = "Datedb";
            this.Datedb.Size = new System.Drawing.Size(121, 20);
            this.Datedb.TabIndex = 1;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(278, 135);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(121, 20);
            this.DateFin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Creer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prof :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Debut :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateFin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type Exam : ";
            // 
            // TypeEx
            // 
            this.TypeEx.Location = new System.Drawing.Point(278, 173);
            this.TypeEx.Name = "TypeEx";
            this.TypeEx.Size = new System.Drawing.Size(121, 20);
            this.TypeEx.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeEx);
            this.Controls.Add(this.DateFin);
            this.Controls.Add(this.Datedb);
            this.Controls.Add(this.NomProf);
            this.Controls.Add(this.NomEx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NomEx;
        private System.Windows.Forms.TextBox NomProf;
        private System.Windows.Forms.TextBox Datedb;
        private System.Windows.Forms.TextBox DateFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TypeEx;
    }
}

