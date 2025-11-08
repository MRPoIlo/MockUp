namespace Mocap
{
    partial class Extra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extra));
            this.lvTitulo = new System.Windows.Forms.Label();
            this.tbObjetoA = new System.Windows.Forms.TextBox();
            this.tbObjetoB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clAspectos = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAgregar_Comparador = new System.Windows.Forms.Button();
            this.btCompara = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTitulo
            // 
            this.lvTitulo.AutoSize = true;
            this.lvTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(10)))), ((int)(((byte)(84)))));
            this.lvTitulo.Font = new System.Drawing.Font("Mistral", 27.84906F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvTitulo.Location = new System.Drawing.Point(312, 25);
            this.lvTitulo.Name = "lvTitulo";
            this.lvTitulo.Size = new System.Drawing.Size(185, 49);
            this.lvTitulo.TabIndex = 0;
            this.lvTitulo.Text = "K E D A W Y";
            // 
            // tbObjetoA
            // 
            this.tbObjetoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.tbObjetoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjetoA.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbObjetoA.Location = new System.Drawing.Point(26, 62);
            this.tbObjetoA.Multiline = true;
            this.tbObjetoA.Name = "tbObjetoA";
            this.tbObjetoA.Size = new System.Drawing.Size(176, 88);
            this.tbObjetoA.TabIndex = 1;
            this.tbObjetoA.Text = "Objeto a comparar 1";
            this.tbObjetoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbObjetoB
            // 
            this.tbObjetoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.tbObjetoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjetoB.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbObjetoB.Location = new System.Drawing.Point(366, 62);
            this.tbObjetoB.Multiline = true;
            this.tbObjetoB.Name = "tbObjetoB";
            this.tbObjetoB.Size = new System.Drawing.Size(176, 88);
            this.tbObjetoB.TabIndex = 2;
            this.tbObjetoB.Text = "Objeto a comparar 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(84)))), ((int)(((byte)(120)))));
            this.groupBox1.Controls.Add(this.btCompara);
            this.groupBox1.Controls.Add(this.btAgregar_Comparador);
            this.groupBox1.Controls.Add(this.tbObjetoB);
            this.groupBox1.Controls.Add(this.tbObjetoA);
            this.groupBox1.Location = new System.Drawing.Point(193, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparacion Menu";
            // 
            // clAspectos
            // 
            this.clAspectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
            this.clAspectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clAspectos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.clAspectos.FormattingEnabled = true;
            this.clAspectos.Items.AddRange(new object[] {
            "Estatus",
            "Fiabilidad",
            "Diseño",
            "Marca"});
            this.clAspectos.Location = new System.Drawing.Point(26, 100);
            this.clAspectos.Name = "clAspectos";
            this.clAspectos.Size = new System.Drawing.Size(120, 88);
            this.clAspectos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 469);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btAgregar_Comparador
            // 
            this.btAgregar_Comparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btAgregar_Comparador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar_Comparador.Font = new System.Drawing.Font("Microsoft Tai Le", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar_Comparador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregar_Comparador.Location = new System.Drawing.Point(26, 297);
            this.btAgregar_Comparador.Name = "btAgregar_Comparador";
            this.btAgregar_Comparador.Size = new System.Drawing.Size(170, 46);
            this.btAgregar_Comparador.TabIndex = 3;
            this.btAgregar_Comparador.Text = "Agregar Comparador";
            this.btAgregar_Comparador.UseVisualStyleBackColor = false;
            // 
            // btCompara
            // 
            this.btCompara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btCompara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCompara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCompara.Location = new System.Drawing.Point(213, 204);
            this.btCompara.Name = "btCompara";
            this.btCompara.Size = new System.Drawing.Size(148, 47);
            this.btCompara.TabIndex = 4;
            this.btCompara.Text = "Comparar";
            this.btCompara.UseVisualStyleBackColor = false;
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(84)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(809, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clAspectos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTitulo);
            this.Name = "Extra";
            this.Text = "Extra";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvTitulo;
        private System.Windows.Forms.TextBox tbObjetoA;
        private System.Windows.Forms.TextBox tbObjetoB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clAspectos;
        private System.Windows.Forms.Button btAgregar_Comparador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCompara;
    }
}