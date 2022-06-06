namespace Zuma
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label3 = new System.Windows.Forms.Label();
            this.Elemento = new System.Windows.Forms.TextBox();
            this.BotãoInserir = new System.Windows.Forms.Button();
            this.Indíce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tela = new System.Windows.Forms.ListBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Posição";
            // 
            // Elemento
            // 
            this.Elemento.Enabled = false;
            this.Elemento.Location = new System.Drawing.Point(119, 344);
            this.Elemento.Name = "Elemento";
            this.Elemento.Size = new System.Drawing.Size(40, 20);
            this.Elemento.TabIndex = 19;
            // 
            // BotãoInserir
            // 
            this.BotãoInserir.BackColor = System.Drawing.Color.Yellow;
            this.BotãoInserir.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BotãoInserir.Location = new System.Drawing.Point(112, 370);
            this.BotãoInserir.Name = "BotãoInserir";
            this.BotãoInserir.Size = new System.Drawing.Size(114, 42);
            this.BotãoInserir.TabIndex = 18;
            this.BotãoInserir.Text = "Inserir";
            this.BotãoInserir.UseVisualStyleBackColor = false;
            this.BotãoInserir.Click += new System.EventHandler(this.button1_Click_2);
            this.BotãoInserir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // Indíce
            // 
            this.Indíce.Location = new System.Drawing.Point(173, 344);
            this.Indíce.Name = "Indíce";
            this.Indíce.Size = new System.Drawing.Size(42, 20);
            this.Indíce.TabIndex = 17;
            this.Indíce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Indíce_KeyDown);
            this.Indíce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Indíce_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "PONTUAÇÃO";
            // 
            // Tela
            // 
            this.Tela.BackColor = System.Drawing.Color.Green;
            this.Tela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tela.ForeColor = System.Drawing.Color.White;
            this.Tela.FormattingEnabled = true;
            this.Tela.ItemHeight = 25;
            this.Tela.Location = new System.Drawing.Point(40, 61);
            this.Tela.Name = "Tela";
            this.Tela.Size = new System.Drawing.Size(285, 254);
            this.Tela.TabIndex = 15;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.White;
            this.Score.Enabled = false;
            this.Score.Location = new System.Drawing.Point(171, 37);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 20);
            this.Score.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.Voltar);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Sair);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 404);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.Blue;
            this.Voltar.Font = new System.Drawing.Font("Stencil", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(12, 367);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(50, 25);
            this.Voltar.TabIndex = 25;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(134, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 25);
            this.button3.TabIndex = 24;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sair.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(12, 341);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(50, 25);
            this.Sair.TabIndex = 23;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(220, 333);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zuma.Properties.Resources._1u8kmu2qqr_2mavqrcrjt_file1;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 125);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zuma.Properties.Resources._1u8kmu2qqr_2mavqrcrjt_file1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(366, 457);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Elemento);
            this.Controls.Add(this.BotãoInserir);
            this.Controls.Add(this.Indíce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tela);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "Zuma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Elemento;
        private System.Windows.Forms.Button BotãoInserir;
        private System.Windows.Forms.TextBox Indíce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Tela;
        public System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button button3;
    }
}